﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using AutoRest.CSharp.Input;
using AutoRest.CSharp.Mgmt.AutoRest;
using AutoRest.CSharp.Mgmt.Models;

namespace AutoRest.CSharp.Mgmt.Decorator.Transformer
{
    internal static class SchemaRenamer
    {
        public static void ApplyRenameMapping()
        {
            var renameTargets = new List<RenameTarget>();
            foreach ((var key, var newName) in Configuration.MgmtConfiguration.RenameMapping)
            {
                renameTargets.Add(ParseRenameKey(key, newName));
            }

            // apply them one by one
            foreach (var schema in MgmtContext.CodeModel.AllSchemas)
            {
                ApplyRenameTargets(schema, renameTargets);
            }
        }

        private static void ApplyRenameTargets(Schema schema, IEnumerable<RenameTarget> renameTargets)
        {
            foreach (var target in renameTargets)
            {
                ApplyRenameTarget(schema, target);
            }
        }

        private static void ApplyRenameTarget(Schema schema, RenameTarget renameTarget)
        {
            switch (schema)
            {
                case ChoiceSchema choiceSchema:
                    ApplyChoiceSchema(choiceSchema, renameTarget);
                    break;
                case SealedChoiceSchema sealedChoiceSchema:
                    ApplySealedChoiceSchema(sealedChoiceSchema, renameTarget);
                    break;
                case ObjectSchema objectSchema: // GroupSchema inherits from ObjectSchema, therefore this line changes both
                    ApplyObjectSchema(objectSchema, renameTarget);
                    break;
            }
        }

        private static void ApplyChoiceSchema(ChoiceSchema choiceSchema, RenameTarget renameTarget)
        {
            switch (renameTarget.RenameType)
            {
                case RenameType.Type:
                    ApplyToType(choiceSchema, renameTarget);
                    break;
                case RenameType.Property:
                    ApplyToProperty(choiceSchema, choiceSchema.Choices, renameTarget);
                    break;
            }
        }

        private static void ApplySealedChoiceSchema(SealedChoiceSchema sealedChoiceSchema, RenameTarget renameTarget)
        {
            switch (renameTarget.RenameType)
            {
                case RenameType.Type:
                    ApplyToType(sealedChoiceSchema, renameTarget);
                    break;
                case RenameType.Property:
                    ApplyToProperty(sealedChoiceSchema, sealedChoiceSchema.Choices, renameTarget);
                    break;
            }
        }

        private static void ApplyObjectSchema(ObjectSchema objectSchema, RenameTarget renameTarget)
        {
            switch (renameTarget.RenameType)
            {
                case RenameType.Type:
                    ApplyToType(objectSchema, renameTarget);
                    break;
                case RenameType.Property:
                    ApplyToProperty(objectSchema, objectSchema.Properties, renameTarget);
                    break;
            }
        }

        private static void ApplyToType(Schema schema, RenameTarget renameTarget)
        {
            if (schema.GetOriginalName() != renameTarget.TypeName)
                return;
            schema.Language.Default.SerializedName ??= schema.Language.Default.Name;
            schema.Language.Default.Name = renameTarget.NewName;
        }

        private static void ApplyToProperty(Schema schema, IEnumerable<ChoiceValue> choices, RenameTarget renameTarget)
        {
            if (schema.GetOriginalName() != renameTarget.TypeName)
                return;
            var choiceValue = choices.FirstOrDefault(choice => choice.Value == renameTarget.PropertyName);
            if (choiceValue == null)
                return;
            choiceValue.Language.Default.SerializedName ??= choiceValue.Language.Default.Name;
            choiceValue.Language.Default.Name = renameTarget.NewName;
        }

        private static void ApplyToProperty(Schema schema, IEnumerable<Property> properties, RenameTarget renameTarget)
        {
            Debug.Assert(renameTarget.PropertyName != null);
            if (schema.GetOriginalName() != renameTarget.TypeName)
                return;
            // check if the property renaming is targeting a flattened property
            var flattenedNames = Array.Empty<string>();
            if (renameTarget.PropertyName.Contains('.'))
            {
                flattenedNames = renameTarget.PropertyName.Split('.');
            }
            var propertySerializedName = flattenedNames.LastOrDefault() ?? renameTarget.PropertyName;
            // filter the property name by the serialized name
            var filteredProperties = properties.Where(p => p.SerializedName == propertySerializedName);
            var property = filteredProperties.FirstOrDefault(p => p.FlattenedNames.SequenceEqual(flattenedNames));
            if (property == null)
                return;
            property.Language.Default.SerializedName ??= property.Language.Default.Name;
            property.Language.Default.Name = renameTarget.NewName;
        }

        public static void UpdateAcronyms()
        {
            if (Configuration.MgmtConfiguration.RenameRules.Count == 0)
                return;
            // first transform all the name of schemas, properties
            UpdateAcronyms(MgmtContext.CodeModel.AllSchemas);
            // transform all the parameter names
            UpdateAcronyms(MgmtContext.CodeModel.OperationGroups);
        }

        private static RenameTarget ParseRenameKey(string renameKey, string newName)
        {
            // we do not support escape the character dot right now. In case in the future some swagger might have dot inside a property name, we need to support this. Really?
            if (renameKey.Contains('.'))
            {
                // this should be a renaming of property
                var segments = renameKey.Split('.', 2); // split at the first dot
                return new RenameTarget(RenameType.Property, segments[0], segments[1], newName);
            }
            else
            {
                // this should be a renaming of type
                return new RenameTarget(RenameType.Type, renameKey, null, newName);
            }
        }

        private record RenameTarget(RenameType RenameType, string TypeName, string? PropertyName, string NewName);

        private enum RenameType
        {
            Type = 0, Property = 1
        }

        public static void UpdateAcronym(Schema schema)
        {
            if (Configuration.MgmtConfiguration.RenameRules.Count == 0)
                return;
            TransformSchema(schema);
        }

        private static void UpdateAcronyms(IEnumerable<Schema> allSchemas)
        {
            foreach (var schema in allSchemas)
            {
                TransformSchema(schema);
            }
        }

        private static void UpdateAcronyms(IEnumerable<OperationGroup> operationGroups)
        {
            foreach (var operationGroup in operationGroups)
            {
                foreach (var operation in operationGroup.Operations)
                {
                    TransformOperation(operation);
                }
            }
        }

        private static void TransformOperation(Operation operation)
        {
            TransformLanguage(operation.Language);
            // this iteration only applies to path and query parameter (maybe headers?) but not to body parameter
            foreach (var parameter in operation.Parameters)
            {
                TransformLanguage(parameter.Language);
            }

            // we need to iterate over the parameters in each request (actually only one request) to ensure the name of body parameters are also taken care of
            foreach (var request in operation.Requests)
            {
                foreach (var parameter in request.Parameters)
                {
                    TransformLanguage(parameter.Language);
                }
            }
        }

        private static void TransformSchema(Schema schema)
        {
            switch (schema)
            {
                case ChoiceSchema choiceSchema:
                    TransformChoiceSchema(choiceSchema.Language, choiceSchema.Choices);
                    break;
                case SealedChoiceSchema sealedChoiceSchema:
                    TransformChoiceSchema(sealedChoiceSchema.Language, sealedChoiceSchema.Choices);
                    break;
                case ObjectSchema objSchema: // GroupSchema inherits ObjectSchema, therefore we do not need to handle that
                    TransformObjectSchema(objSchema);
                    break;
                default:
                    throw new InvalidOperationException($"Unknown schema type {schema.GetType()}");
            }
        }

        private static void TransformChoiceSchema(Languages languages, ICollection<ChoiceValue> choiceValues)
        {
            TransformLanguage(languages);
            TransformChoices(choiceValues);
        }

        private static void TransformChoices(ICollection<ChoiceValue> choiceValues)
        {
            foreach (var choiceValue in choiceValues)
            {
                TransformLanguage(choiceValue.Language);
            }
        }

        private static void TransformLanguage(Languages languages)
        {
            var originalName = languages.Default.Name;
            var result = NameTransformer.Instance.EnsureNameCase(originalName);
            languages.Default.Name = result.Name;
            languages.Default.SerializedName ??= originalName;
        }

        private static void TransformObjectSchema(ObjectSchema objSchema)
        {
            // transform the name of this schema
            TransformLanguage(objSchema.Language);
            foreach (var property in objSchema.Properties)
            {
                TransformLanguage(property.Language);
            }
        }
    }
}

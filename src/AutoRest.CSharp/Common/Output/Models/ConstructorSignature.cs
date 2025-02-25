// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Collections.Generic;
using AutoRest.CSharp.Output.Models.Shared;

namespace AutoRest.CSharp.Output.Models
{
    internal record ConstructorSignature(string Name, string? Summary, string? Description, MethodSignatureModifiers Modifiers, IReadOnlyList<Parameter> Parameters, ConstructorInitializer? Initializer = null) : MethodSignatureBase(Name, Summary, Description, Modifiers, Parameters);
}

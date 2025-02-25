// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace MgmtRenameRules.Models
{
    public partial class VmScaleSetConvertToSinglePlacementGroupContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ActivePlacementGroupId))
            {
                writer.WritePropertyName("activePlacementGroupId");
                writer.WriteStringValue(ActivePlacementGroupId);
            }
            writer.WriteEndObject();
        }
    }
}

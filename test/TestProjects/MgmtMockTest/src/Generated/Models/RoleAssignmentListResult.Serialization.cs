// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using MgmtMockTest;

namespace MgmtMockTest.Models
{
    internal partial class RoleAssignmentListResult
    {
        internal static RoleAssignmentListResult DeserializeRoleAssignmentListResult(JsonElement element)
        {
            Optional<IReadOnlyList<RoleAssignmentData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<RoleAssignmentData> array = new List<RoleAssignmentData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RoleAssignmentData.DeserializeRoleAssignmentData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new RoleAssignmentListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}

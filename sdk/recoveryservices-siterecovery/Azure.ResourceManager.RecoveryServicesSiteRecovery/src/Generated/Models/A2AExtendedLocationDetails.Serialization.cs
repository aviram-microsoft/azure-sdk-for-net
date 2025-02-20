// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class A2AExtendedLocationDetails
    {
        internal static A2AExtendedLocationDetails DeserializeA2AExtendedLocationDetails(JsonElement element)
        {
            Optional<ExtendedLocation> primaryExtendedLocation = default;
            Optional<ExtendedLocation> recoveryExtendedLocation = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryExtendedLocation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    primaryExtendedLocation = ExtendedLocation.DeserializeExtendedLocation(property.Value);
                    continue;
                }
                if (property.NameEquals("recoveryExtendedLocation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    recoveryExtendedLocation = ExtendedLocation.DeserializeExtendedLocation(property.Value);
                    continue;
                }
            }
            return new A2AExtendedLocationDetails(primaryExtendedLocation.Value, recoveryExtendedLocation.Value);
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Orbital.Models
{
    public partial class OrbitalContactAntennaConfiguration
    {
        internal static OrbitalContactAntennaConfiguration DeserializeOrbitalContactAntennaConfiguration(JsonElement element)
        {
            Optional<IPAddress> destinationIP = default;
            Optional<IReadOnlyList<IPAddress>> sourceIPs = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("destinationIp"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    destinationIP = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceIps"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<IPAddress> array = new List<IPAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IPAddress.Parse(item.GetString()));
                    }
                    sourceIPs = array;
                    continue;
                }
            }
            return new OrbitalContactAntennaConfiguration(destinationIP.Value, Optional.ToList(sourceIPs));
        }
    }
}

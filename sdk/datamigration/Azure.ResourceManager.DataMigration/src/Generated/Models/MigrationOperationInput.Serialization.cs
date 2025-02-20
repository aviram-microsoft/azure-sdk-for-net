// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrationOperationInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MigrationOperationId))
            {
                writer.WritePropertyName("migrationOperationId");
                writer.WriteStringValue(MigrationOperationId.Value);
            }
            writer.WriteEndObject();
        }
    }
}

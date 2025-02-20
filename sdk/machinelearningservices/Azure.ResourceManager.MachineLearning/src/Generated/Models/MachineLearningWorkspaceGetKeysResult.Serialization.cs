// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningWorkspaceGetKeysResult
    {
        internal static MachineLearningWorkspaceGetKeysResult DeserializeMachineLearningWorkspaceGetKeysResult(JsonElement element)
        {
            Optional<string> userStorageKey = default;
            Optional<string> userStorageResourceId = default;
            Optional<string> appInsightsInstrumentationKey = default;
            Optional<MachineLearningContainerRegistryCredentials> containerRegistryCredentials = default;
            Optional<MachineLearningWorkspaceGetNotebookKeysResult> notebookAccessKeys = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("userStorageKey"))
                {
                    userStorageKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userStorageResourceId"))
                {
                    userStorageResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appInsightsInstrumentationKey"))
                {
                    appInsightsInstrumentationKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerRegistryCredentials"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    containerRegistryCredentials = MachineLearningContainerRegistryCredentials.DeserializeMachineLearningContainerRegistryCredentials(property.Value);
                    continue;
                }
                if (property.NameEquals("notebookAccessKeys"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    notebookAccessKeys = MachineLearningWorkspaceGetNotebookKeysResult.DeserializeMachineLearningWorkspaceGetNotebookKeysResult(property.Value);
                    continue;
                }
            }
            return new MachineLearningWorkspaceGetKeysResult(userStorageKey.Value, userStorageResourceId.Value, appInsightsInstrumentationKey.Value, containerRegistryCredentials.Value, notebookAccessKeys.Value);
        }
    }
}

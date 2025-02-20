// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class GovernanceRuleData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName");
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(RemediationTimeframe))
            {
                writer.WritePropertyName("remediationTimeframe");
                writer.WriteStringValue(RemediationTimeframe);
            }
            if (Optional.IsDefined(IsGracePeriod))
            {
                writer.WritePropertyName("isGracePeriod");
                writer.WriteBooleanValue(IsGracePeriod.Value);
            }
            if (Optional.IsDefined(RulePriority))
            {
                writer.WritePropertyName("rulePriority");
                writer.WriteNumberValue(RulePriority.Value);
            }
            if (Optional.IsDefined(IsDisabled))
            {
                writer.WritePropertyName("isDisabled");
                writer.WriteBooleanValue(IsDisabled.Value);
            }
            if (Optional.IsDefined(RuleType))
            {
                writer.WritePropertyName("ruleType");
                writer.WriteStringValue(RuleType.Value.ToString());
            }
            if (Optional.IsDefined(SourceResourceType))
            {
                writer.WritePropertyName("sourceResourceType");
                writer.WriteStringValue(SourceResourceType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ConditionSets))
            {
                writer.WritePropertyName("conditionSets");
                writer.WriteStartArray();
                foreach (var item in ConditionSets)
                {
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(item.ToString()).RootElement);
#endif
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(OwnerSource))
            {
                writer.WritePropertyName("ownerSource");
                writer.WriteObjectValue(OwnerSource);
            }
            if (Optional.IsDefined(GovernanceEmailNotification))
            {
                writer.WritePropertyName("governanceEmailNotification");
                writer.WriteObjectValue(GovernanceEmailNotification);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static GovernanceRuleData DeserializeGovernanceRuleData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> displayName = default;
            Optional<string> description = default;
            Optional<string> remediationTimeframe = default;
            Optional<bool> isGracePeriod = default;
            Optional<int> rulePriority = default;
            Optional<bool> isDisabled = default;
            Optional<GovernanceRuleType> ruleType = default;
            Optional<GovernanceRuleSourceResourceType> sourceResourceType = default;
            Optional<IList<BinaryData>> conditionSets = default;
            Optional<GovernanceRuleOwnerSource> ownerSource = default;
            Optional<GovernanceRuleEmailNotification> governanceEmailNotification = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("displayName"))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("remediationTimeframe"))
                        {
                            remediationTimeframe = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isGracePeriod"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isGracePeriod = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("rulePriority"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            rulePriority = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("isDisabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isDisabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("ruleType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            ruleType = new GovernanceRuleType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sourceResourceType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sourceResourceType = new GovernanceRuleSourceResourceType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("conditionSets"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<BinaryData> array = new List<BinaryData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(BinaryData.FromString(item.GetRawText()));
                            }
                            conditionSets = array;
                            continue;
                        }
                        if (property0.NameEquals("ownerSource"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            ownerSource = GovernanceRuleOwnerSource.DeserializeGovernanceRuleOwnerSource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("governanceEmailNotification"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            governanceEmailNotification = GovernanceRuleEmailNotification.DeserializeGovernanceRuleEmailNotification(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new GovernanceRuleData(id, name, type, systemData.Value, displayName.Value, description.Value, remediationTimeframe.Value, Optional.ToNullable(isGracePeriod), Optional.ToNullable(rulePriority), Optional.ToNullable(isDisabled), Optional.ToNullable(ruleType), Optional.ToNullable(sourceResourceType), Optional.ToList(conditionSets), ownerSource.Value, governanceEmailNotification.Value);
        }
    }
}

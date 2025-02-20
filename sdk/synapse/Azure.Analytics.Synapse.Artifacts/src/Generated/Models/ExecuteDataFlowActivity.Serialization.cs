// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(ExecuteDataFlowActivityConverter))]
    public partial class ExecuteDataFlowActivity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(LinkedServiceName))
            {
                writer.WritePropertyName("linkedServiceName");
                writer.WriteObjectValue(LinkedServiceName);
            }
            if (Optional.IsDefined(Policy))
            {
                writer.WritePropertyName("policy");
                writer.WriteObjectValue(Policy);
            }
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(DependsOn))
            {
                writer.WritePropertyName("dependsOn");
                writer.WriteStartArray();
                foreach (var item in DependsOn)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(UserProperties))
            {
                writer.WritePropertyName("userProperties");
                writer.WriteStartArray();
                foreach (var item in UserProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties");
            writer.WriteStartObject();
            writer.WritePropertyName("dataflow");
            writer.WriteObjectValue(Dataflow);
            if (Optional.IsDefined(Staging))
            {
                writer.WritePropertyName("staging");
                writer.WriteObjectValue(Staging);
            }
            if (Optional.IsDefined(IntegrationRuntime))
            {
                writer.WritePropertyName("integrationRuntime");
                writer.WriteObjectValue(IntegrationRuntime);
            }
            if (Optional.IsDefined(Compute))
            {
                writer.WritePropertyName("compute");
                writer.WriteObjectValue(Compute);
            }
            if (Optional.IsDefined(TraceLevel))
            {
                writer.WritePropertyName("traceLevel");
                writer.WriteObjectValue(TraceLevel);
            }
            if (Optional.IsDefined(ContinueOnError))
            {
                writer.WritePropertyName("continueOnError");
                writer.WriteObjectValue(ContinueOnError);
            }
            if (Optional.IsDefined(RunConcurrently))
            {
                writer.WritePropertyName("runConcurrently");
                writer.WriteObjectValue(RunConcurrently);
            }
            if (Optional.IsDefined(SourceStagingConcurrency))
            {
                writer.WritePropertyName("sourceStagingConcurrency");
                writer.WriteObjectValue(SourceStagingConcurrency);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static ExecuteDataFlowActivity DeserializeExecuteDataFlowActivity(JsonElement element)
        {
            Optional<LinkedServiceReference> linkedServiceName = default;
            Optional<ActivityPolicy> policy = default;
            string name = default;
            string type = default;
            Optional<string> description = default;
            Optional<IList<ActivityDependency>> dependsOn = default;
            Optional<IList<UserProperty>> userProperties = default;
            DataFlowReference dataflow = default;
            Optional<DataFlowStagingInfo> staging = default;
            Optional<IntegrationRuntimeReference> integrationRuntime = default;
            Optional<ExecuteDataFlowActivityTypePropertiesCompute> compute = default;
            Optional<object> traceLevel = default;
            Optional<object> continueOnError = default;
            Optional<object> runConcurrently = default;
            Optional<object> sourceStagingConcurrency = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkedServiceName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    linkedServiceName = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("policy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    policy = ActivityPolicy.DeserializeActivityPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dependsOn"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ActivityDependency> array = new List<ActivityDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ActivityDependency.DeserializeActivityDependency(item));
                    }
                    dependsOn = array;
                    continue;
                }
                if (property.NameEquals("userProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<UserProperty> array = new List<UserProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UserProperty.DeserializeUserProperty(item));
                    }
                    userProperties = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("dataflow"))
                        {
                            dataflow = DataFlowReference.DeserializeDataFlowReference(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("staging"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            staging = DataFlowStagingInfo.DeserializeDataFlowStagingInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("integrationRuntime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            integrationRuntime = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("compute"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            compute = ExecuteDataFlowActivityTypePropertiesCompute.DeserializeExecuteDataFlowActivityTypePropertiesCompute(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("traceLevel"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            traceLevel = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("continueOnError"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            continueOnError = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("runConcurrently"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            runConcurrently = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("sourceStagingConcurrency"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sourceStagingConcurrency = property0.Value.GetObject();
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ExecuteDataFlowActivity(name, type, description.Value, Optional.ToList(dependsOn), Optional.ToList(userProperties), additionalProperties, linkedServiceName.Value, policy.Value, dataflow, staging.Value, integrationRuntime.Value, compute.Value, traceLevel.Value, continueOnError.Value, runConcurrently.Value, sourceStagingConcurrency.Value);
        }

        internal partial class ExecuteDataFlowActivityConverter : JsonConverter<ExecuteDataFlowActivity>
        {
            public override void Write(Utf8JsonWriter writer, ExecuteDataFlowActivity model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override ExecuteDataFlowActivity Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeExecuteDataFlowActivity(document.RootElement);
            }
        }
    }
}

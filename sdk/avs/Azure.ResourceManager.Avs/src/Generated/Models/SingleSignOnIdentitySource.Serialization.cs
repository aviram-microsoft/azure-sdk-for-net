// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    public partial class SingleSignOnIdentitySource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Alias))
            {
                writer.WritePropertyName("alias");
                writer.WriteStringValue(Alias);
            }
            if (Optional.IsDefined(Domain))
            {
                writer.WritePropertyName("domain");
                writer.WriteStringValue(Domain);
            }
            if (Optional.IsDefined(BaseUserDN))
            {
                writer.WritePropertyName("baseUserDN");
                writer.WriteStringValue(BaseUserDN);
            }
            if (Optional.IsDefined(BaseGroupDN))
            {
                writer.WritePropertyName("baseGroupDN");
                writer.WriteStringValue(BaseGroupDN);
            }
            if (Optional.IsDefined(PrimaryServer))
            {
                writer.WritePropertyName("primaryServer");
                writer.WriteStringValue(PrimaryServer.AbsoluteUri);
            }
            if (Optional.IsDefined(SecondaryServer))
            {
                writer.WritePropertyName("secondaryServer");
                writer.WriteStringValue(SecondaryServer.AbsoluteUri);
            }
            if (Optional.IsDefined(Ssl))
            {
                writer.WritePropertyName("ssl");
                writer.WriteStringValue(Ssl.Value.ToString());
            }
            if (Optional.IsDefined(Username))
            {
                writer.WritePropertyName("username");
                writer.WriteStringValue(Username);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password");
                writer.WriteStringValue(Password);
            }
            writer.WriteEndObject();
        }

        internal static SingleSignOnIdentitySource DeserializeSingleSignOnIdentitySource(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> @alias = default;
            Optional<string> domain = default;
            Optional<string> baseUserDN = default;
            Optional<string> baseGroupDN = default;
            Optional<Uri> primaryServer = default;
            Optional<Uri> secondaryServer = default;
            Optional<SslCertificateStatus> ssl = default;
            Optional<string> username = default;
            Optional<string> password = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("alias"))
                {
                    @alias = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domain"))
                {
                    domain = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("baseUserDN"))
                {
                    baseUserDN = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("baseGroupDN"))
                {
                    baseGroupDN = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryServer"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        primaryServer = null;
                        continue;
                    }
                    primaryServer = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("secondaryServer"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        secondaryServer = null;
                        continue;
                    }
                    secondaryServer = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ssl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    ssl = new SslCertificateStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("username"))
                {
                    username = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"))
                {
                    password = property.Value.GetString();
                    continue;
                }
            }
            return new SingleSignOnIdentitySource(name.Value, @alias.Value, domain.Value, baseUserDN.Value, baseGroupDN.Value, primaryServer.Value, secondaryServer.Value, Optional.ToNullable(ssl), username.Value, password.Value);
        }
    }
}

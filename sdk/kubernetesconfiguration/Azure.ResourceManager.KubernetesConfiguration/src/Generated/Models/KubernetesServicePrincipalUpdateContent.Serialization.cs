// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    public partial class KubernetesServicePrincipalUpdateContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ClientId))
            {
                if (ClientId != null)
                {
                    writer.WritePropertyName("clientId");
                    writer.WriteStringValue(ClientId.Value);
                }
                else
                {
                    writer.WriteNull("clientId");
                }
            }
            if (Optional.IsDefined(TenantId))
            {
                if (TenantId != null)
                {
                    writer.WritePropertyName("tenantId");
                    writer.WriteStringValue(TenantId.Value);
                }
                else
                {
                    writer.WriteNull("tenantId");
                }
            }
            if (Optional.IsDefined(ClientSecret))
            {
                if (ClientSecret != null)
                {
                    writer.WritePropertyName("clientSecret");
                    writer.WriteStringValue(ClientSecret);
                }
                else
                {
                    writer.WriteNull("clientSecret");
                }
            }
            if (Optional.IsDefined(ClientCertificate))
            {
                if (ClientCertificate != null)
                {
                    writer.WritePropertyName("clientCertificate");
                    writer.WriteStringValue(ClientCertificate);
                }
                else
                {
                    writer.WriteNull("clientCertificate");
                }
            }
            if (Optional.IsDefined(ClientCertificatePassword))
            {
                if (ClientCertificatePassword != null)
                {
                    writer.WritePropertyName("clientCertificatePassword");
                    writer.WriteStringValue(ClientCertificatePassword);
                }
                else
                {
                    writer.WriteNull("clientCertificatePassword");
                }
            }
            if (Optional.IsDefined(ClientCertificateSendChain))
            {
                writer.WritePropertyName("clientCertificateSendChain");
                writer.WriteBooleanValue(ClientCertificateSendChain.Value);
            }
            writer.WriteEndObject();
        }
    }
}

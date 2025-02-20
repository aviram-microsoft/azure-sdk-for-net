// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> IP firewall rule properties. </summary>
    public partial class IPFirewallRuleProperties
    {
        /// <summary> Initializes a new instance of IPFirewallRuleProperties. </summary>
        public IPFirewallRuleProperties()
        {
        }

        /// <summary> The end IP address of the firewall rule. Must be IPv4 format. Must be greater than or equal to startIpAddress. </summary>
        public string EndIPAddress { get; set; }
        /// <summary> Resource provisioning state. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The start IP address of the firewall rule. Must be IPv4 format. </summary>
        public string StartIPAddress { get; set; }
    }
}

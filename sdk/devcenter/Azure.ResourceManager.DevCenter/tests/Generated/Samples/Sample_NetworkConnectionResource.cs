// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.DevCenter.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DevCenter
{
    public partial class Sample_NetworkConnectionResource
    {
        // NetworkConnections_ListBySubscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetNetworkConnections_NetworkConnectionsListBySubscription()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/preview/2022-08-01-preview/examples/NetworkConnections_ListBySubscription.json
            // this example is just showing the usage of "NetworkConnections_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "{subscriptionId}";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (NetworkConnectionResource item in subscriptionResource.GetNetworkConnectionsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkConnectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // NetworkConnections_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_NetworkConnectionsGet()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/preview/2022-08-01-preview/examples/NetworkConnections_Get.json
            // this example is just showing the usage of "NetworkConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this NetworkConnectionResource created on azure
            // for more information of creating NetworkConnectionResource, please refer to the document of NetworkConnectionResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "rg1";
            string networkConnectionName = "uswest3network";
            ResourceIdentifier networkConnectionResourceId = NetworkConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkConnectionName);
            NetworkConnectionResource networkConnection = client.GetNetworkConnectionResource(networkConnectionResourceId);

            // invoke the operation
            NetworkConnectionResource result = await networkConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // NetworkConnections_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_NetworkConnectionsUpdate()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/preview/2022-08-01-preview/examples/NetworkConnections_Patch.json
            // this example is just showing the usage of "NetworkConnections_Update" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this NetworkConnectionResource created on azure
            // for more information of creating NetworkConnectionResource, please refer to the document of NetworkConnectionResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "rg1";
            string networkConnectionName = "uswest3network";
            ResourceIdentifier networkConnectionResourceId = NetworkConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkConnectionName);
            NetworkConnectionResource networkConnection = client.GetNetworkConnectionResource(networkConnectionResourceId);

            // invoke the operation
            NetworkConnectionPatch patch = new NetworkConnectionPatch()
            {
                DomainPassword = "New Password value for user",
            };
            ArmOperation<NetworkConnectionResource> lro = await networkConnection.UpdateAsync(WaitUntil.Completed, patch);
            NetworkConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // NetworkConnections_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_NetworkConnectionsDelete()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/preview/2022-08-01-preview/examples/NetworkConnections_Delete.json
            // this example is just showing the usage of "NetworkConnections_Delete" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this NetworkConnectionResource created on azure
            // for more information of creating NetworkConnectionResource, please refer to the document of NetworkConnectionResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "rg1";
            string networkConnectionName = "{networkConnectionName}";
            ResourceIdentifier networkConnectionResourceId = NetworkConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkConnectionName);
            NetworkConnectionResource networkConnection = client.GetNetworkConnectionResource(networkConnectionResourceId);

            // invoke the operation
            await networkConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // NetworkConnections_RunHealthChecks
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RunHealthChecks_NetworkConnectionsRunHealthChecks()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/preview/2022-08-01-preview/examples/NetworkConnections_RunHealthChecks.json
            // this example is just showing the usage of "NetworkConnections_RunHealthChecks" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this NetworkConnectionResource created on azure
            // for more information of creating NetworkConnectionResource, please refer to the document of NetworkConnectionResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "rg1";
            string networkConnectionName = "uswest3network";
            ResourceIdentifier networkConnectionResourceId = NetworkConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkConnectionName);
            NetworkConnectionResource networkConnection = client.GetNetworkConnectionResource(networkConnectionResourceId);

            // invoke the operation
            await networkConnection.RunHealthChecksAsync();

            Console.WriteLine($"Succeeded");
        }
    }
}

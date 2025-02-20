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

namespace Azure.ResourceManager.DevCenter
{
    public partial class Sample_DevBoxDefinitionCollection
    {
        // DevBoxDefinitions_ListByDevCenter
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_DevBoxDefinitionsListByDevCenter()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/preview/2022-08-01-preview/examples/DevBoxDefinitions_ListByDevCenter.json
            // this example is just showing the usage of "DevBoxDefinitions_ListByDevCenter" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this DevCenterResource created on azure
            // for more information of creating DevCenterResource, please refer to the document of DevCenterResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "rg1";
            string devCenterName = "Contoso";
            ResourceIdentifier devCenterResourceId = DevCenterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, devCenterName);
            DevCenterResource devCenter = client.GetDevCenterResource(devCenterResourceId);

            // get the collection of this DevBoxDefinitionResource
            DevBoxDefinitionCollection collection = devCenter.GetDevBoxDefinitions();

            // invoke the operation and iterate over the result
            await foreach (DevBoxDefinitionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DevBoxDefinitionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // DevBoxDefinitions_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_DevBoxDefinitionsGet()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/preview/2022-08-01-preview/examples/DevBoxDefinitions_Get.json
            // this example is just showing the usage of "DevBoxDefinitions_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this DevCenterResource created on azure
            // for more information of creating DevCenterResource, please refer to the document of DevCenterResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "rg1";
            string devCenterName = "Contoso";
            ResourceIdentifier devCenterResourceId = DevCenterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, devCenterName);
            DevCenterResource devCenter = client.GetDevCenterResource(devCenterResourceId);

            // get the collection of this DevBoxDefinitionResource
            DevBoxDefinitionCollection collection = devCenter.GetDevBoxDefinitions();

            // invoke the operation
            string devBoxDefinitionName = "WebDevBox";
            DevBoxDefinitionResource result = await collection.GetAsync(devBoxDefinitionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevBoxDefinitionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DevBoxDefinitions_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_DevBoxDefinitionsGet()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/preview/2022-08-01-preview/examples/DevBoxDefinitions_Get.json
            // this example is just showing the usage of "DevBoxDefinitions_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this DevCenterResource created on azure
            // for more information of creating DevCenterResource, please refer to the document of DevCenterResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "rg1";
            string devCenterName = "Contoso";
            ResourceIdentifier devCenterResourceId = DevCenterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, devCenterName);
            DevCenterResource devCenter = client.GetDevCenterResource(devCenterResourceId);

            // get the collection of this DevBoxDefinitionResource
            DevBoxDefinitionCollection collection = devCenter.GetDevBoxDefinitions();

            // invoke the operation
            string devBoxDefinitionName = "WebDevBox";
            bool result = await collection.ExistsAsync(devBoxDefinitionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // DevBoxDefinitions_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_DevBoxDefinitionsCreate()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/preview/2022-08-01-preview/examples/DevBoxDefinitions_Create.json
            // this example is just showing the usage of "DevBoxDefinitions_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this DevCenterResource created on azure
            // for more information of creating DevCenterResource, please refer to the document of DevCenterResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "rg1";
            string devCenterName = "Contoso";
            ResourceIdentifier devCenterResourceId = DevCenterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, devCenterName);
            DevCenterResource devCenter = client.GetDevCenterResource(devCenterResourceId);

            // get the collection of this DevBoxDefinitionResource
            DevBoxDefinitionCollection collection = devCenter.GetDevBoxDefinitions();

            // invoke the operation
            string devBoxDefinitionName = "WebDevBox";
            DevBoxDefinitionData data = new DevBoxDefinitionData(new AzureLocation("centralus"))
            {
                ImageReference = new ImageReference()
                {
                    Id = "/subscriptions/0ac520ee-14c0-480f-b6c9-0a90c58ffff/resourceGroups/Example/providers/Microsoft.DevCenter/devcenters/Contoso/galleries/contosogallery/images/exampleImage/version/1.0.0",
                },
                Sku = new DevCenterSku("Preview"),
                OSStorageType = "SSD_1024",
            };
            ArmOperation<DevBoxDefinitionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, devBoxDefinitionName, data);
            DevBoxDefinitionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevBoxDefinitionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

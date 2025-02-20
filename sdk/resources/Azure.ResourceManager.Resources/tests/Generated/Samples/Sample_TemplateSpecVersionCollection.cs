// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Resources
{
    public partial class Sample_TemplateSpecVersionCollection
    {
        // TemplateSpecVersionsCreateUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_TemplateSpecVersionsCreateUpdate()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Resources/stable/2021-05-01/examples/TemplateSpecVersionsCreate.json
            // this example is just showing the usage of "TemplateSpecVersions_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this TemplateSpecResource created on azure
            // for more information of creating TemplateSpecResource, please refer to the document of TemplateSpecResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "templateSpecRG";
            string templateSpecName = "simpleTemplateSpec";
            ResourceIdentifier templateSpecResourceId = TemplateSpecResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, templateSpecName);
            TemplateSpecResource templateSpec = client.GetTemplateSpecResource(templateSpecResourceId);

            // get the collection of this TemplateSpecVersionResource
            TemplateSpecVersionCollection collection = templateSpec.GetTemplateSpecVersions();

            // invoke the operation
            string templateSpecVersion = "v1.0";
            TemplateSpecVersionData data = new TemplateSpecVersionData(new AzureLocation("eastus"))
            {
                Description = "This is version v1.0 of our template content",
                MainTemplate = BinaryData.FromObjectAsJson(new Dictionary<string, object>()
                {
                    ["$schema"] = "http://schema.management.azure.com/schemas/2015-01-01/deploymentTemplate.json#",
                    ["contentVersion"] = "1.0.0.0",
                    ["parameters"] = new Dictionary<string, object>()
                    {
                    },
                    ["resources"] = new object[] { }
                }),
            };
            ArmOperation<TemplateSpecVersionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, templateSpecVersion, data);
            TemplateSpecVersionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TemplateSpecVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // TemplateSpecVersionsGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_TemplateSpecVersionsGet()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Resources/stable/2021-05-01/examples/TemplateSpecVersionsGet.json
            // this example is just showing the usage of "TemplateSpecVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this TemplateSpecResource created on azure
            // for more information of creating TemplateSpecResource, please refer to the document of TemplateSpecResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "templateSpecRG";
            string templateSpecName = "simpleTemplateSpec";
            ResourceIdentifier templateSpecResourceId = TemplateSpecResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, templateSpecName);
            TemplateSpecResource templateSpec = client.GetTemplateSpecResource(templateSpecResourceId);

            // get the collection of this TemplateSpecVersionResource
            TemplateSpecVersionCollection collection = templateSpec.GetTemplateSpecVersions();

            // invoke the operation
            string templateSpecVersion = "v1.0";
            TemplateSpecVersionResource result = await collection.GetAsync(templateSpecVersion);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TemplateSpecVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // TemplateSpecVersionsGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_TemplateSpecVersionsGet()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Resources/stable/2021-05-01/examples/TemplateSpecVersionsGet.json
            // this example is just showing the usage of "TemplateSpecVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this TemplateSpecResource created on azure
            // for more information of creating TemplateSpecResource, please refer to the document of TemplateSpecResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "templateSpecRG";
            string templateSpecName = "simpleTemplateSpec";
            ResourceIdentifier templateSpecResourceId = TemplateSpecResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, templateSpecName);
            TemplateSpecResource templateSpec = client.GetTemplateSpecResource(templateSpecResourceId);

            // get the collection of this TemplateSpecVersionResource
            TemplateSpecVersionCollection collection = templateSpec.GetTemplateSpecVersions();

            // invoke the operation
            string templateSpecVersion = "v1.0";
            bool result = await collection.ExistsAsync(templateSpecVersion);

            Console.WriteLine($"Succeeded: {result}");
        }

        // TemplateSpecVersions_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_TemplateSpecVersionsList()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Resources/stable/2021-05-01/examples/TemplateSpecVersionsList.json
            // this example is just showing the usage of "TemplateSpecVersions_List" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this TemplateSpecResource created on azure
            // for more information of creating TemplateSpecResource, please refer to the document of TemplateSpecResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "templateSpecRG";
            string templateSpecName = "simpleTemplateSpec";
            ResourceIdentifier templateSpecResourceId = TemplateSpecResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, templateSpecName);
            TemplateSpecResource templateSpec = client.GetTemplateSpecResource(templateSpecResourceId);

            // get the collection of this TemplateSpecVersionResource
            TemplateSpecVersionCollection collection = templateSpec.GetTemplateSpecVersions();

            // invoke the operation and iterate over the result
            await foreach (TemplateSpecVersionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                TemplateSpecVersionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}

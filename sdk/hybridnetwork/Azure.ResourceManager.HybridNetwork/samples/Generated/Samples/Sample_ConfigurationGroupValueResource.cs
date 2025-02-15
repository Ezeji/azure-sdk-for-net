// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.HybridNetwork.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.HybridNetwork.Samples
{
    public partial class Sample_ConfigurationGroupValueResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteHybridConfigurationGroupResource()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/ConfigurationGroupValueDelete.json
            // this example is just showing the usage of "ConfigurationGroupValues_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ConfigurationGroupValueResource created on azure
            // for more information of creating ConfigurationGroupValueResource, please refer to the document of ConfigurationGroupValueResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string configurationGroupValueName = "testConfigurationGroupValue";
            ResourceIdentifier configurationGroupValueResourceId = ConfigurationGroupValueResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, configurationGroupValueName);
            ConfigurationGroupValueResource configurationGroupValue = client.GetConfigurationGroupValueResource(configurationGroupValueResourceId);

            // invoke the operation
            await configurationGroupValue.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetHybridConfigurationGroup()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/ConfigurationGroupValueGet.json
            // this example is just showing the usage of "ConfigurationGroupValues_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ConfigurationGroupValueResource created on azure
            // for more information of creating ConfigurationGroupValueResource, please refer to the document of ConfigurationGroupValueResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string configurationGroupValueName = "testConfigurationGroupValue";
            ResourceIdentifier configurationGroupValueResourceId = ConfigurationGroupValueResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, configurationGroupValueName);
            ConfigurationGroupValueResource configurationGroupValue = client.GetConfigurationGroupValueResource(configurationGroupValueResourceId);

            // invoke the operation
            ConfigurationGroupValueResource result = await configurationGroupValue.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ConfigurationGroupValueData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateHybridConfigurationGroupTags()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/ConfigurationGroupValueUpdateTags.json
            // this example is just showing the usage of "ConfigurationGroupValues_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ConfigurationGroupValueResource created on azure
            // for more information of creating ConfigurationGroupValueResource, please refer to the document of ConfigurationGroupValueResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string configurationGroupValueName = "testConfigurationGroupValue";
            ResourceIdentifier configurationGroupValueResourceId = ConfigurationGroupValueResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, configurationGroupValueName);
            ConfigurationGroupValueResource configurationGroupValue = client.GetConfigurationGroupValueResource(configurationGroupValueResourceId);

            // invoke the operation
            TagsObject tagsObject = new TagsObject()
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            };
            ConfigurationGroupValueResource result = await configurationGroupValue.UpdateAsync(tagsObject);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ConfigurationGroupValueData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetConfigurationGroupValues_ListAllHybridNetworkSitesInASubscription()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/ConfigurationGroupValueListBySubscription.json
            // this example is just showing the usage of "ConfigurationGroupValues_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (ConfigurationGroupValueResource item in subscriptionResource.GetConfigurationGroupValuesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ConfigurationGroupValueData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}

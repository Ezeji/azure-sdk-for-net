// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.HybridConnectivity.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.HybridConnectivity.Samples
{
    public partial class Sample_HybridConnectivityPublicCloudConnectorResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetHybridConnectivityPublicCloudConnectors_PublicCloudConnectorsListBySubscription()
        {
            // Generated from example definition: specification/hybridconnectivity/resource-manager/Microsoft.HybridConnectivity/PublicCloud/stable/2024-12-01/examples/PublicCloudConnectors_ListBySubscription.json
            // this example is just showing the usage of "PublicCloudConnectors_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "5ACC4579-DB34-4C2F-8F8C-25061168F342";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (HybridConnectivityPublicCloudConnectorResource item in subscriptionResource.GetHybridConnectivityPublicCloudConnectorsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HybridConnectivityPublicCloudConnectorData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_PublicCloudConnectorsGet()
        {
            // Generated from example definition: specification/hybridconnectivity/resource-manager/Microsoft.HybridConnectivity/PublicCloud/stable/2024-12-01/examples/PublicCloudConnectors_Get.json
            // this example is just showing the usage of "PublicCloudConnectors_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HybridConnectivityPublicCloudConnectorResource created on azure
            // for more information of creating HybridConnectivityPublicCloudConnectorResource, please refer to the document of HybridConnectivityPublicCloudConnectorResource
            string subscriptionId = "5ACC4579-DB34-4C2F-8F8C-25061168F342";
            string resourceGroupName = "rgpublicCloud";
            string publicCloudConnector = "rzygvnpsnrdylwzdbsscjazvamyxmh";
            ResourceIdentifier hybridConnectivityPublicCloudConnectorResourceId = HybridConnectivityPublicCloudConnectorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publicCloudConnector);
            HybridConnectivityPublicCloudConnectorResource hybridConnectivityPublicCloudConnector = client.GetHybridConnectivityPublicCloudConnectorResource(hybridConnectivityPublicCloudConnectorResourceId);

            // invoke the operation
            HybridConnectivityPublicCloudConnectorResource result = await hybridConnectivityPublicCloudConnector.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HybridConnectivityPublicCloudConnectorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_PublicCloudConnectorsUpdate()
        {
            // Generated from example definition: specification/hybridconnectivity/resource-manager/Microsoft.HybridConnectivity/PublicCloud/stable/2024-12-01/examples/PublicCloudConnectors_Update.json
            // this example is just showing the usage of "PublicCloudConnectors_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HybridConnectivityPublicCloudConnectorResource created on azure
            // for more information of creating HybridConnectivityPublicCloudConnectorResource, please refer to the document of HybridConnectivityPublicCloudConnectorResource
            string subscriptionId = "5ACC4579-DB34-4C2F-8F8C-25061168F342";
            string resourceGroupName = "rgpublicCloud";
            string publicCloudConnector = "svtirlbyqpepbzyessjenlueeznhg";
            ResourceIdentifier hybridConnectivityPublicCloudConnectorResourceId = HybridConnectivityPublicCloudConnectorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publicCloudConnector);
            HybridConnectivityPublicCloudConnectorResource hybridConnectivityPublicCloudConnector = client.GetHybridConnectivityPublicCloudConnectorResource(hybridConnectivityPublicCloudConnectorResourceId);

            // invoke the operation
            HybridConnectivityPublicCloudConnectorPatch patch = new HybridConnectivityPublicCloudConnectorPatch()
            {
                AwsCloudExcludedAccounts =
{
"zrbtd"
},
                Tags =
{
},
            };
            HybridConnectivityPublicCloudConnectorResource result = await hybridConnectivityPublicCloudConnector.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HybridConnectivityPublicCloudConnectorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_PublicCloudConnectorsDelete()
        {
            // Generated from example definition: specification/hybridconnectivity/resource-manager/Microsoft.HybridConnectivity/PublicCloud/stable/2024-12-01/examples/PublicCloudConnectors_Delete.json
            // this example is just showing the usage of "PublicCloudConnectors_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HybridConnectivityPublicCloudConnectorResource created on azure
            // for more information of creating HybridConnectivityPublicCloudConnectorResource, please refer to the document of HybridConnectivityPublicCloudConnectorResource
            string subscriptionId = "5ACC4579-DB34-4C2F-8F8C-25061168F342";
            string resourceGroupName = "rgpublicCloud";
            string publicCloudConnector = "skcfyjvflkhibdywjay";
            ResourceIdentifier hybridConnectivityPublicCloudConnectorResourceId = HybridConnectivityPublicCloudConnectorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publicCloudConnector);
            HybridConnectivityPublicCloudConnectorResource hybridConnectivityPublicCloudConnector = client.GetHybridConnectivityPublicCloudConnectorResource(hybridConnectivityPublicCloudConnectorResourceId);

            // invoke the operation
            await hybridConnectivityPublicCloudConnector.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task TestPermissions_PublicCloudConnectorsTestPermissions()
        {
            // Generated from example definition: specification/hybridconnectivity/resource-manager/Microsoft.HybridConnectivity/PublicCloud/stable/2024-12-01/examples/PublicCloudConnectors_TestPermissions.json
            // this example is just showing the usage of "PublicCloudConnectors_TestPermissions" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HybridConnectivityPublicCloudConnectorResource created on azure
            // for more information of creating HybridConnectivityPublicCloudConnectorResource, please refer to the document of HybridConnectivityPublicCloudConnectorResource
            string subscriptionId = "5ACC4579-DB34-4C2F-8F8C-25061168F342";
            string resourceGroupName = "rgpublicCloud";
            string publicCloudConnector = "rzygvnpsnrdylwzdbsscjazvamyxmh";
            ResourceIdentifier hybridConnectivityPublicCloudConnectorResourceId = HybridConnectivityPublicCloudConnectorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publicCloudConnector);
            HybridConnectivityPublicCloudConnectorResource hybridConnectivityPublicCloudConnector = client.GetHybridConnectivityPublicCloudConnectorResource(hybridConnectivityPublicCloudConnectorResourceId);

            // invoke the operation
            ArmOperation<HybridConnectivityOperationStatusResult> lro = await hybridConnectivityPublicCloudConnector.TestPermissionsAsync(WaitUntil.Completed);
            HybridConnectivityOperationStatusResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}

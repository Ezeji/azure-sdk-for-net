// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.HybridConnectivity
{
    /// <summary>
    /// A class representing a collection of <see cref="HybridConnectivitySolutionConfigurationResource"/> and their operations.
    /// Each <see cref="HybridConnectivitySolutionConfigurationResource"/> in the collection will belong to the same instance of <see cref="ArmResource"/>.
    /// To get a <see cref="HybridConnectivitySolutionConfigurationCollection"/> instance call the GetHybridConnectivitySolutionConfigurations method from an instance of <see cref="ArmResource"/>.
    /// </summary>
    public partial class HybridConnectivitySolutionConfigurationCollection : ArmCollection, IEnumerable<HybridConnectivitySolutionConfigurationResource>, IAsyncEnumerable<HybridConnectivitySolutionConfigurationResource>
    {
        private readonly ClientDiagnostics _hybridConnectivitySolutionConfigurationSolutionConfigurationsClientDiagnostics;
        private readonly SolutionConfigurationsRestOperations _hybridConnectivitySolutionConfigurationSolutionConfigurationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="HybridConnectivitySolutionConfigurationCollection"/> class for mocking. </summary>
        protected HybridConnectivitySolutionConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HybridConnectivitySolutionConfigurationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal HybridConnectivitySolutionConfigurationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hybridConnectivitySolutionConfigurationSolutionConfigurationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HybridConnectivity", HybridConnectivitySolutionConfigurationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(HybridConnectivitySolutionConfigurationResource.ResourceType, out string hybridConnectivitySolutionConfigurationSolutionConfigurationsApiVersion);
            _hybridConnectivitySolutionConfigurationSolutionConfigurationsRestClient = new SolutionConfigurationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hybridConnectivitySolutionConfigurationSolutionConfigurationsApiVersion);
        }

        /// <summary>
        /// Create a SolutionConfiguration
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/solutionConfigurations/{solutionConfiguration}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SolutionConfigurations_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridConnectivitySolutionConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="solutionConfiguration"> Represent Solution Configuration Resource. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="solutionConfiguration"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="solutionConfiguration"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<HybridConnectivitySolutionConfigurationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string solutionConfiguration, HybridConnectivitySolutionConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(solutionConfiguration, nameof(solutionConfiguration));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hybridConnectivitySolutionConfigurationSolutionConfigurationsClientDiagnostics.CreateScope("HybridConnectivitySolutionConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _hybridConnectivitySolutionConfigurationSolutionConfigurationsRestClient.CreateOrUpdateAsync(Id, solutionConfiguration, data, cancellationToken).ConfigureAwait(false);
                var uri = _hybridConnectivitySolutionConfigurationSolutionConfigurationsRestClient.CreateCreateOrUpdateRequestUri(Id, solutionConfiguration, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new HybridConnectivityArmOperation<HybridConnectivitySolutionConfigurationResource>(Response.FromValue(new HybridConnectivitySolutionConfigurationResource(Client, response), response.GetRawResponse()), rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a SolutionConfiguration
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/solutionConfigurations/{solutionConfiguration}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SolutionConfigurations_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridConnectivitySolutionConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="solutionConfiguration"> Represent Solution Configuration Resource. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="solutionConfiguration"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="solutionConfiguration"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<HybridConnectivitySolutionConfigurationResource> CreateOrUpdate(WaitUntil waitUntil, string solutionConfiguration, HybridConnectivitySolutionConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(solutionConfiguration, nameof(solutionConfiguration));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hybridConnectivitySolutionConfigurationSolutionConfigurationsClientDiagnostics.CreateScope("HybridConnectivitySolutionConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _hybridConnectivitySolutionConfigurationSolutionConfigurationsRestClient.CreateOrUpdate(Id, solutionConfiguration, data, cancellationToken);
                var uri = _hybridConnectivitySolutionConfigurationSolutionConfigurationsRestClient.CreateCreateOrUpdateRequestUri(Id, solutionConfiguration, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new HybridConnectivityArmOperation<HybridConnectivitySolutionConfigurationResource>(Response.FromValue(new HybridConnectivitySolutionConfigurationResource(Client, response), response.GetRawResponse()), rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a SolutionConfiguration
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/solutionConfigurations/{solutionConfiguration}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SolutionConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridConnectivitySolutionConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="solutionConfiguration"> Represent Solution Configuration Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="solutionConfiguration"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="solutionConfiguration"/> is null. </exception>
        public virtual async Task<Response<HybridConnectivitySolutionConfigurationResource>> GetAsync(string solutionConfiguration, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(solutionConfiguration, nameof(solutionConfiguration));

            using var scope = _hybridConnectivitySolutionConfigurationSolutionConfigurationsClientDiagnostics.CreateScope("HybridConnectivitySolutionConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = await _hybridConnectivitySolutionConfigurationSolutionConfigurationsRestClient.GetAsync(Id, solutionConfiguration, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridConnectivitySolutionConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a SolutionConfiguration
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/solutionConfigurations/{solutionConfiguration}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SolutionConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridConnectivitySolutionConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="solutionConfiguration"> Represent Solution Configuration Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="solutionConfiguration"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="solutionConfiguration"/> is null. </exception>
        public virtual Response<HybridConnectivitySolutionConfigurationResource> Get(string solutionConfiguration, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(solutionConfiguration, nameof(solutionConfiguration));

            using var scope = _hybridConnectivitySolutionConfigurationSolutionConfigurationsClientDiagnostics.CreateScope("HybridConnectivitySolutionConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = _hybridConnectivitySolutionConfigurationSolutionConfigurationsRestClient.Get(Id, solutionConfiguration, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridConnectivitySolutionConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List SolutionConfiguration resources by parent
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/solutionConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SolutionConfigurations_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridConnectivitySolutionConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HybridConnectivitySolutionConfigurationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HybridConnectivitySolutionConfigurationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hybridConnectivitySolutionConfigurationSolutionConfigurationsRestClient.CreateListRequest(Id);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hybridConnectivitySolutionConfigurationSolutionConfigurationsRestClient.CreateListNextPageRequest(nextLink, Id);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new HybridConnectivitySolutionConfigurationResource(Client, HybridConnectivitySolutionConfigurationData.DeserializeHybridConnectivitySolutionConfigurationData(e)), _hybridConnectivitySolutionConfigurationSolutionConfigurationsClientDiagnostics, Pipeline, "HybridConnectivitySolutionConfigurationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List SolutionConfiguration resources by parent
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/solutionConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SolutionConfigurations_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridConnectivitySolutionConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HybridConnectivitySolutionConfigurationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HybridConnectivitySolutionConfigurationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hybridConnectivitySolutionConfigurationSolutionConfigurationsRestClient.CreateListRequest(Id);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hybridConnectivitySolutionConfigurationSolutionConfigurationsRestClient.CreateListNextPageRequest(nextLink, Id);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new HybridConnectivitySolutionConfigurationResource(Client, HybridConnectivitySolutionConfigurationData.DeserializeHybridConnectivitySolutionConfigurationData(e)), _hybridConnectivitySolutionConfigurationSolutionConfigurationsClientDiagnostics, Pipeline, "HybridConnectivitySolutionConfigurationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/solutionConfigurations/{solutionConfiguration}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SolutionConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridConnectivitySolutionConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="solutionConfiguration"> Represent Solution Configuration Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="solutionConfiguration"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="solutionConfiguration"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string solutionConfiguration, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(solutionConfiguration, nameof(solutionConfiguration));

            using var scope = _hybridConnectivitySolutionConfigurationSolutionConfigurationsClientDiagnostics.CreateScope("HybridConnectivitySolutionConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _hybridConnectivitySolutionConfigurationSolutionConfigurationsRestClient.GetAsync(Id, solutionConfiguration, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/solutionConfigurations/{solutionConfiguration}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SolutionConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridConnectivitySolutionConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="solutionConfiguration"> Represent Solution Configuration Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="solutionConfiguration"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="solutionConfiguration"/> is null. </exception>
        public virtual Response<bool> Exists(string solutionConfiguration, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(solutionConfiguration, nameof(solutionConfiguration));

            using var scope = _hybridConnectivitySolutionConfigurationSolutionConfigurationsClientDiagnostics.CreateScope("HybridConnectivitySolutionConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = _hybridConnectivitySolutionConfigurationSolutionConfigurationsRestClient.Get(Id, solutionConfiguration, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/solutionConfigurations/{solutionConfiguration}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SolutionConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridConnectivitySolutionConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="solutionConfiguration"> Represent Solution Configuration Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="solutionConfiguration"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="solutionConfiguration"/> is null. </exception>
        public virtual async Task<NullableResponse<HybridConnectivitySolutionConfigurationResource>> GetIfExistsAsync(string solutionConfiguration, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(solutionConfiguration, nameof(solutionConfiguration));

            using var scope = _hybridConnectivitySolutionConfigurationSolutionConfigurationsClientDiagnostics.CreateScope("HybridConnectivitySolutionConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _hybridConnectivitySolutionConfigurationSolutionConfigurationsRestClient.GetAsync(Id, solutionConfiguration, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<HybridConnectivitySolutionConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new HybridConnectivitySolutionConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/solutionConfigurations/{solutionConfiguration}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SolutionConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridConnectivitySolutionConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="solutionConfiguration"> Represent Solution Configuration Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="solutionConfiguration"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="solutionConfiguration"/> is null. </exception>
        public virtual NullableResponse<HybridConnectivitySolutionConfigurationResource> GetIfExists(string solutionConfiguration, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(solutionConfiguration, nameof(solutionConfiguration));

            using var scope = _hybridConnectivitySolutionConfigurationSolutionConfigurationsClientDiagnostics.CreateScope("HybridConnectivitySolutionConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _hybridConnectivitySolutionConfigurationSolutionConfigurationsRestClient.Get(Id, solutionConfiguration, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<HybridConnectivitySolutionConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new HybridConnectivitySolutionConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<HybridConnectivitySolutionConfigurationResource> IEnumerable<HybridConnectivitySolutionConfigurationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HybridConnectivitySolutionConfigurationResource> IAsyncEnumerable<HybridConnectivitySolutionConfigurationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}

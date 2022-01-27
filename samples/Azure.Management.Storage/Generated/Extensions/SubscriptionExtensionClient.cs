// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Storage.Models;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.Management.Storage
{
    /// <summary> An internal class to add extension methods to. </summary>
    internal partial class SubscriptionExtensionClient : ArmResource
    {
        private ClientDiagnostics _skusClientDiagnostics;
        private SkusRestOperations _skusRestClient;
        private ClientDiagnostics _storageAccountClientDiagnostics;
        private StorageAccountsRestOperations _storageAccountRestClient;
        private ClientDiagnostics _usagesClientDiagnostics;
        private UsagesRestOperations _usagesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionExtensionClient"/> class for mocking. </summary>
        protected SubscriptionExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionExtensionClient"/> class. </summary>
        /// <param name="armClient"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionExtensionClient(ArmClient armClient, ResourceIdentifier id) : base(armClient, id)
        {
        }

        private ClientDiagnostics SkusClientDiagnostics => _skusClientDiagnostics ??= new ClientDiagnostics("Azure.Management.Storage", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
        private SkusRestOperations SkusRestClient => _skusRestClient ??= new SkusRestOperations(SkusClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri);
        private ClientDiagnostics StorageAccountClientDiagnostics => _storageAccountClientDiagnostics ??= new ClientDiagnostics("Azure.Management.Storage", StorageAccount.ResourceType.Namespace, DiagnosticOptions);
        private StorageAccountsRestOperations StorageAccountRestClient => _storageAccountRestClient ??= new StorageAccountsRestOperations(StorageAccountClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, GetApiVersionOrNull(StorageAccount.ResourceType));
        private ClientDiagnostics UsagesClientDiagnostics => _usagesClientDiagnostics ??= new ClientDiagnostics("Azure.Management.Storage", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
        private UsagesRestOperations UsagesRestClient => _usagesRestClient ??= new UsagesRestOperations(UsagesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            ArmClient.TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/skus
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: Skus_List
        /// <summary> Lists the available SKUs supported by Microsoft.Storage for given subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SkuInformation" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SkuInformation> GetSkusAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SkuInformation>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = SkusClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetSkus");
                scope.Start();
                try
                {
                    var response = await SkusRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/skus
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: Skus_List
        /// <summary> Lists the available SKUs supported by Microsoft.Storage for given subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SkuInformation" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SkuInformation> GetSkus(CancellationToken cancellationToken = default)
        {
            Page<SkuInformation> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = SkusClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetSkus");
                scope.Start();
                try
                {
                    var response = SkusRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/storageAccounts
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: StorageAccounts_List
        /// <summary> Lists all the storage accounts available under the subscription. Note that storage keys are not returned; use the ListKeys operation for this. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageAccount" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StorageAccount> GetStorageAccountsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<StorageAccount>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = StorageAccountClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetStorageAccounts");
                scope.Start();
                try
                {
                    var response = await StorageAccountRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new StorageAccount(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<StorageAccount>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = StorageAccountClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetStorageAccounts");
                scope.Start();
                try
                {
                    var response = await StorageAccountRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new StorageAccount(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/storageAccounts
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: StorageAccounts_List
        /// <summary> Lists all the storage accounts available under the subscription. Note that storage keys are not returned; use the ListKeys operation for this. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageAccount" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StorageAccount> GetStorageAccounts(CancellationToken cancellationToken = default)
        {
            Page<StorageAccount> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = StorageAccountClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetStorageAccounts");
                scope.Start();
                try
                {
                    var response = StorageAccountRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new StorageAccount(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<StorageAccount> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = StorageAccountClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetStorageAccounts");
                scope.Start();
                try
                {
                    var response = StorageAccountRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new StorageAccount(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of StorageAccounts for a <see cref="Subscription" /> represented as generic resources. </summary>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResource> GetStorageAccountsAsGenericResourcesAsync(string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(StorageAccount.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.GetAtContextAsync(ArmClient.GetSubscription(Id), filters, expand, top, cancellationToken);
        }

        /// <summary> Filters the list of StorageAccounts for a <see cref="Subscription" /> represented as generic resources. </summary>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResource> GetStorageAccountsAsGenericResources(string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(StorageAccount.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.GetAtContext(ArmClient.GetSubscription(Id), filters, expand, top, cancellationToken);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/locations/{location}/usages
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: Usages_ListByLocation
        /// <summary> Gets the current usage count and the limit for the resources of the location under the subscription. </summary>
        /// <param name="location"> The location of the Azure Storage resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        /// <returns> An async collection of <see cref="Usage" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Usage> GetUsagesByLocationAsync(string location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            async Task<Page<Usage>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = UsagesClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetUsagesByLocation");
                scope.Start();
                try
                {
                    var response = await UsagesRestClient.ListByLocationAsync(Id.SubscriptionId, location, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/locations/{location}/usages
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: Usages_ListByLocation
        /// <summary> Gets the current usage count and the limit for the resources of the location under the subscription. </summary>
        /// <param name="location"> The location of the Azure Storage resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        /// <returns> A collection of <see cref="Usage" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Usage> GetUsagesByLocation(string location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            Page<Usage> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = UsagesClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetUsagesByLocation");
                scope.Start();
                try
                {
                    var response = UsagesRestClient.ListByLocation(Id.SubscriptionId, location, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }
    }
}

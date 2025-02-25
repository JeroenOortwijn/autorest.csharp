// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using MgmtHierarchicalNonResource.Models;

namespace MgmtHierarchicalNonResource
{
    /// <summary>
    /// A class representing a collection of <see cref="SharedGalleryResource" /> and their operations.
    /// Each <see cref="SharedGalleryResource" /> in the collection will belong to the same instance of <see cref="SubscriptionResource" />.
    /// To get a <see cref="SharedGalleryCollection" /> instance call the GetSharedGalleries method from an instance of <see cref="SubscriptionResource" />.
    /// </summary>
    public partial class SharedGalleryCollection : ArmCollection, IEnumerable<SharedGalleryResource>, IAsyncEnumerable<SharedGalleryResource>
    {
        private readonly ClientDiagnostics _sharedGalleryClientDiagnostics;
        private readonly SharedGalleriesRestOperations _sharedGalleryRestClient;
        private readonly string _location;

        /// <summary> Initializes a new instance of the <see cref="SharedGalleryCollection"/> class for mocking. </summary>
        protected SharedGalleryCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SharedGalleryCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="location"> Resource location. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        internal SharedGalleryCollection(ArmClient client, ResourceIdentifier id, string location) : base(client, id)
        {
            _location = location;
            _sharedGalleryClientDiagnostics = new ClientDiagnostics("MgmtHierarchicalNonResource", SharedGalleryResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SharedGalleryResource.ResourceType, out string sharedGalleryApiVersion);
            _sharedGalleryRestClient = new SharedGalleriesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sharedGalleryApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a shared gallery by subscription id or tenant id.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}
        /// Operation Id: SharedGalleries_Get
        /// </summary>
        /// <param name="galleryUniqueName"> The unique name of the Shared Gallery. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryUniqueName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryUniqueName"/> is null. </exception>
        public virtual async Task<Response<SharedGalleryResource>> GetAsync(string galleryUniqueName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryUniqueName, nameof(galleryUniqueName));

            using var scope = _sharedGalleryClientDiagnostics.CreateScope("SharedGalleryCollection.Get");
            scope.Start();
            try
            {
                var response = await _sharedGalleryRestClient.GetAsync(Id.SubscriptionId, _location, galleryUniqueName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                response.Value.Id = SharedGalleryResource.CreateResourceIdentifier(Id.SubscriptionId, _location, galleryUniqueName);
                return Response.FromValue(new SharedGalleryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a shared gallery by subscription id or tenant id.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}
        /// Operation Id: SharedGalleries_Get
        /// </summary>
        /// <param name="galleryUniqueName"> The unique name of the Shared Gallery. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryUniqueName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryUniqueName"/> is null. </exception>
        public virtual Response<SharedGalleryResource> Get(string galleryUniqueName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryUniqueName, nameof(galleryUniqueName));

            using var scope = _sharedGalleryClientDiagnostics.CreateScope("SharedGalleryCollection.Get");
            scope.Start();
            try
            {
                var response = _sharedGalleryRestClient.Get(Id.SubscriptionId, _location, galleryUniqueName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                response.Value.Id = SharedGalleryResource.CreateResourceIdentifier(Id.SubscriptionId, _location, galleryUniqueName);
                return Response.FromValue(new SharedGalleryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List shared galleries by subscription id or tenant id.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries
        /// Operation Id: SharedGalleries_List
        /// </summary>
        /// <param name="sharedTo"> The query parameter to decide what shared galleries to fetch when doing listing operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SharedGalleryResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SharedGalleryResource> GetAllAsync(SharedToValue? sharedTo = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<SharedGalleryResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sharedGalleryClientDiagnostics.CreateScope("SharedGalleryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sharedGalleryRestClient.ListAsync(Id.SubscriptionId, _location, sharedTo, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value =>
                    {
                        value.Id = SharedGalleryResource.CreateResourceIdentifier(Id.SubscriptionId, _location, value.Name);
                        return new SharedGalleryResource(Client, value);
                    }
                    ), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SharedGalleryResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sharedGalleryClientDiagnostics.CreateScope("SharedGalleryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sharedGalleryRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, _location, sharedTo, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value =>
                    {
                        value.Id = SharedGalleryResource.CreateResourceIdentifier(Id.SubscriptionId, _location, value.Name);
                        return new SharedGalleryResource(Client, value);
                    }
                    ), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// List shared galleries by subscription id or tenant id.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries
        /// Operation Id: SharedGalleries_List
        /// </summary>
        /// <param name="sharedTo"> The query parameter to decide what shared galleries to fetch when doing listing operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SharedGalleryResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SharedGalleryResource> GetAll(SharedToValue? sharedTo = null, CancellationToken cancellationToken = default)
        {
            Page<SharedGalleryResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sharedGalleryClientDiagnostics.CreateScope("SharedGalleryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sharedGalleryRestClient.List(Id.SubscriptionId, _location, sharedTo, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value =>
                    {
                        value.Id = SharedGalleryResource.CreateResourceIdentifier(Id.SubscriptionId, _location, value.Name);
                        return new SharedGalleryResource(Client, value);
                    }
                    ), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SharedGalleryResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sharedGalleryClientDiagnostics.CreateScope("SharedGalleryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sharedGalleryRestClient.ListNextPage(nextLink, Id.SubscriptionId, _location, sharedTo, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value =>
                    {
                        value.Id = SharedGalleryResource.CreateResourceIdentifier(Id.SubscriptionId, _location, value.Name);
                        return new SharedGalleryResource(Client, value);
                    }
                    ), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}
        /// Operation Id: SharedGalleries_Get
        /// </summary>
        /// <param name="galleryUniqueName"> The unique name of the Shared Gallery. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryUniqueName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryUniqueName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string galleryUniqueName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryUniqueName, nameof(galleryUniqueName));

            using var scope = _sharedGalleryClientDiagnostics.CreateScope("SharedGalleryCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sharedGalleryRestClient.GetAsync(Id.SubscriptionId, _location, galleryUniqueName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}
        /// Operation Id: SharedGalleries_Get
        /// </summary>
        /// <param name="galleryUniqueName"> The unique name of the Shared Gallery. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryUniqueName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryUniqueName"/> is null. </exception>
        public virtual Response<bool> Exists(string galleryUniqueName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryUniqueName, nameof(galleryUniqueName));

            using var scope = _sharedGalleryClientDiagnostics.CreateScope("SharedGalleryCollection.Exists");
            scope.Start();
            try
            {
                var response = _sharedGalleryRestClient.Get(Id.SubscriptionId, _location, galleryUniqueName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SharedGalleryResource> IEnumerable<SharedGalleryResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SharedGalleryResource> IAsyncEnumerable<SharedGalleryResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}

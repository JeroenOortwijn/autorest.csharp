// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using MgmtMockTest.Models;

namespace MgmtMockTest
{
    /// <summary>
    /// A class representing a collection of <see cref="RoleAssignmentResource" /> and their operations.
    /// Each <see cref="RoleAssignmentResource" /> in the collection will belong to the same instance of <see cref="ArmResource" />.
    /// To get a <see cref="RoleAssignmentCollection" /> instance call the GetRoleAssignments method from an instance of <see cref="ArmResource" />.
    /// </summary>
    public partial class RoleAssignmentCollection : ArmCollection, IEnumerable<RoleAssignmentResource>, IAsyncEnumerable<RoleAssignmentResource>
    {
        private readonly ClientDiagnostics _roleAssignmentClientDiagnostics;
        private readonly RoleAssignmentsRestOperations _roleAssignmentRestClient;

        /// <summary> Initializes a new instance of the <see cref="RoleAssignmentCollection"/> class for mocking. </summary>
        protected RoleAssignmentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RoleAssignmentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RoleAssignmentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _roleAssignmentClientDiagnostics = new ClientDiagnostics("MgmtMockTest", RoleAssignmentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RoleAssignmentResource.ResourceType, out string roleAssignmentApiVersion);
            _roleAssignmentRestClient = new RoleAssignmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, roleAssignmentApiVersion);
        }

        /// <summary>
        /// Creates a role assignment.
        /// Request Path: /{scope}/providers/Microsoft.Authorization/roleAssignments/{roleAssignmentName}
        /// Operation Id: RoleAssignments_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="roleAssignmentName"> A GUID for the role assignment to create. The name must be unique and different for each role assignment. </param>
        /// <param name="content"> Parameters for the role assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<RoleAssignmentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string roleAssignmentName, RoleAssignmentCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentName, nameof(roleAssignmentName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _roleAssignmentClientDiagnostics.CreateScope("RoleAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _roleAssignmentRestClient.CreateAsync(Id, roleAssignmentName, content, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtMockTestArmOperation<RoleAssignmentResource>(Response.FromValue(new RoleAssignmentResource(Client, response), response.GetRawResponse()));
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
        /// Creates a role assignment.
        /// Request Path: /{scope}/providers/Microsoft.Authorization/roleAssignments/{roleAssignmentName}
        /// Operation Id: RoleAssignments_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="roleAssignmentName"> A GUID for the role assignment to create. The name must be unique and different for each role assignment. </param>
        /// <param name="content"> Parameters for the role assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<RoleAssignmentResource> CreateOrUpdate(WaitUntil waitUntil, string roleAssignmentName, RoleAssignmentCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentName, nameof(roleAssignmentName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _roleAssignmentClientDiagnostics.CreateScope("RoleAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _roleAssignmentRestClient.Create(Id, roleAssignmentName, content, cancellationToken);
                var operation = new MgmtMockTestArmOperation<RoleAssignmentResource>(Response.FromValue(new RoleAssignmentResource(Client, response), response.GetRawResponse()));
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
        /// Get the specified role assignment.
        /// Request Path: /{scope}/providers/Microsoft.Authorization/roleAssignments/{roleAssignmentName}
        /// Operation Id: RoleAssignments_Get
        /// </summary>
        /// <param name="roleAssignmentName"> The name of the role assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentName"/> is null. </exception>
        public virtual async Task<Response<RoleAssignmentResource>> GetAsync(string roleAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentName, nameof(roleAssignmentName));

            using var scope = _roleAssignmentClientDiagnostics.CreateScope("RoleAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = await _roleAssignmentRestClient.GetAsync(Id, roleAssignmentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified role assignment.
        /// Request Path: /{scope}/providers/Microsoft.Authorization/roleAssignments/{roleAssignmentName}
        /// Operation Id: RoleAssignments_Get
        /// </summary>
        /// <param name="roleAssignmentName"> The name of the role assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentName"/> is null. </exception>
        public virtual Response<RoleAssignmentResource> Get(string roleAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentName, nameof(roleAssignmentName));

            using var scope = _roleAssignmentClientDiagnostics.CreateScope("RoleAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = _roleAssignmentRestClient.Get(Id, roleAssignmentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets role assignments for a resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{parentResourcePath}/{resourceType}/{resourceName}/providers/Microsoft.Authorization/roleAssignments
        /// Operation Id: RoleAssignments_ListForResource
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Authorization/roleAssignments
        /// Operation Id: RoleAssignments_ListForResourceGroup
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/roleAssignments
        /// Operation Id: RoleAssignments_List
        /// Request Path: /{scope}/providers/Microsoft.Authorization/roleAssignments
        /// Operation Id: RoleAssignments_ListForScope
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. Use $filter=atScope() to return all role assignments at or above the scope. Use $filter=principalId eq {id} to return all role assignments at, above or below the scope for the specified principal. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RoleAssignmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RoleAssignmentResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            if (Id.ResourceType == ResourceGroupResource.ResourceType)
            {
                async Task<Page<RoleAssignmentResource>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = _roleAssignmentClientDiagnostics.CreateScope("RoleAssignmentCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = await _roleAssignmentRestClient.ListForResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new RoleAssignmentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                async Task<Page<RoleAssignmentResource>> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = _roleAssignmentClientDiagnostics.CreateScope("RoleAssignmentCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = await _roleAssignmentRestClient.ListForResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new RoleAssignmentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
            }
            else if (Id.ResourceType == SubscriptionResource.ResourceType)
            {
                async Task<Page<RoleAssignmentResource>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = _roleAssignmentClientDiagnostics.CreateScope("RoleAssignmentCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = await _roleAssignmentRestClient.ListAsync(Id.SubscriptionId, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new RoleAssignmentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                async Task<Page<RoleAssignmentResource>> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = _roleAssignmentClientDiagnostics.CreateScope("RoleAssignmentCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = await _roleAssignmentRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new RoleAssignmentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
            }
            else if (Id.ResourceType == "")
            {
                async Task<Page<RoleAssignmentResource>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = _roleAssignmentClientDiagnostics.CreateScope("RoleAssignmentCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = await _roleAssignmentRestClient.ListForScopeAsync(Id, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new RoleAssignmentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                async Task<Page<RoleAssignmentResource>> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = _roleAssignmentClientDiagnostics.CreateScope("RoleAssignmentCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = await _roleAssignmentRestClient.ListForScopeNextPageAsync(nextLink, Id, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new RoleAssignmentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
            }
            else
            {
                async Task<Page<RoleAssignmentResource>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = _roleAssignmentClientDiagnostics.CreateScope("RoleAssignmentCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = await _roleAssignmentRestClient.ListForResourceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.ResourceType.Namespace, Id.Parent.SubstringAfterProviderNamespace(), new ResourceType(Id.ResourceType.GetLastType()), Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new RoleAssignmentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                async Task<Page<RoleAssignmentResource>> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = _roleAssignmentClientDiagnostics.CreateScope("RoleAssignmentCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = await _roleAssignmentRestClient.ListForResourceNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.ResourceType.Namespace, Id.Parent.SubstringAfterProviderNamespace(), new ResourceType(Id.ResourceType.GetLastType()), Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new RoleAssignmentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
            }
        }

        /// <summary>
        /// Gets role assignments for a resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{parentResourcePath}/{resourceType}/{resourceName}/providers/Microsoft.Authorization/roleAssignments
        /// Operation Id: RoleAssignments_ListForResource
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Authorization/roleAssignments
        /// Operation Id: RoleAssignments_ListForResourceGroup
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/roleAssignments
        /// Operation Id: RoleAssignments_List
        /// Request Path: /{scope}/providers/Microsoft.Authorization/roleAssignments
        /// Operation Id: RoleAssignments_ListForScope
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. Use $filter=atScope() to return all role assignments at or above the scope. Use $filter=principalId eq {id} to return all role assignments at, above or below the scope for the specified principal. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RoleAssignmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RoleAssignmentResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            if (Id.ResourceType == ResourceGroupResource.ResourceType)
            {
                Page<RoleAssignmentResource> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = _roleAssignmentClientDiagnostics.CreateScope("RoleAssignmentCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = _roleAssignmentRestClient.ListForResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, filter, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new RoleAssignmentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                Page<RoleAssignmentResource> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = _roleAssignmentClientDiagnostics.CreateScope("RoleAssignmentCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = _roleAssignmentRestClient.ListForResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, filter, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new RoleAssignmentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
            }
            else if (Id.ResourceType == SubscriptionResource.ResourceType)
            {
                Page<RoleAssignmentResource> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = _roleAssignmentClientDiagnostics.CreateScope("RoleAssignmentCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = _roleAssignmentRestClient.List(Id.SubscriptionId, filter, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new RoleAssignmentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                Page<RoleAssignmentResource> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = _roleAssignmentClientDiagnostics.CreateScope("RoleAssignmentCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = _roleAssignmentRestClient.ListNextPage(nextLink, Id.SubscriptionId, filter, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new RoleAssignmentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
            }
            else if (Id.ResourceType == "")
            {
                Page<RoleAssignmentResource> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = _roleAssignmentClientDiagnostics.CreateScope("RoleAssignmentCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = _roleAssignmentRestClient.ListForScope(Id, filter, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new RoleAssignmentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                Page<RoleAssignmentResource> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = _roleAssignmentClientDiagnostics.CreateScope("RoleAssignmentCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = _roleAssignmentRestClient.ListForScopeNextPage(nextLink, Id, filter, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new RoleAssignmentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
            }
            else
            {
                Page<RoleAssignmentResource> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = _roleAssignmentClientDiagnostics.CreateScope("RoleAssignmentCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = _roleAssignmentRestClient.ListForResource(Id.SubscriptionId, Id.ResourceGroupName, Id.ResourceType.Namespace, Id.Parent.SubstringAfterProviderNamespace(), new ResourceType(Id.ResourceType.GetLastType()), Id.Name, filter, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new RoleAssignmentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                Page<RoleAssignmentResource> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = _roleAssignmentClientDiagnostics.CreateScope("RoleAssignmentCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = _roleAssignmentRestClient.ListForResourceNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.ResourceType.Namespace, Id.Parent.SubstringAfterProviderNamespace(), new ResourceType(Id.ResourceType.GetLastType()), Id.Name, filter, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new RoleAssignmentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /{scope}/providers/Microsoft.Authorization/roleAssignments/{roleAssignmentName}
        /// Operation Id: RoleAssignments_Get
        /// </summary>
        /// <param name="roleAssignmentName"> The name of the role assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string roleAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentName, nameof(roleAssignmentName));

            using var scope = _roleAssignmentClientDiagnostics.CreateScope("RoleAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _roleAssignmentRestClient.GetAsync(Id, roleAssignmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /{scope}/providers/Microsoft.Authorization/roleAssignments/{roleAssignmentName}
        /// Operation Id: RoleAssignments_Get
        /// </summary>
        /// <param name="roleAssignmentName"> The name of the role assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentName"/> is null. </exception>
        public virtual Response<bool> Exists(string roleAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentName, nameof(roleAssignmentName));

            using var scope = _roleAssignmentClientDiagnostics.CreateScope("RoleAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = _roleAssignmentRestClient.Get(Id, roleAssignmentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RoleAssignmentResource> IEnumerable<RoleAssignmentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RoleAssignmentResource> IAsyncEnumerable<RoleAssignmentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}

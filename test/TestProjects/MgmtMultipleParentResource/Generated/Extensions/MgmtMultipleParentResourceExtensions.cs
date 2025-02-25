// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace MgmtMultipleParentResource
{
    /// <summary> A class to add extension methods to MgmtMultipleParentResource. </summary>
    public static partial class MgmtMultipleParentResourceExtensions
    {
        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of AnotherParentResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of AnotherParentResources and their operations over a AnotherParentResource. </returns>
        public static AnotherParentCollection GetAnotherParents(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetAnotherParents();
        }

        /// <summary>
        /// The operation to get the run command.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/anotherParents/{anotherName}
        /// Operation Id: AnotherParents_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="anotherName"> The name of the virtual machine containing the run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="anotherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="anotherName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<AnotherParentResource>> GetAnotherParentAsync(this ResourceGroupResource resourceGroupResource, string anotherName, string expand = null, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetAnotherParents().GetAsync(anotherName, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// The operation to get the run command.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/anotherParents/{anotherName}
        /// Operation Id: AnotherParents_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="anotherName"> The name of the virtual machine containing the run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="anotherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="anotherName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<AnotherParentResource> GetAnotherParent(this ResourceGroupResource resourceGroupResource, string anotherName, string expand = null, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetAnotherParents().Get(anotherName, expand, cancellationToken);
        }

        /// <summary> Gets a collection of TheParentResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of TheParentResources and their operations over a TheParentResource. </returns>
        public static TheParentCollection GetTheParents(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetTheParents();
        }

        /// <summary>
        /// The operation to get the VMSS VM run command.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/theParents/{theParentName}
        /// Operation Id: TheParents_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="theParentName"> The name of the VM scale set. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="theParentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="theParentName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<TheParentResource>> GetTheParentAsync(this ResourceGroupResource resourceGroupResource, string theParentName, string expand = null, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetTheParents().GetAsync(theParentName, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// The operation to get the VMSS VM run command.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/theParents/{theParentName}
        /// Operation Id: TheParents_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="theParentName"> The name of the VM scale set. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="theParentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="theParentName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<TheParentResource> GetTheParent(this ResourceGroupResource resourceGroupResource, string theParentName, string expand = null, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetTheParents().Get(theParentName, expand, cancellationToken);
        }

        #region AnotherParentResource
        /// <summary>
        /// Gets an object representing an <see cref="AnotherParentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AnotherParentResource.CreateResourceIdentifier" /> to create an <see cref="AnotherParentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AnotherParentResource" /> object. </returns>
        public static AnotherParentResource GetAnotherParentResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                AnotherParentResource.ValidateResourceId(id);
                return new AnotherParentResource(client, id);
            }
            );
        }
        #endregion

        #region AnotherParentChildResource
        /// <summary>
        /// Gets an object representing an <see cref="AnotherParentChildResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AnotherParentChildResource.CreateResourceIdentifier" /> to create an <see cref="AnotherParentChildResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AnotherParentChildResource" /> object. </returns>
        public static AnotherParentChildResource GetAnotherParentChildResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                AnotherParentChildResource.ValidateResourceId(id);
                return new AnotherParentChildResource(client, id);
            }
            );
        }
        #endregion

        #region TheParentSubParentChildResource
        /// <summary>
        /// Gets an object representing a <see cref="TheParentSubParentChildResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TheParentSubParentChildResource.CreateResourceIdentifier" /> to create a <see cref="TheParentSubParentChildResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TheParentSubParentChildResource" /> object. </returns>
        public static TheParentSubParentChildResource GetTheParentSubParentChildResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                TheParentSubParentChildResource.ValidateResourceId(id);
                return new TheParentSubParentChildResource(client, id);
            }
            );
        }
        #endregion

        #region TheParentResource
        /// <summary>
        /// Gets an object representing a <see cref="TheParentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TheParentResource.CreateResourceIdentifier" /> to create a <see cref="TheParentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TheParentResource" /> object. </returns>
        public static TheParentResource GetTheParentResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                TheParentResource.ValidateResourceId(id);
                return new TheParentResource(client, id);
            }
            );
        }
        #endregion

        #region SubParentResource
        /// <summary>
        /// Gets an object representing a <see cref="SubParentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SubParentResource.CreateResourceIdentifier" /> to create a <see cref="SubParentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SubParentResource" /> object. </returns>
        public static SubParentResource GetSubParentResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SubParentResource.ValidateResourceId(id);
                return new SubParentResource(client, id);
            }
            );
        }
        #endregion
    }
}

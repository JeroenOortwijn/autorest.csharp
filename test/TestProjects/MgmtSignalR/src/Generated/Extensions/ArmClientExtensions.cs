// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace MgmtSignalR
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region SignalRResource
        /// <summary> Gets an object representing a SignalRResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SignalRResource" /> object. </returns>
        public static SignalRResource GetSignalRResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                SignalRResource.ValidateResourceId(id);
                return new SignalRResource(client, id);
            }
            );
        }
        #endregion

        #region PrivateEndpointConnection
        /// <summary> Gets an object representing a PrivateEndpointConnection along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateEndpointConnection" /> object. </returns>
        public static PrivateEndpointConnection GetPrivateEndpointConnection(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                PrivateEndpointConnection.ValidateResourceId(id);
                return new PrivateEndpointConnection(client, id);
            }
            );
        }
        #endregion
    }
}

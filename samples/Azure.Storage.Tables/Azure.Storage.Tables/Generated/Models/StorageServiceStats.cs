// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

namespace Azure.Storage.Tables.Models
{
    /// <summary> Stats for the storage service. </summary>
    public partial class StorageServiceStats
    {
        /// <summary> Geo-Replication information for the Secondary Storage Service. </summary>
        public GeoReplication GeoReplication { get; set; }
    }
}

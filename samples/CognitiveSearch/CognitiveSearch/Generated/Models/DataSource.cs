// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

namespace CognitiveSearch.Models
{
    /// <summary> Represents a datasource definition, which can be used to configure an indexer. </summary>
    public partial class DataSource
    {
        /// <summary> The name of the datasource. </summary>
        public string Name { get; set; }
        /// <summary> The description of the datasource. </summary>
        public string Description { get; set; }
        /// <summary> The type of the datasource. </summary>
        public DataSourceType Type { get; set; }
        /// <summary> Credentials for the datasource. </summary>
        public DataSourceCredentials Credentials { get; set; } = new DataSourceCredentials();
        /// <summary> The data container for the datasource. </summary>
        public DataContainer Container { get; set; } = new DataContainer();
        /// <summary> The data change detection policy for the datasource. </summary>
        public DataChangeDetectionPolicy DataChangeDetectionPolicy { get; set; }
        /// <summary> The data deletion detection policy for the datasource. </summary>
        public DataDeletionDetectionPolicy DataDeletionDetectionPolicy { get; set; }
        /// <summary> The ETag of the DataSource. </summary>
        public string ETag { get; set; }
    }
}

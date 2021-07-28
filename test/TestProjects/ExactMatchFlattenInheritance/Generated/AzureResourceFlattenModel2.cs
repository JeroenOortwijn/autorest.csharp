// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace ExactMatchFlattenInheritance
{
    /// <summary> A Class representing a AzureResourceFlattenModel2 along with the instance operations that can be performed on it. </summary>
    public class AzureResourceFlattenModel2 : AzureResourceFlattenModel2Operations
    {
        /// <summary> Initializes a new instance of the <see cref = "AzureResourceFlattenModel2"/> class for mocking. </summary>
        protected AzureResourceFlattenModel2() : base()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "AzureResourceFlattenModel2"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal AzureResourceFlattenModel2(ResourceOperations options, AzureResourceFlattenModel2Data resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the AzureResourceFlattenModel2Data. </summary>
        public virtual AzureResourceFlattenModel2Data Data { get; private set; }
    }
}

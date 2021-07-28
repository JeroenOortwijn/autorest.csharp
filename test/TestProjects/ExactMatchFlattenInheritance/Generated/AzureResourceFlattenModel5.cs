// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace ExactMatchFlattenInheritance
{
    /// <summary> A Class representing a AzureResourceFlattenModel5 along with the instance operations that can be performed on it. </summary>
    public class AzureResourceFlattenModel5 : AzureResourceFlattenModel5Operations
    {
        /// <summary> Initializes a new instance of the <see cref = "AzureResourceFlattenModel5"/> class for mocking. </summary>
        protected AzureResourceFlattenModel5() : base()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "AzureResourceFlattenModel5"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal AzureResourceFlattenModel5(ResourceOperations options, AzureResourceFlattenModel5Data resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the AzureResourceFlattenModel5Data. </summary>
        public virtual AzureResourceFlattenModel5Data Data { get; private set; }
    }
}

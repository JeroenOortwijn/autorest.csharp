// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtParamOrdering.Models
{
    /// <summary> The resource management error additional info. </summary>
    internal partial class ErrorAdditionalInfo
    {
        /// <summary> Initializes a new instance of ErrorAdditionalInfo. </summary>
        internal ErrorAdditionalInfo()
        {
        }

        /// <summary> Initializes a new instance of ErrorAdditionalInfo. </summary>
        /// <param name="errorAdditionalInfoType"> The additional info type. </param>
        /// <param name="info"> The additional info. </param>
        internal ErrorAdditionalInfo(string errorAdditionalInfoType, object info)
        {
            ErrorAdditionalInfoType = errorAdditionalInfoType;
            Info = info;
        }

        /// <summary> The additional info type. </summary>
        public string ErrorAdditionalInfoType { get; }
        /// <summary> The additional info. </summary>
        public object Info { get; }
    }
}

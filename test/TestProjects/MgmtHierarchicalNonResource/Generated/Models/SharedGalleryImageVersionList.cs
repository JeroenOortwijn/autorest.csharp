// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace MgmtHierarchicalNonResource.Models
{
    /// <summary> The List Shared Gallery Image versions operation response. </summary>
    internal partial class SharedGalleryImageVersionList
    {
        /// <summary> Initializes a new instance of SharedGalleryImageVersionList. </summary>
        /// <param name="value"> A list of shared gallery images versions. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal SharedGalleryImageVersionList(IEnumerable<SharedGalleryImageVersion> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of SharedGalleryImageVersionList. </summary>
        /// <param name="value"> A list of shared gallery images versions. </param>
        /// <param name="nextLink"> The uri to fetch the next page of shared gallery image versions. Call ListNext() with this to fetch the next page of shared gallery image versions. </param>
        internal SharedGalleryImageVersionList(IReadOnlyList<SharedGalleryImageVersion> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of shared gallery images versions. </summary>
        public IReadOnlyList<SharedGalleryImageVersion> Value { get; }
        /// <summary> The uri to fetch the next page of shared gallery image versions. Call ListNext() with this to fetch the next page of shared gallery image versions. </summary>
        public string NextLink { get; }
    }
}

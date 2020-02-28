// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;

namespace CognitiveSearch.Models
{
    /// <summary> Defines parameters for a search index that influence scoring in search queries. </summary>
    public partial class ScoringProfile
    {
        /// <summary> The name of the scoring profile. </summary>
        public string Name { get; set; }
        /// <summary> Parameters that boost scoring based on text matches in certain index fields. </summary>
        public TextWeights TextWeights { get; set; }
        /// <summary> The collection of functions that influence the scoring of documents. </summary>
        public ICollection<ScoringFunction> Functions { get; set; }
        /// <summary> A value indicating how the results of individual scoring functions should be combined. Defaults to &quot;Sum&quot;. Ignored if there are no scoring functions. </summary>
        public ScoringFunctionAggregation? FunctionAggregation { get; set; }
    }
}

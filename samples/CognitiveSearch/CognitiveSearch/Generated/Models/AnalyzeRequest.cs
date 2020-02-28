// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;

namespace CognitiveSearch.Models
{
    /// <summary> Specifies some text and analysis components used to break that text into tokens. </summary>
    public partial class AnalyzeRequest
    {
        /// <summary> The text to break into tokens. </summary>
        public string Text { get; set; }
        /// <summary> The name of the analyzer to use to break the given text. If this parameter is not specified, you must specify a tokenizer instead. The tokenizer and analyzer parameters are mutually exclusive. </summary>
        public AnalyzerName? Analyzer { get; set; }
        /// <summary> The name of the tokenizer to use to break the given text. If this parameter is not specified, you must specify an analyzer instead. The tokenizer and analyzer parameters are mutually exclusive. </summary>
        public TokenizerName? Tokenizer { get; set; }
        /// <summary> An optional list of token filters to use when breaking the given text. This parameter can only be set when using the tokenizer parameter. </summary>
        public ICollection<TokenFilterName> TokenFilters { get; set; }
        /// <summary> An optional list of character filters to use when breaking the given text. This parameter can only be set when using the tokenizer parameter. </summary>
        public ICollection<string> CharFilters { get; set; }
    }
}

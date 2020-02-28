// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;

namespace CognitiveSearch.Models
{
    /// <summary> Flexibly separates text into terms via a regular expression pattern. This analyzer is implemented using Apache Lucene. </summary>
    public partial class PatternAnalyzer : Analyzer
    {
        /// <summary> Initializes a new instance of PatternAnalyzer. </summary>
        public PatternAnalyzer()
        {
            OdataType = "#Microsoft.Azure.Search.PatternAnalyzer";
        }
        /// <summary> A value indicating whether terms should be lower-cased. Default is true. </summary>
        public bool? LowerCaseTerms { get; set; }
        /// <summary> A regular expression pattern to match token separators. Default is an expression that matches one or more whitespace characters. </summary>
        public string Pattern { get; set; }
        /// <summary> Regular expression flags. </summary>
        public RegexFlags? Flags { get; set; }
        /// <summary> A list of stopwords. </summary>
        public ICollection<string> Stopwords { get; set; }
    }
}

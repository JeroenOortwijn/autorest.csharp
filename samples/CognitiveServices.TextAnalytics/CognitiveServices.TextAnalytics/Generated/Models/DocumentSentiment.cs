// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;

namespace CognitiveServices.TextAnalytics.Models
{
    /// <summary> The DocumentSentiment. </summary>
    public partial class DocumentSentiment
    {
        /// <summary> Unique, non-empty document identifier. </summary>
        public string Id { get; set; }
        /// <summary> Predicted sentiment for document (Negative, Neutral, Positive, or Mixed). </summary>
        public DocumentSentimentValue Sentiment { get; set; }
        /// <summary> if showStats=true was specified in the request this field will contain information about the document payload. </summary>
        public DocumentStatistics Statistics { get; set; }
        /// <summary> Document level sentiment confidence scores between 0 and 1 for each sentiment class. </summary>
        public SentimentConfidenceScorePerLabel DocumentScores { get; set; } = new SentimentConfidenceScorePerLabel();
        /// <summary> Sentence level sentiment analysis. </summary>
        public ICollection<SentenceSentiment> Sentences { get; set; } = new System.Collections.Generic.List<CognitiveServices.TextAnalytics.Models.SentenceSentiment>();
    }
}

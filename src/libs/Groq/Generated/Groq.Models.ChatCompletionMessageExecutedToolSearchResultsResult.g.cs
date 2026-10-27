
#nullable enable

namespace Groq
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChatCompletionMessageExecutedToolSearchResultsResult
    {
        /// <summary>
        /// The content of the search result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// The relevance score of the search result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public float? Score { get; set; }

        /// <summary>
        /// The title of the search result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The URL of the search result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageExecutedToolSearchResultsResult" /> class.
        /// </summary>
        /// <param name="content">
        /// The content of the search result
        /// </param>
        /// <param name="score">
        /// The relevance score of the search result
        /// </param>
        /// <param name="title">
        /// The title of the search result
        /// </param>
        /// <param name="url">
        /// The URL of the search result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionMessageExecutedToolSearchResultsResult(
            string? content,
            float? score,
            string? title,
            string? url)
        {
            this.Content = content;
            this.Score = score;
            this.Title = title;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageExecutedToolSearchResultsResult" /> class.
        /// </summary>
        public ChatCompletionMessageExecutedToolSearchResultsResult()
        {
        }

    }
}
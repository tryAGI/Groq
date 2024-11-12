
#nullable enable

namespace Groq
{
    /// <summary>
    /// Options for streaming response. Only set this when you set `stream: true`.
    /// </summary>
    public sealed partial class ChatCompletionStreamOptions
    {
        /// <summary>
        /// This field is unused
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_usage")]
        public bool? IncludeUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionStreamOptions" /> class.
        /// </summary>
        /// <param name="includeUsage">
        /// This field is unused
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatCompletionStreamOptions(
            bool? includeUsage)
        {
            this.IncludeUsage = includeUsage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionStreamOptions" /> class.
        /// </summary>
        public ChatCompletionStreamOptions()
        {
        }
    }
}

#nullable enable

namespace Groq
{
    /// <summary>
    /// Options for streaming response. Only set this when you set `stream: true`.
    /// </summary>
    public sealed partial class ChatCompletionStreamOptions
    {
        /// <summary>
        /// When true (the default), streamed chunks carry an `obfuscation` field of random padding that normalizes chunk sizes as a mitigation against side-channel attacks. Set to false to reduce bandwidth. Only supported on deployments that stream the obfuscation field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_obfuscation")]
        public bool? IncludeObfuscation { get; set; }

        /// <summary>
        /// If set, an additional chunk will be streamed before the `data: [DONE]` message. The `usage` field on this chunk shows the token usage statistics for the entire request, and the `choices` field will always be an empty array. All other chunks will also include a `usage` field, but with a null value.
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
        /// <param name="includeObfuscation">
        /// When true (the default), streamed chunks carry an `obfuscation` field of random padding that normalizes chunk sizes as a mitigation against side-channel attacks. Set to false to reduce bandwidth. Only supported on deployments that stream the obfuscation field.
        /// </param>
        /// <param name="includeUsage">
        /// If set, an additional chunk will be streamed before the `data: [DONE]` message. The `usage` field on this chunk shows the token usage statistics for the entire request, and the `choices` field will always be an empty array. All other chunks will also include a `usage` field, but with a null value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionStreamOptions(
            bool? includeObfuscation,
            bool? includeUsage)
        {
            this.IncludeObfuscation = includeObfuscation;
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
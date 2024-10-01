
#nullable enable

namespace Groq
{
    /// <summary>
    /// Usage statistics for the completion request.
    /// </summary>
    public sealed partial class CompletionUsage
    {
        /// <summary>
        /// Time spent generating tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_time")]
        public double? CompletionTime { get; set; }

        /// <summary>
        /// Number of tokens in the generated completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CompletionTokens { get; set; }

        /// <summary>
        /// Time spent processing input tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_time")]
        public double? PromptTime { get; set; }

        /// <summary>
        /// Number of tokens in the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PromptTokens { get; set; }

        /// <summary>
        /// Time the requests was spent queued
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue_time")]
        public double? QueueTime { get; set; }

        /// <summary>
        /// completion time and prompt time combined
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_time")]
        public double? TotalTime { get; set; }

        /// <summary>
        /// Total number of tokens used in the request (prompt + completion).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
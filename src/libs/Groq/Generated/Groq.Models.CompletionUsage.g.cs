
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

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionUsage" /> class.
        /// </summary>
        /// <param name="completionTime">
        /// Time spent generating tokens
        /// </param>
        /// <param name="completionTokens">
        /// Number of tokens in the generated completion.
        /// </param>
        /// <param name="promptTime">
        /// Time spent processing input tokens
        /// </param>
        /// <param name="promptTokens">
        /// Number of tokens in the prompt.
        /// </param>
        /// <param name="queueTime">
        /// Time the requests was spent queued
        /// </param>
        /// <param name="totalTime">
        /// completion time and prompt time combined
        /// </param>
        /// <param name="totalTokens">
        /// Total number of tokens used in the request (prompt + completion).
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CompletionUsage(
            int completionTokens,
            int promptTokens,
            int totalTokens,
            double? completionTime,
            double? promptTime,
            double? queueTime,
            double? totalTime)
        {
            this.CompletionTokens = completionTokens;
            this.PromptTokens = promptTokens;
            this.TotalTokens = totalTokens;
            this.CompletionTime = completionTime;
            this.PromptTime = promptTime;
            this.QueueTime = queueTime;
            this.TotalTime = totalTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionUsage" /> class.
        /// </summary>
        public CompletionUsage()
        {
        }
    }
}
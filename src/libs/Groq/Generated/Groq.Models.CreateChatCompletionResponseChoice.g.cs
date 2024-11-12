
#nullable enable

namespace Groq
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateChatCompletionResponseChoice
    {
        /// <summary>
        /// The reason the model stopped generating tokens. This will be `stop` if the model hit a natural stop point or a provided stop sequence,<br/>
        /// `length` if the maximum number of tokens specified in the request was reached,<br/>
        /// `tool_calls` if the model called a tool, or `function_call` (deprecated) if the model called a function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Groq.JsonConverters.CreateChatCompletionResponseChoiceFinishReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Groq.CreateChatCompletionResponseChoiceFinishReason FinishReason { get; set; }

        /// <summary>
        /// The index of the choice in the list of choices.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Log probability information for the choice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Groq.CreateChatCompletionResponseChoiceLogprobs? Logprobs { get; set; }

        /// <summary>
        /// A chat completion message generated by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Groq.ChatCompletionResponseMessage Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionResponseChoice" /> class.
        /// </summary>
        /// <param name="finishReason">
        /// The reason the model stopped generating tokens. This will be `stop` if the model hit a natural stop point or a provided stop sequence,<br/>
        /// `length` if the maximum number of tokens specified in the request was reached,<br/>
        /// `tool_calls` if the model called a tool, or `function_call` (deprecated) if the model called a function.
        /// </param>
        /// <param name="index">
        /// The index of the choice in the list of choices.
        /// </param>
        /// <param name="logprobs">
        /// Log probability information for the choice.
        /// </param>
        /// <param name="message">
        /// A chat completion message generated by the model.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateChatCompletionResponseChoice(
            global::Groq.CreateChatCompletionResponseChoiceFinishReason finishReason,
            int index,
            global::Groq.CreateChatCompletionResponseChoiceLogprobs? logprobs,
            global::Groq.ChatCompletionResponseMessage message)
        {
            this.FinishReason = finishReason;
            this.Index = index;
            this.Logprobs = logprobs ?? throw new global::System.ArgumentNullException(nameof(logprobs));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionResponseChoice" /> class.
        /// </summary>
        public CreateChatCompletionResponseChoice()
        {
        }
    }
}

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Groq
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateChatCompletionRequest
    {
        /// <summary>
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on their existing frequency in the text so far, decreasing the model's likelihood to repeat the same line verbatim.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// Deprecated in favor of `tool_choice`.<br/>
        /// Controls which (if any) function is called by the model.<br/>
        /// `none` means the model will not call a function and instead generates a message.<br/>
        /// `auto` means the model can pick between generating a message or calling a function.<br/>
        /// Specifying a particular function via `{"name": "my_function"}` forces the model to call that function.<br/>
        /// `none` is the default when no functions are present. `auto` is the default if functions are present.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_call")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Groq.JsonConverters.OneOfJsonConverter<global::Groq.CreateChatCompletionRequestFunctionCall?, global::Groq.ChatCompletionFunctionCallOption>))]
        public global::Groq.OneOf<global::Groq.CreateChatCompletionRequestFunctionCall?, global::Groq.ChatCompletionFunctionCallOption>? FunctionCall { get; set; }

        /// <summary>
        /// Deprecated in favor of `tools`.<br/>
        /// A list of functions the model may generate JSON inputs for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functions")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::Groq.ChatCompletionFunctions>? Functions { get; set; }

        /// <summary>
        /// This is not yet supported by any of our models.<br/>
        /// Modify the likelihood of specified tokens appearing in the completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logit_bias")]
        public global::System.Collections.Generic.Dictionary<string, int>? LogitBias { get; set; }

        /// <summary>
        /// This is not yet supported by any of our models.<br/>
        /// Whether to return log probabilities of the output tokens or not. If true, returns the log probabilities of each output token returned in the `content` of `message`.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public bool? Logprobs { get; set; }

        /// <summary>
        /// The maximum number of tokens that can be generated in the chat completion. The total length of input tokens and generated tokens is limited by the model's context length.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// A list of messages comprising the conversation so far.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Groq.ChatCompletionRequestMessage> Messages { get; set; }

        /// <summary>
        /// ID of the model to use. For details on which models are compatible with the Chat API, see available [models](/docs/models)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Groq.JsonConverters.AnyOfJsonConverter<string, global::Groq.CreateChatCompletionRequestModel?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Groq.AnyOf<string, global::Groq.CreateChatCompletionRequestModel?> Model { get; set; }

        /// <summary>
        /// How many chat completion choices to generate for each input message. Note that the current moment, only n=1 is supported. Other values will result in a 400 response.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; }

        /// <summary>
        /// Whether to enable parallel function calling during tool use.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on whether they appear in the text so far, increasing the model's likelihood to talk about new topics.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// An object specifying the format that the model must output. <br/>
        /// Setting to `{ "type": "json_object" }` enables JSON mode, which guarantees the message the model generates is valid JSON.<br/>
        /// **Important:** when using JSON mode, you **must** also instruct the model to produce JSON yourself via a system or user message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public global::Groq.CreateChatCompletionRequestResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same `seed` and parameters should return the same result.<br/>
        /// Determinism is not guaranteed, and you should refer to the `system_fingerprint` response parameter to monitor changes in the backend.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Up to 4 sequences where the API will stop generating further tokens. The returned text will not contain the stop sequence.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Groq.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Groq.OneOf<string, global::System.Collections.Generic.IList<string>>? Stop { get; set; }

        /// <summary>
        /// If set, partial message deltas will be sent. Tokens will be sent as data-only [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events#Event_stream_format) as they become available, with the stream terminated by a `data: [DONE]` message. [Example code](/docs/text-chat#streaming-a-chat-completion).<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. We generally recommend altering this or top_p but not both<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Controls which (if any) tool is called by the model.<br/>
        /// `none` means the model will not call any tool and instead generates a message.<br/>
        /// `auto` means the model can pick between generating a message or calling one or more tools.<br/>
        /// `required` means the model must call one or more tools.<br/>
        /// Specifying a particular tool via `{"type": "function", "function": {"name": "my_function"}}` forces the model to call that tool.<br/>
        /// `none` is the default when no tools are present. `auto` is the default if tools are present.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Groq.JsonConverters.ChatCompletionToolChoiceOptionJsonConverter))]
        public global::Groq.ChatCompletionToolChoiceOption? ToolChoice { get; set; }

        /// <summary>
        /// A list of tools the model may call. Currently, only functions are supported as a tool. Use this to provide a list of functions the model may generate JSON inputs for. A max of 128 functions are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Groq.ChatCompletionTool>? Tools { get; set; }

        /// <summary>
        /// This is not yet supported by any of our models.<br/>
        /// An integer between 0 and 20 specifying the number of most likely tokens to return at each token position, each with an associated log probability. `logprobs` must be set to `true` if this parameter is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_logprobs")]
        public int? TopLogprobs { get; set; }

        /// <summary>
        /// An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered. We generally recommend altering this or temperature but not both.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// A unique identifier representing your end-user, which can help us monitor and detect abuse.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequest" /> class.
        /// </summary>
        /// <param name="frequencyPenalty">
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on their existing frequency in the text so far, decreasing the model's likelihood to repeat the same line verbatim.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="logitBias">
        /// This is not yet supported by any of our models.<br/>
        /// Modify the likelihood of specified tokens appearing in the completion.
        /// </param>
        /// <param name="logprobs">
        /// This is not yet supported by any of our models.<br/>
        /// Whether to return log probabilities of the output tokens or not. If true, returns the log probabilities of each output token returned in the `content` of `message`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens that can be generated in the chat completion. The total length of input tokens and generated tokens is limited by the model's context length.
        /// </param>
        /// <param name="messages">
        /// A list of messages comprising the conversation so far.
        /// </param>
        /// <param name="model">
        /// ID of the model to use. For details on which models are compatible with the Chat API, see available [models](/docs/models)
        /// </param>
        /// <param name="n">
        /// How many chat completion choices to generate for each input message. Note that the current moment, only n=1 is supported. Other values will result in a 400 response.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="parallelToolCalls">
        /// Whether to enable parallel function calling during tool use.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="presencePenalty">
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on whether they appear in the text so far, increasing the model's likelihood to talk about new topics.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="responseFormat">
        /// An object specifying the format that the model must output. <br/>
        /// Setting to `{ "type": "json_object" }` enables JSON mode, which guarantees the message the model generates is valid JSON.<br/>
        /// **Important:** when using JSON mode, you **must** also instruct the model to produce JSON yourself via a system or user message.
        /// </param>
        /// <param name="seed">
        /// If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same `seed` and parameters should return the same result.<br/>
        /// Determinism is not guaranteed, and you should refer to the `system_fingerprint` response parameter to monitor changes in the backend.
        /// </param>
        /// <param name="stop">
        /// Up to 4 sequences where the API will stop generating further tokens. The returned text will not contain the stop sequence.
        /// </param>
        /// <param name="stream">
        /// If set, partial message deltas will be sent. Tokens will be sent as data-only [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events#Event_stream_format) as they become available, with the stream terminated by a `data: [DONE]` message. [Example code](/docs/text-chat#streaming-a-chat-completion).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="temperature">
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. We generally recommend altering this or top_p but not both<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="toolChoice">
        /// Controls which (if any) tool is called by the model.<br/>
        /// `none` means the model will not call any tool and instead generates a message.<br/>
        /// `auto` means the model can pick between generating a message or calling one or more tools.<br/>
        /// `required` means the model must call one or more tools.<br/>
        /// Specifying a particular tool via `{"type": "function", "function": {"name": "my_function"}}` forces the model to call that tool.<br/>
        /// `none` is the default when no tools are present. `auto` is the default if tools are present.
        /// </param>
        /// <param name="tools">
        /// A list of tools the model may call. Currently, only functions are supported as a tool. Use this to provide a list of functions the model may generate JSON inputs for. A max of 128 functions are supported.
        /// </param>
        /// <param name="topLogprobs">
        /// This is not yet supported by any of our models.<br/>
        /// An integer between 0 and 20 specifying the number of most likely tokens to return at each token position, each with an associated log probability. `logprobs` must be set to `true` if this parameter is used.
        /// </param>
        /// <param name="topP">
        /// An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered. We generally recommend altering this or temperature but not both.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which can help us monitor and detect abuse.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateChatCompletionRequest(
            global::System.Collections.Generic.IList<global::Groq.ChatCompletionRequestMessage> messages,
            global::Groq.AnyOf<string, global::Groq.CreateChatCompletionRequestModel?> model,
            double? frequencyPenalty,
            global::System.Collections.Generic.Dictionary<string, int>? logitBias,
            bool? logprobs,
            int? maxTokens,
            int? n,
            bool? parallelToolCalls,
            double? presencePenalty,
            global::Groq.CreateChatCompletionRequestResponseFormat? responseFormat,
            int? seed,
            global::Groq.OneOf<string, global::System.Collections.Generic.IList<string>>? stop,
            bool? stream,
            double? temperature,
            global::Groq.ChatCompletionToolChoiceOption? toolChoice,
            global::System.Collections.Generic.IList<global::Groq.ChatCompletionTool>? tools,
            int? topLogprobs,
            double? topP,
            string? user)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Model = model;
            this.FrequencyPenalty = frequencyPenalty;
            this.LogitBias = logitBias;
            this.Logprobs = logprobs;
            this.MaxTokens = maxTokens;
            this.N = n;
            this.ParallelToolCalls = parallelToolCalls;
            this.PresencePenalty = presencePenalty;
            this.ResponseFormat = responseFormat;
            this.Seed = seed;
            this.Stop = stop;
            this.Stream = stream;
            this.Temperature = temperature;
            this.ToolChoice = toolChoice;
            this.Tools = tools;
            this.TopLogprobs = topLogprobs;
            this.TopP = topP;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequest" /> class.
        /// </summary>
        public CreateChatCompletionRequest()
        {
        }
    }
}
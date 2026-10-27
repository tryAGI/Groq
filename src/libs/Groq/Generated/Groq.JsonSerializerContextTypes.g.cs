
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Groq
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Groq.Annotation? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.DocumentCitation? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.FunctionCitation? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.AnnotationType? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.Batch? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.BatchErrors? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.BatchErrorsDataItem>? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.BatchErrorsDataItem? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.BatchObject? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.BatchRequestCounts? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.BatchStatus? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.BatchRequestInput? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.BatchRequestInputMethod? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.BatchRequestOutput? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.BatchRequestOutputError? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.BatchRequestOutputResponse? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.BrowserResult? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.Chart? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ChartElement>? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChartElement? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChartType? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionDocument? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionDocumentSource? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionDocumentSourceText? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionDocumentSourceJSON? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionDocumentSourceDiscriminator? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionDocumentSourceDiscriminatorType? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionDocumentSourceJSONType? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionDocumentSourceTextType? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionFunctionCallOption? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionFunctions? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.FunctionParameters? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ChatCompletionMessageExecutedTool>? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionMessageExecutedTool? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.BrowserResult>? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.CodeExecutionResult>? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CodeExecutionResult? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionMessageExecutedToolSearchResults? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ChatCompletionMessageExecutedToolSearchResultsResult>? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionMessageExecutedToolSearchResultsResult? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionMessageToolCall? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionMessageToolCallFunction? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionMessageToolCallType? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionMessageToolCallChunk? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionMessageToolCallChunkFunction? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionMessageToolCallChunkType? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ChatCompletionMessageToolCall>? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionNamedToolChoice? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionNamedToolChoiceFunction? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionNamedToolChoiceType? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionRequestAssistantMessage? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.OneOf<string, global::System.Collections.Generic.IList<global::Groq.ChatCompletionRequestMessageContentPartText>>? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ChatCompletionRequestMessageContentPartText>? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionRequestMessageContentPartText? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionRequestAssistantMessageFunctionCall? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionRequestAssistantMessageRole? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionRequestFunctionMessage? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionRequestFunctionMessageRole? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionRequestMessage? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionRequestSystemMessage? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionRequestUserMessage? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionRequestToolMessage? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionRequestMessageDiscriminator? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionRequestMessageDiscriminatorRole? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionRequestMessageContentPart? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionRequestMessageContentPartImage? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionRequestMessageContentPartDocument? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionRequestMessageContentPartDocumentDocument? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionRequestMessageContentPartDocumentType? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionRequestMessageContentPartImageImageUrl? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionRequestMessageContentPartImageImageUrlDetail? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionRequestMessageContentPartImageType? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionRequestMessageContentPartTextType? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionRequestSystemMessageRole? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.OneOf<string, global::System.Collections.Generic.IList<global::Groq.ChatCompletionRequestMessageContentPart>>? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ChatCompletionRequestMessageContentPart>? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionRequestToolMessageRole? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionRequestUserMessageRole? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionResponseMessage? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.Annotation>? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionResponseMessageFunctionCall? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionResponseMessageRole? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionRole? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionStreamOptions? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionStreamResponseDelta? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionStreamResponseDeltaFunctionCall? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionStreamResponseDeltaRole? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ChatCompletionMessageToolCallChunk>? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionTokenLogprob? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<long>? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ChatCompletionTokenLogprobTopLogprob>? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionTokenLogprobTopLogprob? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionTool? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.FunctionObject? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.AnyOf<global::Groq.ChatCompletionToolType?, string>? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionToolType? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionToolChoiceOption? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionToolChoiceOptionEnum? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionUsageBreakdown? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ChatCompletionUsageBreakdownModel>? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ChatCompletionUsageBreakdownModel? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CompletionUsage? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.Chart>? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CompletionUsageCompletionTokensDetails? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CompletionUsagePromptTokensDetails? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateChatCompletionRequest? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateChatCompletionRequestCitationOptions? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateChatCompletionRequestCompoundCustom? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateChatCompletionRequestCompoundCustomModels? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateChatCompletionRequestCompoundCustomTools? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateChatCompletionRequestCompoundCustomToolsWolframSettings? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateChatCompletionRequestCustomTemplate? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ChatCompletionDocument>? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.OneOf<global::Groq.CreateChatCompletionRequestFunctionCall?, global::Groq.ChatCompletionFunctionCallOption>? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateChatCompletionRequestFunctionCall? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ChatCompletionFunctions>? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ChatCompletionRequestMessage>? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.AnyOf<string, global::Groq.CreateChatCompletionRequestModel?>? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateChatCompletionRequestModel? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateChatCompletionRequestReasoningEffort? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateChatCompletionRequestReasoningFormat? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.OneOf<global::Groq.ResponseFormatText, global::Groq.ResponseFormatJsonSchema, global::Groq.ResponseFormatJsonObject>? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseFormatText? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseFormatJsonSchema? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseFormatJsonObject? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateChatCompletionRequestSearchSettings? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateChatCompletionRequestServiceTier? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.OneOf<string, global::System.Collections.Generic.IList<string>>? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ChatCompletionTool>? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateChatCompletionResponse? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.CreateChatCompletionResponseChoice>? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateChatCompletionResponseChoice? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateChatCompletionResponseChoiceFinishReason? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateChatCompletionResponseChoiceLogprobs? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ChatCompletionTokenLogprob>? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.CreateChatCompletionResponseMcpListTool>? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateChatCompletionResponseMcpListTool? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.CreateChatCompletionResponseMcpListToolTool>? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateChatCompletionResponseMcpListToolTool? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateChatCompletionResponseObject? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateChatCompletionResponseServiceTier? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.XGroqNonStreaming? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateChatCompletionStreamResponse? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.CreateChatCompletionStreamResponseChoice>? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateChatCompletionStreamResponseChoice? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateChatCompletionStreamResponseChoiceFinishReason? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateChatCompletionStreamResponseChoiceLogprobs? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateChatCompletionStreamResponseObject? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateChatCompletionStreamResponseServiceTier? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.XGroq? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateEmbeddingRequest? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateEmbeddingRequestEncodingFormat? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.AnyOf<string, global::Groq.CreateEmbeddingRequestModel?>? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateEmbeddingRequestModel? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateEmbeddingResponse? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.Embedding>? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.Embedding? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateEmbeddingResponseObject? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateEmbeddingResponseUsage? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateFileRequest? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateFileRequestPurpose? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateFineTuningRequest? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateResponseRequest? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.OneOf<string, global::System.Collections.Generic.IList<global::Groq.ResponseInputItem>>? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ResponseInputItem>? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseInputItem? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.AnyOf<string, global::Groq.CreateResponseRequestModel?>? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateResponseRequestModel? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateResponseRequestReasoning? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateResponseRequestReasoningEffort? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateResponseRequestServiceTier? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateResponseRequestText? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseFormatConfiguration? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseToolChoiceOption? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ResponseTool>? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseTool? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateResponseRequestTruncation? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateResponseResponse? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateResponseResponseError? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateResponseResponseIncompleteDetails? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateResponseResponseObject? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ResponseOutputItem>? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseOutputItem? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateResponseResponseReasoning? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateResponseResponseReasoningEffort? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateResponseResponseServiceTier? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateResponseResponseStatus? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateResponseResponseText? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateResponseResponseTruncation? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseUsage? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateSpeechRequest? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.AnyOf<string, global::Groq.CreateSpeechRequestModel?>? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateSpeechRequestModel? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateSpeechRequestResponseFormat? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateTranscriptionRequest? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.AnyOf<string, global::Groq.CreateTranscriptionRequestLanguage?>? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateTranscriptionRequestLanguage? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.AnyOf<string, global::Groq.CreateTranscriptionRequestModel?>? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateTranscriptionRequestModel? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateTranscriptionRequestResponseFormat? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.CreateTranscriptionRequestTimestampGranularitie>? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateTranscriptionRequestTimestampGranularitie? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateTranscriptionResponseJson? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateTranscriptionResponseVerboseJson? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.TranscriptionSegment>? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.TranscriptionSegment? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.TranscriptionWord>? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.TranscriptionWord? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateTranslationRequest? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.AnyOf<string, global::Groq.CreateTranslationRequestModel?>? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateTranslationRequestModel? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateTranslationRequestResponseFormat? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateTranslationResponseJson? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateTranslationResponseVerboseJson? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.DebugData? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.DeleteFileResponse? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.DeleteFileResponseObject? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.DeleteFineTuningResponse? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.DeleteModelResponse? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.OneOf<global::System.Collections.Generic.IList<double>, string>? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.EmbeddingObject? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.Error? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ErrorResponse? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.File? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.FileObject? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.FilePurpose? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ListBatchesResponse? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.Batch>? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ListBatchesResponseObject? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ListFilesResponse? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.File>? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ListFilesResponseObject? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ListFineTuningsResponse? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ListFineTuningsResponseDataItem>? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ListFineTuningsResponseDataItem? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ListModelsResponse? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.Model7>? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.Model7? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ListModelsResponseObject? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ModelObject? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ReadFineTuningResponse? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ReadFineTuningResponseData? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.RerankingRequest? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.RerankingResponse? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.RerankingResult>? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.RerankingResult? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseAnnotation? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseFileCitation? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseUrlCitation? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseAnnotationDiscriminator? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseAnnotationDiscriminatorType? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseEasyInputMessage? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.OneOf<string, global::System.Collections.Generic.IList<global::Groq.ResponseInputContent>>? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ResponseInputContent>? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseInputContent? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseEasyInputMessageRole? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseFileCitationType? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.TextResponseFormatJsonSchema? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseFormatJsonObjectType? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseFormatJsonSchemaJsonSchema? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseFormatJsonSchemaSchema? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseFormatJsonSchemaType? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseFormatTextType? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseFunctionCall? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseFunctionCallStatus? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseFunctionCallType? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseFunctionCallOutput? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseFunctionCallOutputStatus? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseFunctionCallOutputType? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseInputTextContent? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseInputContentDiscriminator? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseInputContentDiscriminatorType? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseInputMessage? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseItemReference? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseInputItemDiscriminator? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseInputItemDiscriminatorType? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseInputMessageRole? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseInputMessageStatus? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseInputMessageType? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseInputTextContentType? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseItemReferenceType? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseNamedToolChoice? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseNamedToolChoiceFunction? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseNamedToolChoiceType? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseOutputContent? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseOutputTextContent? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseOutputContentDiscriminator? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseOutputContentDiscriminatorType? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseOutputFunctionCall? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseOutputFunctionCallStatus? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseOutputFunctionCallType? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseOutputMessage? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseOutputReasoning? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseOutputItemDiscriminator? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseOutputItemDiscriminatorType? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ResponseOutputContent>? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseOutputMessageRole? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseOutputMessageStatus? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseOutputMessageType? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseOutputReasoningType? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ResponseAnnotation>? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseOutputTextContentType? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseToolType? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseToolChoiceOptionEnum? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseUrlCitationType? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseUsageInputTokensDetails? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.ResponseUsageOutputTokensDetails? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.TextResponseFormatJsonSchemaType? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<float>? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.XGroqNonStreamingUsage? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateBatchRequest? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.CreateBatchRequestEndpoint? Type327 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.BatchErrorsDataItem>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ChartElement>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ChatCompletionMessageExecutedTool>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.BrowserResult>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.CodeExecutionResult>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ChatCompletionMessageExecutedToolSearchResultsResult>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ChatCompletionMessageToolCall>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.OneOf<string, global::System.Collections.Generic.List<global::Groq.ChatCompletionRequestMessageContentPartText>>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ChatCompletionRequestMessageContentPartText>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.OneOf<string, global::System.Collections.Generic.List<global::Groq.ChatCompletionRequestMessageContentPart>>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ChatCompletionRequestMessageContentPart>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.Annotation>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ChatCompletionMessageToolCallChunk>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<long>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ChatCompletionTokenLogprobTopLogprob>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ChatCompletionUsageBreakdownModel>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.Chart>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ChatCompletionDocument>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ChatCompletionFunctions>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ChatCompletionRequestMessage>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.OneOf<string, global::System.Collections.Generic.List<string>>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ChatCompletionTool>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.CreateChatCompletionResponseChoice>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ChatCompletionTokenLogprob>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.CreateChatCompletionResponseMcpListTool>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.CreateChatCompletionResponseMcpListToolTool>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.CreateChatCompletionStreamResponseChoice>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.Embedding>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.OneOf<string, global::System.Collections.Generic.List<global::Groq.ResponseInputItem>>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ResponseInputItem>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ResponseTool>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ResponseOutputItem>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.CreateTranscriptionRequestTimestampGranularitie>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.TranscriptionSegment>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.TranscriptionWord>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.OneOf<global::System.Collections.Generic.List<double>, string>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.Batch>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.File>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ListFineTuningsResponseDataItem>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.Model7>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.RerankingResult>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Groq.OneOf<string, global::System.Collections.Generic.List<global::Groq.ResponseInputContent>>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ResponseInputContent>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ResponseOutputContent>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ResponseAnnotation>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<float>? ListType50 { get; set; }
    }
}

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
        /// 
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::Groq.Error? Type0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.DebugData? Type3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ErrorResponse? Type4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateSpeechRequest? Type5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.AnyOf<string, global::Groq.CreateSpeechRequestModel?>? Type6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateSpeechRequestModel? Type7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateSpeechRequestResponseFormat? Type8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Type9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Type10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateTranscriptionRequest? Type11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[]? Type12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.AnyOf<string, global::Groq.CreateTranscriptionRequestModel?>? Type13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateTranscriptionRequestModel? Type14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.AnyOf<string, global::Groq.CreateTranscriptionRequestLanguage?>? Type15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateTranscriptionRequestLanguage? Type16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateTranscriptionRequestResponseFormat? Type17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.CreateTranscriptionRequestTimestampGranularitie>? Type18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateTranscriptionRequestTimestampGranularitie? Type19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public object? Type20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateTranscriptionResponseJson? Type21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.TranscriptionSegment? Type22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public float? Type23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<float>? Type25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.TranscriptionWord? Type26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateTranscriptionResponseVerboseJson? Type27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.TranscriptionWord>? Type28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.TranscriptionSegment>? Type29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateTranslationRequest? Type30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.AnyOf<string, global::Groq.CreateTranslationRequestModel?>? Type31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateTranslationRequestModel? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateTranslationRequestResponseFormat? Type33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateTranslationResponseJson? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateTranslationResponseVerboseJson? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.Batch? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.BatchObject? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.BatchErrors? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.BatchErrorsDataItem>? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.BatchErrorsDataItem? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.BatchStatus? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTimeOffset? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.BatchRequestCounts? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.BatchRequestInput? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.BatchRequestInputMethod? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.BatchRequestOutput? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.BatchRequestOutputResponse? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.BatchRequestOutputError? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ListBatchesResponse? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.Batch>? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ListBatchesResponseObject? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionRequestMessageContentPart? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionRequestMessageContentPartText? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionRequestMessageContentPartImage? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionRequestMessageContentPartDocument? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionRequestMessageContentPartImageType? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionRequestMessageContentPartImageImageUrl? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionRequestMessageContentPartImageImageUrlDetail? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionRequestMessageContentPartTextType? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionRequestMessageContentPartDocumentType? Type60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionRequestMessageContentPartDocumentDocument? Type61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionDocument? Type62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionDocumentSource? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionDocumentSourceText? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionDocumentSourceJSON? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionDocumentSourceDiscriminator? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionDocumentSourceDiscriminatorType? Type67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionDocumentSourceTextType? Type68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionDocumentSourceJSONType? Type69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionRequestMessage? Type70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionRequestSystemMessage? Type71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionRequestUserMessage? Type72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionRequestAssistantMessage? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionRequestToolMessage? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionRequestFunctionMessage? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionRequestMessageDiscriminator? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionRequestMessageDiscriminatorRole? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.OneOf<string, global::System.Collections.Generic.IList<global::Groq.ChatCompletionRequestMessageContentPartText>>? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ChatCompletionRequestMessageContentPartText>? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionRequestSystemMessageRole? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.OneOf<string, global::System.Collections.Generic.IList<global::Groq.ChatCompletionRequestMessageContentPart>>? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ChatCompletionRequestMessageContentPart>? Type82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionRequestUserMessageRole? Type83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionRequestAssistantMessageRole? Type84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ChatCompletionMessageToolCall>? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionRequestAssistantMessageFunctionCall? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionRequestToolMessageRole? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionRequestFunctionMessageRole? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionFunctions? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionFunctionCallOption? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionTool? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.AnyOf<global::Groq.ChatCompletionToolType?, string>? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionToolType? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.FunctionObject? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionToolChoiceOption? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionToolChoiceOptionEnum? Type97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionNamedToolChoice? Type98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionNamedToolChoiceType? Type99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionNamedToolChoiceFunction? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionMessageToolCall? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionMessageToolCallType? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionMessageToolCallFunction? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionMessageToolCallChunk? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionMessageToolCallChunkType? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionMessageToolCallChunkFunction? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionRole? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionStreamOptions? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionResponseMessage? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ChatCompletionMessageExecutedTool>? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionResponseMessageRole? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionResponseMessageFunctionCall? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.Annotation>? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.Annotation? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionMessageExecutedTool? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionMessageExecutedToolSearchResults? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ChatCompletionMessageExecutedToolSearchResultsResult>? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionMessageExecutedToolSearchResultsResult? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.CodeExecutionResult>? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CodeExecutionResult? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.BrowserResult>? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.BrowserResult? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionStreamResponseDelta? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionStreamResponseDeltaFunctionCall? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ChatCompletionMessageToolCallChunk>? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionStreamResponseDeltaRole? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateChatCompletionRequest? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ChatCompletionRequestMessage>? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.AnyOf<string, global::Groq.CreateChatCompletionRequestModel?>? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateChatCompletionRequestModel? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.OneOf<global::Groq.ResponseFormatText, global::Groq.ResponseFormatJsonSchema, global::Groq.ResponseFormatJsonObject>? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseFormatText? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseFormatJsonSchema? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseFormatJsonObject? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateChatCompletionRequestServiceTier? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.OneOf<string, global::System.Collections.Generic.IList<string>>? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateChatCompletionRequestReasoningEffort? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateChatCompletionRequestReasoningFormat? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ChatCompletionTool>? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.OneOf<global::Groq.CreateChatCompletionRequestFunctionCall?, global::Groq.ChatCompletionFunctionCallOption>? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateChatCompletionRequestFunctionCall? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ChatCompletionFunctions>? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateChatCompletionRequestSearchSettings? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateChatCompletionRequestCompoundCustom? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateChatCompletionRequestCompoundCustomModels? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateChatCompletionRequestCompoundCustomTools? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateChatCompletionRequestCompoundCustomToolsWolframSettings? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ChatCompletionDocument>? Type150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateChatCompletionRequestCitationOptions? Type151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseFormatJsonObjectType? Type152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseFormatJsonSchemaType? Type153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseFormatJsonSchemaJsonSchema? Type154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseFormatTextType? Type155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateChatCompletionResponse? Type156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.CreateChatCompletionResponseChoice>? Type157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateChatCompletionResponseChoice? Type158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateChatCompletionResponseChoiceFinishReason? Type159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateChatCompletionResponseChoiceLogprobs? Type160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ChatCompletionTokenLogprob>? Type161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionTokenLogprob? Type162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateChatCompletionResponseObject? Type163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CompletionUsage? Type164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionUsageBreakdown? Type165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateChatCompletionResponseServiceTier? Type166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.CreateChatCompletionResponseMcpListTool>? Type167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateChatCompletionResponseMcpListTool? Type168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.CreateChatCompletionResponseMcpListToolTool>? Type169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateChatCompletionResponseMcpListToolTool? Type170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.XGroqNonStreaming? Type171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<long>? Type172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? Type173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ChatCompletionTokenLogprobTopLogprob>? Type174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionTokenLogprobTopLogprob? Type175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.XGroqNonStreamingUsage? Type176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.XGroq? Type177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateChatCompletionStreamResponse? Type178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.CreateChatCompletionStreamResponseChoice>? Type179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateChatCompletionStreamResponseChoice? Type180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateChatCompletionStreamResponseChoiceLogprobs? Type181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateChatCompletionStreamResponseChoiceFinishReason? Type182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateChatCompletionStreamResponseObject? Type183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CompletionUsagePromptTokensDetails? Type184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CompletionUsageCompletionTokensDetails? Type185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ChatCompletionUsageBreakdownModel>? Type186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionUsageBreakdownModel? Type187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.Chart? Type188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChartType? Type189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ChartElement>? Type191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChartElement? Type192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? Type193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.Chart>? Type194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.AnnotationType? Type195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.DocumentCitation? Type196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.FunctionCitation? Type197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.Embedding? Type198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.OneOf<global::System.Collections.Generic.IList<double>, string>? Type199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.EmbeddingObject? Type200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateEmbeddingRequest? Type201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.AnyOf<string, global::Groq.CreateEmbeddingRequestModel?>? Type202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateEmbeddingRequestModel? Type203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateEmbeddingRequestEncodingFormat? Type204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateEmbeddingResponse? Type205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.Embedding>? Type206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateEmbeddingResponseObject? Type207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateEmbeddingResponseUsage? Type208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.File? Type209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.FileObject? Type210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.FilePurpose? Type211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateFileRequest? Type212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateFileRequestPurpose? Type213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.DeleteFileResponse? Type214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.DeleteFileResponseObject? Type215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ListFilesResponse? Type216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ListFilesResponseObject? Type217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.File>? Type218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateFineTuningRequest? Type219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.DeleteFineTuningResponse? Type220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ListFineTuningsResponse? Type221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ListFineTuningsResponseDataItem>? Type222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ListFineTuningsResponseDataItem? Type223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ReadFineTuningResponse? Type224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ReadFineTuningResponseData? Type225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.Model6? Type226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ModelObject? Type227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ListModelsResponse? Type228 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ListModelsResponseObject? Type229 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.Model6>? Type230 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.DeleteModelResponse? Type231 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.RerankingRequest? Type232 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.RerankingResponse? Type233 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.RerankingResult>? Type234 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.RerankingResult? Type235 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateResponseRequest? Type236 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.AnyOf<string, global::Groq.CreateResponseRequestModel?>? Type237 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateResponseRequestModel? Type238 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.OneOf<string, global::System.Collections.Generic.IList<global::Groq.ResponseInputItem>>? Type239 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ResponseInputItem>? Type240 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseInputItem? Type241 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ResponseTool>? Type242 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseTool? Type243 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseToolChoiceOption? Type244 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateResponseRequestText? Type245 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseFormatConfiguration? Type246 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateResponseRequestReasoning? Type247 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateResponseRequestReasoningEffort? Type248 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateResponseRequestServiceTier? Type249 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateResponseRequestTruncation? Type250 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseEasyInputMessage? Type251 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseInputMessage? Type252 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseItemReference? Type253 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseFunctionCall? Type254 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseFunctionCallOutput? Type255 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseInputItemDiscriminator? Type256 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseInputItemDiscriminatorType? Type257 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseEasyInputMessageRole? Type258 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.OneOf<string, global::System.Collections.Generic.IList<global::Groq.ResponseInputContent>>? Type259 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ResponseInputContent>? Type260 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseInputContent? Type261 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseInputMessageType? Type262 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseInputMessageRole? Type263 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseInputMessageStatus? Type264 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseInputTextContent? Type265 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseInputContentDiscriminator? Type266 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseInputContentDiscriminatorType? Type267 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseInputTextContentType? Type268 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseItemReferenceType? Type269 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseFunctionCallType? Type270 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseFunctionCallStatus? Type271 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseFunctionCallOutputType? Type272 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseFunctionCallOutputStatus? Type273 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseToolType? Type274 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseToolChoiceOptionEnum? Type275 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseNamedToolChoice? Type276 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseNamedToolChoiceType? Type277 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseNamedToolChoiceFunction? Type278 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.TextResponseFormatJsonSchema? Type279 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.TextResponseFormatJsonSchemaType? Type280 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateResponseResponse? Type281 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateResponseResponseObject? Type282 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateResponseResponseStatus? Type283 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ResponseOutputItem>? Type284 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseOutputItem? Type285 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateResponseResponseReasoning? Type286 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateResponseResponseReasoningEffort? Type287 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateResponseResponseText? Type288 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateResponseResponseTruncation? Type289 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateResponseResponseServiceTier? Type290 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateResponseResponseError? Type291 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateResponseResponseIncompleteDetails? Type292 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseUsage? Type293 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseOutputMessage? Type294 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseOutputFunctionCall? Type295 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseOutputReasoning? Type296 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseOutputItemDiscriminator? Type297 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseOutputItemDiscriminatorType? Type298 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseOutputMessageType? Type299 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseOutputMessageStatus? Type300 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseOutputMessageRole? Type301 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ResponseOutputContent>? Type302 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseOutputContent? Type303 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseOutputTextContent? Type304 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseOutputContentDiscriminator? Type305 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseOutputContentDiscriminatorType? Type306 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseOutputTextContentType? Type307 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Groq.ResponseAnnotation>? Type308 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseAnnotation? Type309 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseFileCitation? Type310 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseUrlCitation? Type311 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseAnnotationDiscriminator? Type312 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseAnnotationDiscriminatorType? Type313 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseFileCitationType? Type314 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseUrlCitationType? Type315 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseOutputFunctionCallType? Type316 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseOutputFunctionCallStatus? Type317 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseOutputReasoningType? Type318 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type319 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseUsageInputTokensDetails? Type320 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseUsageOutputTokensDetails? Type321 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateBatchRequest? Type322 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.CreateBatchRequestEndpoint? Type323 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.CreateTranscriptionRequestTimestampGranularitie>? ListType1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<float>? ListType3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.TranscriptionWord>? ListType4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.TranscriptionSegment>? ListType5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.BatchErrorsDataItem>? ListType6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.Batch>? ListType7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.OneOf<string, global::System.Collections.Generic.List<global::Groq.ChatCompletionRequestMessageContentPartText>>? ListType8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ChatCompletionRequestMessageContentPartText>? ListType9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.OneOf<string, global::System.Collections.Generic.List<global::Groq.ChatCompletionRequestMessageContentPart>>? ListType10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ChatCompletionRequestMessageContentPart>? ListType11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ChatCompletionMessageToolCall>? ListType12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ChatCompletionMessageExecutedTool>? ListType13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.Annotation>? ListType14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ChatCompletionMessageExecutedToolSearchResultsResult>? ListType15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.CodeExecutionResult>? ListType16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.BrowserResult>? ListType17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ChatCompletionMessageToolCallChunk>? ListType18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ChatCompletionRequestMessage>? ListType19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.OneOf<string, global::System.Collections.Generic.List<string>>? ListType20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ChatCompletionTool>? ListType21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ChatCompletionFunctions>? ListType22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ChatCompletionDocument>? ListType23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.CreateChatCompletionResponseChoice>? ListType24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ChatCompletionTokenLogprob>? ListType25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.CreateChatCompletionResponseMcpListTool>? ListType26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.CreateChatCompletionResponseMcpListToolTool>? ListType27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<long>? ListType28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ChatCompletionTokenLogprobTopLogprob>? ListType29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.CreateChatCompletionStreamResponseChoice>? ListType30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ChatCompletionUsageBreakdownModel>? ListType31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ChartElement>? ListType33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>? ListType34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.Chart>? ListType35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.OneOf<global::System.Collections.Generic.List<double>, string>? ListType36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.Embedding>? ListType37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.File>? ListType38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ListFineTuningsResponseDataItem>? ListType39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.Model6>? ListType40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.RerankingResult>? ListType41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.OneOf<string, global::System.Collections.Generic.List<global::Groq.ResponseInputItem>>? ListType42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ResponseInputItem>? ListType43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ResponseTool>? ListType44 { get; set; }
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
        public global::System.Collections.Generic.List<global::Groq.ResponseOutputItem>? ListType47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ResponseOutputContent>? ListType48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Groq.ResponseAnnotation>? ListType49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType50 { get; set; }
    }
}
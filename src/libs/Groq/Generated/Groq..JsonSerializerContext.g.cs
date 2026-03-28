
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Groq
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Groq.JsonConverters.CreateSpeechRequestModelJsonConverter),

            typeof(global::Groq.JsonConverters.CreateSpeechRequestModelNullableJsonConverter),

            typeof(global::Groq.JsonConverters.CreateSpeechRequestResponseFormatJsonConverter),

            typeof(global::Groq.JsonConverters.CreateSpeechRequestResponseFormatNullableJsonConverter),

            typeof(global::Groq.JsonConverters.CreateTranscriptionRequestModelJsonConverter),

            typeof(global::Groq.JsonConverters.CreateTranscriptionRequestModelNullableJsonConverter),

            typeof(global::Groq.JsonConverters.CreateTranscriptionRequestLanguageJsonConverter),

            typeof(global::Groq.JsonConverters.CreateTranscriptionRequestLanguageNullableJsonConverter),

            typeof(global::Groq.JsonConverters.CreateTranscriptionRequestResponseFormatJsonConverter),

            typeof(global::Groq.JsonConverters.CreateTranscriptionRequestResponseFormatNullableJsonConverter),

            typeof(global::Groq.JsonConverters.CreateTranscriptionRequestTimestampGranularitieJsonConverter),

            typeof(global::Groq.JsonConverters.CreateTranscriptionRequestTimestampGranularitieNullableJsonConverter),

            typeof(global::Groq.JsonConverters.CreateTranslationRequestModelJsonConverter),

            typeof(global::Groq.JsonConverters.CreateTranslationRequestModelNullableJsonConverter),

            typeof(global::Groq.JsonConverters.CreateTranslationRequestResponseFormatJsonConverter),

            typeof(global::Groq.JsonConverters.CreateTranslationRequestResponseFormatNullableJsonConverter),

            typeof(global::Groq.JsonConverters.BatchObjectJsonConverter),

            typeof(global::Groq.JsonConverters.BatchObjectNullableJsonConverter),

            typeof(global::Groq.JsonConverters.BatchStatusJsonConverter),

            typeof(global::Groq.JsonConverters.BatchStatusNullableJsonConverter),

            typeof(global::Groq.JsonConverters.BatchRequestInputMethodJsonConverter),

            typeof(global::Groq.JsonConverters.BatchRequestInputMethodNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ListBatchesResponseObjectJsonConverter),

            typeof(global::Groq.JsonConverters.ListBatchesResponseObjectNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionRequestMessageContentPartDocumentTypeJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionRequestMessageContentPartDocumentTypeNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionDocumentSourceDiscriminatorTypeJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionDocumentSourceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionDocumentSourceTextTypeJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionDocumentSourceTextTypeNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionDocumentSourceJSONTypeJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionDocumentSourceJSONTypeNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionRequestMessageDiscriminatorRoleJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionRequestMessageDiscriminatorRoleNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionRequestSystemMessageRoleJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionRequestSystemMessageRoleNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionRequestUserMessageRoleJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionRequestUserMessageRoleNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionRequestAssistantMessageRoleJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionRequestAssistantMessageRoleNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionRequestToolMessageRoleJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionRequestToolMessageRoleNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionRequestFunctionMessageRoleJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionRequestFunctionMessageRoleNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionToolTypeJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionToolTypeNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionToolChoiceOptionEnumJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionToolChoiceOptionEnumNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionNamedToolChoiceTypeJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionNamedToolChoiceTypeNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionMessageToolCallTypeJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionMessageToolCallTypeNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionMessageToolCallChunkTypeJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionMessageToolCallChunkTypeNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionRoleJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionRoleNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionResponseMessageRoleJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionResponseMessageRoleNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionStreamResponseDeltaRoleJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionStreamResponseDeltaRoleNullableJsonConverter),

            typeof(global::Groq.JsonConverters.CreateChatCompletionRequestModelJsonConverter),

            typeof(global::Groq.JsonConverters.CreateChatCompletionRequestModelNullableJsonConverter),

            typeof(global::Groq.JsonConverters.CreateChatCompletionRequestServiceTierJsonConverter),

            typeof(global::Groq.JsonConverters.CreateChatCompletionRequestServiceTierNullableJsonConverter),

            typeof(global::Groq.JsonConverters.CreateChatCompletionRequestReasoningEffortJsonConverter),

            typeof(global::Groq.JsonConverters.CreateChatCompletionRequestReasoningEffortNullableJsonConverter),

            typeof(global::Groq.JsonConverters.CreateChatCompletionRequestReasoningFormatJsonConverter),

            typeof(global::Groq.JsonConverters.CreateChatCompletionRequestReasoningFormatNullableJsonConverter),

            typeof(global::Groq.JsonConverters.CreateChatCompletionRequestFunctionCallJsonConverter),

            typeof(global::Groq.JsonConverters.CreateChatCompletionRequestFunctionCallNullableJsonConverter),

            typeof(global::Groq.JsonConverters.CreateChatCompletionRequestCitationOptionsJsonConverter),

            typeof(global::Groq.JsonConverters.CreateChatCompletionRequestCitationOptionsNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseFormatJsonObjectTypeJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseFormatJsonObjectTypeNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseFormatJsonSchemaTypeJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseFormatJsonSchemaTypeNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseFormatTextTypeJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseFormatTextTypeNullableJsonConverter),

            typeof(global::Groq.JsonConverters.CreateChatCompletionResponseChoiceFinishReasonJsonConverter),

            typeof(global::Groq.JsonConverters.CreateChatCompletionResponseChoiceFinishReasonNullableJsonConverter),

            typeof(global::Groq.JsonConverters.CreateChatCompletionResponseObjectJsonConverter),

            typeof(global::Groq.JsonConverters.CreateChatCompletionResponseObjectNullableJsonConverter),

            typeof(global::Groq.JsonConverters.CreateChatCompletionResponseServiceTierJsonConverter),

            typeof(global::Groq.JsonConverters.CreateChatCompletionResponseServiceTierNullableJsonConverter),

            typeof(global::Groq.JsonConverters.CreateChatCompletionStreamResponseChoiceFinishReasonJsonConverter),

            typeof(global::Groq.JsonConverters.CreateChatCompletionStreamResponseChoiceFinishReasonNullableJsonConverter),

            typeof(global::Groq.JsonConverters.CreateChatCompletionStreamResponseObjectJsonConverter),

            typeof(global::Groq.JsonConverters.CreateChatCompletionStreamResponseObjectNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ChartTypeJsonConverter),

            typeof(global::Groq.JsonConverters.ChartTypeNullableJsonConverter),

            typeof(global::Groq.JsonConverters.AnnotationTypeJsonConverter),

            typeof(global::Groq.JsonConverters.AnnotationTypeNullableJsonConverter),

            typeof(global::Groq.JsonConverters.EmbeddingObjectJsonConverter),

            typeof(global::Groq.JsonConverters.EmbeddingObjectNullableJsonConverter),

            typeof(global::Groq.JsonConverters.CreateEmbeddingRequestModelJsonConverter),

            typeof(global::Groq.JsonConverters.CreateEmbeddingRequestModelNullableJsonConverter),

            typeof(global::Groq.JsonConverters.CreateEmbeddingRequestEncodingFormatJsonConverter),

            typeof(global::Groq.JsonConverters.CreateEmbeddingRequestEncodingFormatNullableJsonConverter),

            typeof(global::Groq.JsonConverters.CreateEmbeddingResponseObjectJsonConverter),

            typeof(global::Groq.JsonConverters.CreateEmbeddingResponseObjectNullableJsonConverter),

            typeof(global::Groq.JsonConverters.FileObjectJsonConverter),

            typeof(global::Groq.JsonConverters.FileObjectNullableJsonConverter),

            typeof(global::Groq.JsonConverters.FilePurposeJsonConverter),

            typeof(global::Groq.JsonConverters.FilePurposeNullableJsonConverter),

            typeof(global::Groq.JsonConverters.CreateFileRequestPurposeJsonConverter),

            typeof(global::Groq.JsonConverters.CreateFileRequestPurposeNullableJsonConverter),

            typeof(global::Groq.JsonConverters.DeleteFileResponseObjectJsonConverter),

            typeof(global::Groq.JsonConverters.DeleteFileResponseObjectNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ListFilesResponseObjectJsonConverter),

            typeof(global::Groq.JsonConverters.ListFilesResponseObjectNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ModelObjectJsonConverter),

            typeof(global::Groq.JsonConverters.ModelObjectNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ListModelsResponseObjectJsonConverter),

            typeof(global::Groq.JsonConverters.ListModelsResponseObjectNullableJsonConverter),

            typeof(global::Groq.JsonConverters.CreateResponseRequestModelJsonConverter),

            typeof(global::Groq.JsonConverters.CreateResponseRequestModelNullableJsonConverter),

            typeof(global::Groq.JsonConverters.CreateResponseRequestReasoningEffortJsonConverter),

            typeof(global::Groq.JsonConverters.CreateResponseRequestReasoningEffortNullableJsonConverter),

            typeof(global::Groq.JsonConverters.CreateResponseRequestServiceTierJsonConverter),

            typeof(global::Groq.JsonConverters.CreateResponseRequestServiceTierNullableJsonConverter),

            typeof(global::Groq.JsonConverters.CreateResponseRequestTruncationJsonConverter),

            typeof(global::Groq.JsonConverters.CreateResponseRequestTruncationNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseInputItemDiscriminatorTypeJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseInputItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseEasyInputMessageRoleJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseEasyInputMessageRoleNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseInputMessageTypeJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseInputMessageTypeNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseInputMessageRoleJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseInputMessageRoleNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseInputMessageStatusJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseInputMessageStatusNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseInputContentDiscriminatorTypeJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseInputContentDiscriminatorTypeNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseInputTextContentTypeJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseInputTextContentTypeNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseItemReferenceTypeJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseItemReferenceTypeNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseFunctionCallTypeJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseFunctionCallTypeNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseFunctionCallStatusJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseFunctionCallStatusNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseFunctionCallOutputTypeJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseFunctionCallOutputTypeNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseFunctionCallOutputStatusJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseFunctionCallOutputStatusNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseToolTypeJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseToolTypeNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseToolChoiceOptionEnumJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseToolChoiceOptionEnumNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseNamedToolChoiceTypeJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseNamedToolChoiceTypeNullableJsonConverter),

            typeof(global::Groq.JsonConverters.TextResponseFormatJsonSchemaTypeJsonConverter),

            typeof(global::Groq.JsonConverters.TextResponseFormatJsonSchemaTypeNullableJsonConverter),

            typeof(global::Groq.JsonConverters.CreateResponseResponseObjectJsonConverter),

            typeof(global::Groq.JsonConverters.CreateResponseResponseObjectNullableJsonConverter),

            typeof(global::Groq.JsonConverters.CreateResponseResponseStatusJsonConverter),

            typeof(global::Groq.JsonConverters.CreateResponseResponseStatusNullableJsonConverter),

            typeof(global::Groq.JsonConverters.CreateResponseResponseReasoningEffortJsonConverter),

            typeof(global::Groq.JsonConverters.CreateResponseResponseReasoningEffortNullableJsonConverter),

            typeof(global::Groq.JsonConverters.CreateResponseResponseTruncationJsonConverter),

            typeof(global::Groq.JsonConverters.CreateResponseResponseTruncationNullableJsonConverter),

            typeof(global::Groq.JsonConverters.CreateResponseResponseServiceTierJsonConverter),

            typeof(global::Groq.JsonConverters.CreateResponseResponseServiceTierNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseOutputItemDiscriminatorTypeJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseOutputItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseOutputMessageTypeJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseOutputMessageTypeNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseOutputMessageStatusJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseOutputMessageStatusNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseOutputMessageRoleJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseOutputMessageRoleNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseOutputContentDiscriminatorTypeJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseOutputContentDiscriminatorTypeNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseOutputTextContentTypeJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseOutputTextContentTypeNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseAnnotationDiscriminatorTypeJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseAnnotationDiscriminatorTypeNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseFileCitationTypeJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseFileCitationTypeNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseUrlCitationTypeJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseUrlCitationTypeNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseOutputFunctionCallTypeJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseOutputFunctionCallTypeNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseOutputFunctionCallStatusJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseOutputFunctionCallStatusNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseOutputReasoningTypeJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseOutputReasoningTypeNullableJsonConverter),

            typeof(global::Groq.JsonConverters.CreateBatchRequestEndpointJsonConverter),

            typeof(global::Groq.JsonConverters.CreateBatchRequestEndpointNullableJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionRequestMessageContentPartJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionDocumentSourceJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionRequestMessageJsonConverter),

            typeof(global::Groq.JsonConverters.ChatCompletionToolChoiceOptionJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseInputItemJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseInputContentJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseToolChoiceOptionJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseFormatConfigurationJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseOutputItemJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseOutputContentJsonConverter),

            typeof(global::Groq.JsonConverters.ResponseAnnotationJsonConverter),

            typeof(global::Groq.JsonConverters.AnyOfJsonConverter<string, global::Groq.CreateSpeechRequestModel?>),

            typeof(global::Groq.JsonConverters.AnyOfJsonConverter<string, global::Groq.CreateTranscriptionRequestModel?>),

            typeof(global::Groq.JsonConverters.AnyOfJsonConverter<string, global::Groq.CreateTranscriptionRequestLanguage?>),

            typeof(global::Groq.JsonConverters.AnyOfJsonConverter<string, global::Groq.CreateTranslationRequestModel?>),

            typeof(global::Groq.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Groq.ChatCompletionRequestMessageContentPartText>>),

            typeof(global::Groq.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Groq.ChatCompletionRequestMessageContentPart>>),

            typeof(global::Groq.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Groq.ChatCompletionRequestMessageContentPartText>>),

            typeof(global::Groq.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Groq.ChatCompletionRequestMessageContentPart>>),

            typeof(global::Groq.JsonConverters.AnyOfJsonConverter<global::Groq.ChatCompletionToolType?, string>),

            typeof(global::Groq.JsonConverters.AnyOfJsonConverter<string, global::Groq.CreateChatCompletionRequestModel?>),

            typeof(global::Groq.JsonConverters.OneOfJsonConverter<global::Groq.ResponseFormatText, global::Groq.ResponseFormatJsonSchema, global::Groq.ResponseFormatJsonObject>),

            typeof(global::Groq.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Groq.JsonConverters.OneOfJsonConverter<global::Groq.CreateChatCompletionRequestFunctionCall?, global::Groq.ChatCompletionFunctionCallOption>),

            typeof(global::Groq.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<double>, string>),

            typeof(global::Groq.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Groq.JsonConverters.AnyOfJsonConverter<string, global::Groq.CreateEmbeddingRequestModel?>),

            typeof(global::Groq.JsonConverters.AnyOfJsonConverter<string, global::Groq.CreateResponseRequestModel?>),

            typeof(global::Groq.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Groq.ResponseInputItem>>),

            typeof(global::Groq.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Groq.ResponseInputContent>>),

            typeof(global::Groq.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.DebugData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateSpeechRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.AnyOf<string, global::Groq.CreateSpeechRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateSpeechRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateSpeechRequestModel), TypeInfoPropertyName = "CreateSpeechRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateSpeechRequestResponseFormat), TypeInfoPropertyName = "CreateSpeechRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateTranscriptionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.AnyOf<string, global::Groq.CreateTranscriptionRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateTranscriptionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateTranscriptionRequestModel), TypeInfoPropertyName = "CreateTranscriptionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.AnyOf<string, global::Groq.CreateTranscriptionRequestLanguage?>), TypeInfoPropertyName = "AnyOfStringCreateTranscriptionRequestLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateTranscriptionRequestLanguage), TypeInfoPropertyName = "CreateTranscriptionRequestLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateTranscriptionRequestResponseFormat), TypeInfoPropertyName = "CreateTranscriptionRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.CreateTranscriptionRequestTimestampGranularitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateTranscriptionRequestTimestampGranularitie), TypeInfoPropertyName = "CreateTranscriptionRequestTimestampGranularitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateTranscriptionResponseJson))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.TranscriptionSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.TranscriptionWord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateTranscriptionResponseVerboseJson))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.TranscriptionWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.TranscriptionSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateTranslationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.AnyOf<string, global::Groq.CreateTranslationRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateTranslationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateTranslationRequestModel), TypeInfoPropertyName = "CreateTranslationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateTranslationRequestResponseFormat), TypeInfoPropertyName = "CreateTranslationRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateTranslationResponseJson))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateTranslationResponseVerboseJson))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.Batch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.BatchObject), TypeInfoPropertyName = "BatchObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.BatchErrors))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.BatchErrorsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.BatchErrorsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.BatchStatus), TypeInfoPropertyName = "BatchStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.BatchRequestCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.BatchRequestInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.BatchRequestInputMethod), TypeInfoPropertyName = "BatchRequestInputMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.BatchRequestOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.BatchRequestOutputResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.BatchRequestOutputError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ListBatchesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.Batch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ListBatchesResponseObject), TypeInfoPropertyName = "ListBatchesResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionRequestMessageContentPart), TypeInfoPropertyName = "ChatCompletionRequestMessageContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionRequestMessageContentPartText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionRequestMessageContentPartImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionRequestMessageContentPartDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionRequestMessageContentPartImageType), TypeInfoPropertyName = "ChatCompletionRequestMessageContentPartImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionRequestMessageContentPartImageImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionRequestMessageContentPartImageImageUrlDetail), TypeInfoPropertyName = "ChatCompletionRequestMessageContentPartImageImageUrlDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionRequestMessageContentPartTextType), TypeInfoPropertyName = "ChatCompletionRequestMessageContentPartTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionRequestMessageContentPartDocumentType), TypeInfoPropertyName = "ChatCompletionRequestMessageContentPartDocumentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionRequestMessageContentPartDocumentDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionDocumentSource), TypeInfoPropertyName = "ChatCompletionDocumentSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionDocumentSourceText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionDocumentSourceJSON))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionDocumentSourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionDocumentSourceDiscriminatorType), TypeInfoPropertyName = "ChatCompletionDocumentSourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionDocumentSourceTextType), TypeInfoPropertyName = "ChatCompletionDocumentSourceTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionDocumentSourceJSONType), TypeInfoPropertyName = "ChatCompletionDocumentSourceJSONType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionRequestMessage), TypeInfoPropertyName = "ChatCompletionRequestMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionRequestSystemMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionRequestUserMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionRequestAssistantMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionRequestToolMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionRequestFunctionMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionRequestMessageDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionRequestMessageDiscriminatorRole), TypeInfoPropertyName = "ChatCompletionRequestMessageDiscriminatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.OneOf<string, global::System.Collections.Generic.IList<global::Groq.ChatCompletionRequestMessageContentPartText>>), TypeInfoPropertyName = "OneOfStringIListChatCompletionRequestMessageContentPartText2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.ChatCompletionRequestMessageContentPartText>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionRequestSystemMessageRole), TypeInfoPropertyName = "ChatCompletionRequestSystemMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.OneOf<string, global::System.Collections.Generic.IList<global::Groq.ChatCompletionRequestMessageContentPart>>), TypeInfoPropertyName = "OneOfStringIListChatCompletionRequestMessageContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.ChatCompletionRequestMessageContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionRequestUserMessageRole), TypeInfoPropertyName = "ChatCompletionRequestUserMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionRequestAssistantMessageRole), TypeInfoPropertyName = "ChatCompletionRequestAssistantMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.ChatCompletionMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionRequestAssistantMessageFunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionRequestToolMessageRole), TypeInfoPropertyName = "ChatCompletionRequestToolMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionRequestFunctionMessageRole), TypeInfoPropertyName = "ChatCompletionRequestFunctionMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.FunctionParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionFunctions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionFunctionCallOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.AnyOf<global::Groq.ChatCompletionToolType?, string>), TypeInfoPropertyName = "AnyOfChatCompletionToolTypeString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionToolType), TypeInfoPropertyName = "ChatCompletionToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.FunctionObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionToolChoiceOption), TypeInfoPropertyName = "ChatCompletionToolChoiceOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionToolChoiceOptionEnum), TypeInfoPropertyName = "ChatCompletionToolChoiceOptionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionNamedToolChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionNamedToolChoiceType), TypeInfoPropertyName = "ChatCompletionNamedToolChoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionNamedToolChoiceFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionMessageToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionMessageToolCallType), TypeInfoPropertyName = "ChatCompletionMessageToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionMessageToolCallFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionMessageToolCallChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionMessageToolCallChunkType), TypeInfoPropertyName = "ChatCompletionMessageToolCallChunkType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionMessageToolCallChunkFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionRole), TypeInfoPropertyName = "ChatCompletionRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionStreamOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionResponseMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.ChatCompletionMessageExecutedTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionResponseMessageRole), TypeInfoPropertyName = "ChatCompletionResponseMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionResponseMessageFunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.Annotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.Annotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionMessageExecutedTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionMessageExecutedToolSearchResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.ChatCompletionMessageExecutedToolSearchResultsResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionMessageExecutedToolSearchResultsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.CodeExecutionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CodeExecutionResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.BrowserResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.BrowserResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionStreamResponseDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionStreamResponseDeltaFunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.ChatCompletionMessageToolCallChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionStreamResponseDeltaRole), TypeInfoPropertyName = "ChatCompletionStreamResponseDeltaRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateChatCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.ChatCompletionRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.AnyOf<string, global::Groq.CreateChatCompletionRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateChatCompletionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateChatCompletionRequestModel), TypeInfoPropertyName = "CreateChatCompletionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.OneOf<global::Groq.ResponseFormatText, global::Groq.ResponseFormatJsonSchema, global::Groq.ResponseFormatJsonObject>), TypeInfoPropertyName = "OneOfResponseFormatTextResponseFormatJsonSchemaResponseFormatJsonObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseFormatText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseFormatJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseFormatJsonObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateChatCompletionRequestServiceTier), TypeInfoPropertyName = "CreateChatCompletionRequestServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.OneOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateChatCompletionRequestReasoningEffort), TypeInfoPropertyName = "CreateChatCompletionRequestReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateChatCompletionRequestReasoningFormat), TypeInfoPropertyName = "CreateChatCompletionRequestReasoningFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.ChatCompletionTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.OneOf<global::Groq.CreateChatCompletionRequestFunctionCall?, global::Groq.ChatCompletionFunctionCallOption>), TypeInfoPropertyName = "OneOfCreateChatCompletionRequestFunctionCallChatCompletionFunctionCallOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateChatCompletionRequestFunctionCall), TypeInfoPropertyName = "CreateChatCompletionRequestFunctionCall2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.ChatCompletionFunctions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateChatCompletionRequestSearchSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateChatCompletionRequestCompoundCustom))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateChatCompletionRequestCompoundCustomModels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateChatCompletionRequestCompoundCustomTools))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateChatCompletionRequestCompoundCustomToolsWolframSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.ChatCompletionDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateChatCompletionRequestCitationOptions), TypeInfoPropertyName = "CreateChatCompletionRequestCitationOptions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseFormatJsonObjectType), TypeInfoPropertyName = "ResponseFormatJsonObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseFormatJsonSchemaType), TypeInfoPropertyName = "ResponseFormatJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseFormatJsonSchemaJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseFormatJsonSchemaSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseFormatTextType), TypeInfoPropertyName = "ResponseFormatTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateChatCompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.CreateChatCompletionResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateChatCompletionResponseChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateChatCompletionResponseChoiceFinishReason), TypeInfoPropertyName = "CreateChatCompletionResponseChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateChatCompletionResponseChoiceLogprobs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.ChatCompletionTokenLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionTokenLogprob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateChatCompletionResponseObject), TypeInfoPropertyName = "CreateChatCompletionResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CompletionUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionUsageBreakdown))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateChatCompletionResponseServiceTier), TypeInfoPropertyName = "CreateChatCompletionResponseServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.CreateChatCompletionResponseMcpListTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateChatCompletionResponseMcpListTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.CreateChatCompletionResponseMcpListToolTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateChatCompletionResponseMcpListToolTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.XGroqNonStreaming))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.ChatCompletionTokenLogprobTopLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionTokenLogprobTopLogprob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.XGroqNonStreamingUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.XGroq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateChatCompletionStreamResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.CreateChatCompletionStreamResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateChatCompletionStreamResponseChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateChatCompletionStreamResponseChoiceLogprobs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateChatCompletionStreamResponseChoiceFinishReason), TypeInfoPropertyName = "CreateChatCompletionStreamResponseChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateChatCompletionStreamResponseObject), TypeInfoPropertyName = "CreateChatCompletionStreamResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CompletionUsagePromptTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CompletionUsageCompletionTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.ChatCompletionUsageBreakdownModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChatCompletionUsageBreakdownModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.Chart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChartType), TypeInfoPropertyName = "ChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.ChartElement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ChartElement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.Chart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.AnnotationType), TypeInfoPropertyName = "AnnotationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.DocumentCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.FunctionCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.Embedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.OneOf<global::System.Collections.Generic.IList<double>, string>), TypeInfoPropertyName = "OneOfIListDoubleString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.EmbeddingObject), TypeInfoPropertyName = "EmbeddingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateEmbeddingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.AnyOf<string, global::Groq.CreateEmbeddingRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateEmbeddingRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateEmbeddingRequestModel), TypeInfoPropertyName = "CreateEmbeddingRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateEmbeddingRequestEncodingFormat), TypeInfoPropertyName = "CreateEmbeddingRequestEncodingFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateEmbeddingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.Embedding>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateEmbeddingResponseObject), TypeInfoPropertyName = "CreateEmbeddingResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateEmbeddingResponseUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.File))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.FileObject), TypeInfoPropertyName = "FileObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.FilePurpose), TypeInfoPropertyName = "FilePurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateFileRequestPurpose), TypeInfoPropertyName = "CreateFileRequestPurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.DeleteFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.DeleteFileResponseObject), TypeInfoPropertyName = "DeleteFileResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ListFilesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ListFilesResponseObject), TypeInfoPropertyName = "ListFilesResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.File>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateFineTuningRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.DeleteFineTuningResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ListFineTuningsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.ListFineTuningsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ListFineTuningsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ReadFineTuningResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ReadFineTuningResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.Model6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ModelObject), TypeInfoPropertyName = "ModelObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ListModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ListModelsResponseObject), TypeInfoPropertyName = "ListModelsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.Model6>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.DeleteModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.RerankingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.RerankingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.RerankingResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.RerankingResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateResponseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.AnyOf<string, global::Groq.CreateResponseRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateResponseRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateResponseRequestModel), TypeInfoPropertyName = "CreateResponseRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.OneOf<string, global::System.Collections.Generic.IList<global::Groq.ResponseInputItem>>), TypeInfoPropertyName = "OneOfStringIListResponseInputItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.ResponseInputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseInputItem), TypeInfoPropertyName = "ResponseInputItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.ResponseTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseToolChoiceOption), TypeInfoPropertyName = "ResponseToolChoiceOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateResponseRequestText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseFormatConfiguration), TypeInfoPropertyName = "ResponseFormatConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateResponseRequestReasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateResponseRequestReasoningEffort), TypeInfoPropertyName = "CreateResponseRequestReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateResponseRequestServiceTier), TypeInfoPropertyName = "CreateResponseRequestServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateResponseRequestTruncation), TypeInfoPropertyName = "CreateResponseRequestTruncation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseEasyInputMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseInputMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseItemReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseFunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseFunctionCallOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseInputItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseInputItemDiscriminatorType), TypeInfoPropertyName = "ResponseInputItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseEasyInputMessageRole), TypeInfoPropertyName = "ResponseEasyInputMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.OneOf<string, global::System.Collections.Generic.IList<global::Groq.ResponseInputContent>>), TypeInfoPropertyName = "OneOfStringIListResponseInputContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.ResponseInputContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseInputContent), TypeInfoPropertyName = "ResponseInputContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseInputMessageType), TypeInfoPropertyName = "ResponseInputMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseInputMessageRole), TypeInfoPropertyName = "ResponseInputMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseInputMessageStatus), TypeInfoPropertyName = "ResponseInputMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseInputTextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseInputContentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseInputContentDiscriminatorType), TypeInfoPropertyName = "ResponseInputContentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseInputTextContentType), TypeInfoPropertyName = "ResponseInputTextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseItemReferenceType), TypeInfoPropertyName = "ResponseItemReferenceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseFunctionCallType), TypeInfoPropertyName = "ResponseFunctionCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseFunctionCallStatus), TypeInfoPropertyName = "ResponseFunctionCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseFunctionCallOutputType), TypeInfoPropertyName = "ResponseFunctionCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseFunctionCallOutputStatus), TypeInfoPropertyName = "ResponseFunctionCallOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseToolType), TypeInfoPropertyName = "ResponseToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseToolChoiceOptionEnum), TypeInfoPropertyName = "ResponseToolChoiceOptionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseNamedToolChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseNamedToolChoiceType), TypeInfoPropertyName = "ResponseNamedToolChoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseNamedToolChoiceFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.TextResponseFormatJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.TextResponseFormatJsonSchemaType), TypeInfoPropertyName = "TextResponseFormatJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateResponseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateResponseResponseObject), TypeInfoPropertyName = "CreateResponseResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateResponseResponseStatus), TypeInfoPropertyName = "CreateResponseResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.ResponseOutputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseOutputItem), TypeInfoPropertyName = "ResponseOutputItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateResponseResponseReasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateResponseResponseReasoningEffort), TypeInfoPropertyName = "CreateResponseResponseReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateResponseResponseText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateResponseResponseTruncation), TypeInfoPropertyName = "CreateResponseResponseTruncation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateResponseResponseServiceTier), TypeInfoPropertyName = "CreateResponseResponseServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateResponseResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateResponseResponseIncompleteDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseOutputMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseOutputFunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseOutputReasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseOutputItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseOutputItemDiscriminatorType), TypeInfoPropertyName = "ResponseOutputItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseOutputMessageType), TypeInfoPropertyName = "ResponseOutputMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseOutputMessageStatus), TypeInfoPropertyName = "ResponseOutputMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseOutputMessageRole), TypeInfoPropertyName = "ResponseOutputMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.ResponseOutputContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseOutputContent), TypeInfoPropertyName = "ResponseOutputContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseOutputTextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseOutputContentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseOutputContentDiscriminatorType), TypeInfoPropertyName = "ResponseOutputContentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseOutputTextContentType), TypeInfoPropertyName = "ResponseOutputTextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.ResponseAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseAnnotation), TypeInfoPropertyName = "ResponseAnnotation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseFileCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseUrlCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseAnnotationDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseAnnotationDiscriminatorType), TypeInfoPropertyName = "ResponseAnnotationDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseFileCitationType), TypeInfoPropertyName = "ResponseFileCitationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseUrlCitationType), TypeInfoPropertyName = "ResponseUrlCitationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseOutputFunctionCallType), TypeInfoPropertyName = "ResponseOutputFunctionCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseOutputFunctionCallStatus), TypeInfoPropertyName = "ResponseOutputFunctionCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseOutputReasoningType), TypeInfoPropertyName = "ResponseOutputReasoningType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseUsageInputTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseUsageOutputTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateBatchRequestEndpoint), TypeInfoPropertyName = "CreateBatchRequestEndpoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.CreateTranscriptionRequestTimestampGranularitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.TranscriptionWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.TranscriptionSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.BatchErrorsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.Batch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.OneOf<string, global::System.Collections.Generic.List<global::Groq.ChatCompletionRequestMessageContentPartText>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.ChatCompletionRequestMessageContentPartText>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.OneOf<string, global::System.Collections.Generic.List<global::Groq.ChatCompletionRequestMessageContentPart>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.ChatCompletionRequestMessageContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.ChatCompletionMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.ChatCompletionMessageExecutedTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.Annotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.ChatCompletionMessageExecutedToolSearchResultsResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.CodeExecutionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.BrowserResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.ChatCompletionMessageToolCallChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.ChatCompletionRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.ChatCompletionTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.ChatCompletionFunctions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.ChatCompletionDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.CreateChatCompletionResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.ChatCompletionTokenLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.CreateChatCompletionResponseMcpListTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.CreateChatCompletionResponseMcpListToolTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.ChatCompletionTokenLogprobTopLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.CreateChatCompletionStreamResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.ChatCompletionUsageBreakdownModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.ChartElement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.Chart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.OneOf<global::System.Collections.Generic.List<double>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.Embedding>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.File>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.ListFineTuningsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.Model6>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.RerankingResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.OneOf<string, global::System.Collections.Generic.List<global::Groq.ResponseInputItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.ResponseInputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.ResponseTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.OneOf<string, global::System.Collections.Generic.List<global::Groq.ResponseInputContent>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.ResponseInputContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.ResponseOutputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.ResponseOutputContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.ResponseAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}
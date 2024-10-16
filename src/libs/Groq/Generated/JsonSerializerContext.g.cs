
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
            typeof(global::Groq.JsonConverters.ChatCompletionMessageToolCallTypeJsonConverter),
            typeof(global::Groq.JsonConverters.ChatCompletionMessageToolCallTypeNullableJsonConverter),
            typeof(global::Groq.JsonConverters.ChatCompletionMessageToolCallChunkTypeJsonConverter),
            typeof(global::Groq.JsonConverters.ChatCompletionMessageToolCallChunkTypeNullableJsonConverter),
            typeof(global::Groq.JsonConverters.ChatCompletionNamedToolChoiceTypeJsonConverter),
            typeof(global::Groq.JsonConverters.ChatCompletionNamedToolChoiceTypeNullableJsonConverter),
            typeof(global::Groq.JsonConverters.ChatCompletionRequestAssistantMessageRoleJsonConverter),
            typeof(global::Groq.JsonConverters.ChatCompletionRequestAssistantMessageRoleNullableJsonConverter),
            typeof(global::Groq.JsonConverters.ChatCompletionRequestFunctionMessageRoleJsonConverter),
            typeof(global::Groq.JsonConverters.ChatCompletionRequestFunctionMessageRoleNullableJsonConverter),
            typeof(global::Groq.JsonConverters.ChatCompletionRequestMessageDiscriminatorRoleJsonConverter),
            typeof(global::Groq.JsonConverters.ChatCompletionRequestMessageDiscriminatorRoleNullableJsonConverter),
            typeof(global::Groq.JsonConverters.ChatCompletionRequestSystemMessageRoleJsonConverter),
            typeof(global::Groq.JsonConverters.ChatCompletionRequestSystemMessageRoleNullableJsonConverter),
            typeof(global::Groq.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeJsonConverter),
            typeof(global::Groq.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeNullableJsonConverter),
            typeof(global::Groq.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailJsonConverter),
            typeof(global::Groq.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailNullableJsonConverter),
            typeof(global::Groq.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeJsonConverter),
            typeof(global::Groq.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeNullableJsonConverter),
            typeof(global::Groq.JsonConverters.ChatCompletionRequestUserMessageRoleJsonConverter),
            typeof(global::Groq.JsonConverters.ChatCompletionRequestUserMessageRoleNullableJsonConverter),
            typeof(global::Groq.JsonConverters.ChatCompletionRequestToolMessageRoleJsonConverter),
            typeof(global::Groq.JsonConverters.ChatCompletionRequestToolMessageRoleNullableJsonConverter),
            typeof(global::Groq.JsonConverters.ChatCompletionResponseMessageRoleJsonConverter),
            typeof(global::Groq.JsonConverters.ChatCompletionResponseMessageRoleNullableJsonConverter),
            typeof(global::Groq.JsonConverters.ChatCompletionRoleJsonConverter),
            typeof(global::Groq.JsonConverters.ChatCompletionRoleNullableJsonConverter),
            typeof(global::Groq.JsonConverters.ChatCompletionStreamResponseDeltaRoleJsonConverter),
            typeof(global::Groq.JsonConverters.ChatCompletionStreamResponseDeltaRoleNullableJsonConverter),
            typeof(global::Groq.JsonConverters.ChatCompletionToolTypeJsonConverter),
            typeof(global::Groq.JsonConverters.ChatCompletionToolTypeNullableJsonConverter),
            typeof(global::Groq.JsonConverters.ChatCompletionToolChoiceOptionEnumJsonConverter),
            typeof(global::Groq.JsonConverters.ChatCompletionToolChoiceOptionEnumNullableJsonConverter),
            typeof(global::Groq.JsonConverters.CreateChatCompletionRequestFunctionCallJsonConverter),
            typeof(global::Groq.JsonConverters.CreateChatCompletionRequestFunctionCallNullableJsonConverter),
            typeof(global::Groq.JsonConverters.CreateChatCompletionRequestModelJsonConverter),
            typeof(global::Groq.JsonConverters.CreateChatCompletionRequestModelNullableJsonConverter),
            typeof(global::Groq.JsonConverters.CreateChatCompletionRequestResponseFormatTypeJsonConverter),
            typeof(global::Groq.JsonConverters.CreateChatCompletionRequestResponseFormatTypeNullableJsonConverter),
            typeof(global::Groq.JsonConverters.CreateChatCompletionResponseChoiceFinishReasonJsonConverter),
            typeof(global::Groq.JsonConverters.CreateChatCompletionResponseChoiceFinishReasonNullableJsonConverter),
            typeof(global::Groq.JsonConverters.CreateChatCompletionResponseObjectJsonConverter),
            typeof(global::Groq.JsonConverters.CreateChatCompletionResponseObjectNullableJsonConverter),
            typeof(global::Groq.JsonConverters.CreateChatCompletionStreamResponseChoiceFinishReasonJsonConverter),
            typeof(global::Groq.JsonConverters.CreateChatCompletionStreamResponseChoiceFinishReasonNullableJsonConverter),
            typeof(global::Groq.JsonConverters.CreateChatCompletionStreamResponseObjectJsonConverter),
            typeof(global::Groq.JsonConverters.CreateChatCompletionStreamResponseObjectNullableJsonConverter),
            typeof(global::Groq.JsonConverters.CreateEmbeddingRequestEncodingFormatJsonConverter),
            typeof(global::Groq.JsonConverters.CreateEmbeddingRequestEncodingFormatNullableJsonConverter),
            typeof(global::Groq.JsonConverters.CreateEmbeddingRequestModelJsonConverter),
            typeof(global::Groq.JsonConverters.CreateEmbeddingRequestModelNullableJsonConverter),
            typeof(global::Groq.JsonConverters.EmbeddingObjectJsonConverter),
            typeof(global::Groq.JsonConverters.EmbeddingObjectNullableJsonConverter),
            typeof(global::Groq.JsonConverters.CreateEmbeddingResponseObjectJsonConverter),
            typeof(global::Groq.JsonConverters.CreateEmbeddingResponseObjectNullableJsonConverter),
            typeof(global::Groq.JsonConverters.CreateTranscriptionRequestLanguageJsonConverter),
            typeof(global::Groq.JsonConverters.CreateTranscriptionRequestLanguageNullableJsonConverter),
            typeof(global::Groq.JsonConverters.CreateTranscriptionRequestModelJsonConverter),
            typeof(global::Groq.JsonConverters.CreateTranscriptionRequestModelNullableJsonConverter),
            typeof(global::Groq.JsonConverters.CreateTranscriptionRequestResponseFormatJsonConverter),
            typeof(global::Groq.JsonConverters.CreateTranscriptionRequestResponseFormatNullableJsonConverter),
            typeof(global::Groq.JsonConverters.CreateTranscriptionRequestTimestampGranularitieJsonConverter),
            typeof(global::Groq.JsonConverters.CreateTranscriptionRequestTimestampGranularitieNullableJsonConverter),
            typeof(global::Groq.JsonConverters.CreateTranslationRequestModelJsonConverter),
            typeof(global::Groq.JsonConverters.CreateTranslationRequestModelNullableJsonConverter),
            typeof(global::Groq.JsonConverters.CreateTranslationRequestResponseFormatJsonConverter),
            typeof(global::Groq.JsonConverters.CreateTranslationRequestResponseFormatNullableJsonConverter),
            typeof(global::Groq.JsonConverters.ModelObjectJsonConverter),
            typeof(global::Groq.JsonConverters.ModelObjectNullableJsonConverter),
            typeof(global::Groq.JsonConverters.ListModelsResponseObjectJsonConverter),
            typeof(global::Groq.JsonConverters.ListModelsResponseObjectNullableJsonConverter),
            typeof(global::Groq.JsonConverters.ChatCompletionRequestMessageJsonConverter),
            typeof(global::Groq.JsonConverters.OneOfJsonConverterFactory2),
            typeof(global::Groq.JsonConverters.ChatCompletionRequestMessageContentPartJsonConverter),
            typeof(global::Groq.JsonConverters.ChatCompletionToolChoiceOptionJsonConverter),
            typeof(global::Groq.JsonConverters.AnyOfJsonConverterFactory2),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}
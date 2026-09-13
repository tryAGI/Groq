
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
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.FunctionParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseFormatText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseFormatJsonObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseFormatJsonObjectType), TypeInfoPropertyName = "ResponseFormatJsonObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseFormatTextType), TypeInfoPropertyName = "ResponseFormatTextType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseFormatJsonObjectType?), TypeInfoPropertyName = "NullableResponseFormatJsonObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseFormatTextType?), TypeInfoPropertyName = "NullableResponseFormatTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.AnyOf<string, global::Groq.CreateResponseRequestModel?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateResponseRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateResponseRequestModel?), TypeInfoPropertyName = "NullableCreateResponseRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.OneOf<string, global::System.Collections.Generic.IList<global::Groq.ResponseInputItem>>?), TypeInfoPropertyName = "NullableOneOfStringIListResponseInputItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseInputItem?), TypeInfoPropertyName = "NullableResponseInputItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseToolChoiceOption?), TypeInfoPropertyName = "NullableResponseToolChoiceOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseFormatConfiguration?), TypeInfoPropertyName = "NullableResponseFormatConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateResponseRequestReasoningEffort?), TypeInfoPropertyName = "NullableCreateResponseRequestReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateResponseRequestServiceTier?), TypeInfoPropertyName = "NullableCreateResponseRequestServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateResponseRequestTruncation?), TypeInfoPropertyName = "NullableCreateResponseRequestTruncation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseInputItemDiscriminatorType?), TypeInfoPropertyName = "NullableResponseInputItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseEasyInputMessageRole?), TypeInfoPropertyName = "NullableResponseEasyInputMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.OneOf<string, global::System.Collections.Generic.IList<global::Groq.ResponseInputContent>>?), TypeInfoPropertyName = "NullableOneOfStringIListResponseInputContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseInputContent?), TypeInfoPropertyName = "NullableResponseInputContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseInputMessageType?), TypeInfoPropertyName = "NullableResponseInputMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseInputMessageRole?), TypeInfoPropertyName = "NullableResponseInputMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseInputMessageStatus?), TypeInfoPropertyName = "NullableResponseInputMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseInputContentDiscriminatorType?), TypeInfoPropertyName = "NullableResponseInputContentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseInputTextContentType?), TypeInfoPropertyName = "NullableResponseInputTextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseItemReferenceType?), TypeInfoPropertyName = "NullableResponseItemReferenceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseFunctionCallType?), TypeInfoPropertyName = "NullableResponseFunctionCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseFunctionCallStatus?), TypeInfoPropertyName = "NullableResponseFunctionCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseFunctionCallOutputType?), TypeInfoPropertyName = "NullableResponseFunctionCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseFunctionCallOutputStatus?), TypeInfoPropertyName = "NullableResponseFunctionCallOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseToolType?), TypeInfoPropertyName = "NullableResponseToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseToolChoiceOptionEnum?), TypeInfoPropertyName = "NullableResponseToolChoiceOptionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseNamedToolChoiceType?), TypeInfoPropertyName = "NullableResponseNamedToolChoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.TextResponseFormatJsonSchemaType?), TypeInfoPropertyName = "NullableTextResponseFormatJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateResponseResponseObject?), TypeInfoPropertyName = "NullableCreateResponseResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateResponseResponseStatus?), TypeInfoPropertyName = "NullableCreateResponseResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseOutputItem?), TypeInfoPropertyName = "NullableResponseOutputItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateResponseResponseReasoningEffort?), TypeInfoPropertyName = "NullableCreateResponseResponseReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateResponseResponseTruncation?), TypeInfoPropertyName = "NullableCreateResponseResponseTruncation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateResponseResponseServiceTier?), TypeInfoPropertyName = "NullableCreateResponseResponseServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseOutputItemDiscriminatorType?), TypeInfoPropertyName = "NullableResponseOutputItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseOutputMessageType?), TypeInfoPropertyName = "NullableResponseOutputMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseOutputMessageStatus?), TypeInfoPropertyName = "NullableResponseOutputMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseOutputMessageRole?), TypeInfoPropertyName = "NullableResponseOutputMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseOutputContent?), TypeInfoPropertyName = "NullableResponseOutputContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseOutputContentDiscriminatorType?), TypeInfoPropertyName = "NullableResponseOutputContentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseOutputTextContentType?), TypeInfoPropertyName = "NullableResponseOutputTextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseAnnotation?), TypeInfoPropertyName = "NullableResponseAnnotation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseAnnotationDiscriminatorType?), TypeInfoPropertyName = "NullableResponseAnnotationDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseFileCitationType?), TypeInfoPropertyName = "NullableResponseFileCitationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseUrlCitationType?), TypeInfoPropertyName = "NullableResponseUrlCitationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseOutputFunctionCallType?), TypeInfoPropertyName = "NullableResponseOutputFunctionCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseOutputFunctionCallStatus?), TypeInfoPropertyName = "NullableResponseOutputFunctionCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.ResponseOutputReasoningType?), TypeInfoPropertyName = "NullableResponseOutputReasoningType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.OneOf<string, global::System.Collections.Generic.List<global::Groq.ResponseInputItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.ResponseInputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.ResponseTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.OneOf<string, global::System.Collections.Generic.List<global::Groq.ResponseInputContent>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.ResponseInputContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.ResponseOutputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.ResponseOutputContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.ResponseAnnotation>))]
    internal sealed partial class ResponsesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResponsesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ResponsesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ResponsesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Groq.JsonConverters.ResponseInputItemJsonConverter());
            options.Converters.Add(new global::Groq.JsonConverters.ResponseInputContentJsonConverter());
            options.Converters.Add(new global::Groq.JsonConverters.ResponseToolChoiceOptionJsonConverter());
            options.Converters.Add(new global::Groq.JsonConverters.ResponseFormatConfigurationJsonConverter());
            options.Converters.Add(new global::Groq.JsonConverters.ResponseOutputItemJsonConverter());
            options.Converters.Add(new global::Groq.JsonConverters.ResponseOutputContentJsonConverter());
            options.Converters.Add(new global::Groq.JsonConverters.ResponseAnnotationJsonConverter());
            options.Converters.Add(new global::Groq.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Groq.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<double>, string>());
            options.Converters.Add(new global::Groq.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Groq.JsonConverters.AnyOfJsonConverter<string, global::Groq.CreateResponseRequestModel?>());
            options.Converters.Add(new global::Groq.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Groq.ResponseInputItem>>());
            options.Converters.Add(new global::Groq.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Groq.ResponseInputContent>>());
            options.Converters.Add(new global::Groq.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Groq.ResponseFormatJsonObjectType)

                    || typeToConvert == typeof(global::Groq.ResponseFormatJsonObjectType?)

                    || typeToConvert == typeof(global::Groq.ResponseFormatTextType)

                    || typeToConvert == typeof(global::Groq.ResponseFormatTextType?)

                    || typeToConvert == typeof(global::Groq.CreateResponseRequestModel)

                    || typeToConvert == typeof(global::Groq.CreateResponseRequestModel?)

                    || typeToConvert == typeof(global::Groq.CreateResponseRequestReasoningEffort)

                    || typeToConvert == typeof(global::Groq.CreateResponseRequestReasoningEffort?)

                    || typeToConvert == typeof(global::Groq.CreateResponseRequestServiceTier)

                    || typeToConvert == typeof(global::Groq.CreateResponseRequestServiceTier?)

                    || typeToConvert == typeof(global::Groq.CreateResponseRequestTruncation)

                    || typeToConvert == typeof(global::Groq.CreateResponseRequestTruncation?)

                    || typeToConvert == typeof(global::Groq.ResponseInputItemDiscriminatorType)

                    || typeToConvert == typeof(global::Groq.ResponseInputItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Groq.ResponseEasyInputMessageRole)

                    || typeToConvert == typeof(global::Groq.ResponseEasyInputMessageRole?)

                    || typeToConvert == typeof(global::Groq.ResponseInputMessageType)

                    || typeToConvert == typeof(global::Groq.ResponseInputMessageType?)

                    || typeToConvert == typeof(global::Groq.ResponseInputMessageRole)

                    || typeToConvert == typeof(global::Groq.ResponseInputMessageRole?)

                    || typeToConvert == typeof(global::Groq.ResponseInputMessageStatus)

                    || typeToConvert == typeof(global::Groq.ResponseInputMessageStatus?)

                    || typeToConvert == typeof(global::Groq.ResponseInputContentDiscriminatorType)

                    || typeToConvert == typeof(global::Groq.ResponseInputContentDiscriminatorType?)

                    || typeToConvert == typeof(global::Groq.ResponseInputTextContentType)

                    || typeToConvert == typeof(global::Groq.ResponseInputTextContentType?)

                    || typeToConvert == typeof(global::Groq.ResponseItemReferenceType)

                    || typeToConvert == typeof(global::Groq.ResponseItemReferenceType?)

                    || typeToConvert == typeof(global::Groq.ResponseFunctionCallType)

                    || typeToConvert == typeof(global::Groq.ResponseFunctionCallType?)

                    || typeToConvert == typeof(global::Groq.ResponseFunctionCallStatus)

                    || typeToConvert == typeof(global::Groq.ResponseFunctionCallStatus?)

                    || typeToConvert == typeof(global::Groq.ResponseFunctionCallOutputType)

                    || typeToConvert == typeof(global::Groq.ResponseFunctionCallOutputType?)

                    || typeToConvert == typeof(global::Groq.ResponseFunctionCallOutputStatus)

                    || typeToConvert == typeof(global::Groq.ResponseFunctionCallOutputStatus?)

                    || typeToConvert == typeof(global::Groq.ResponseToolType)

                    || typeToConvert == typeof(global::Groq.ResponseToolType?)

                    || typeToConvert == typeof(global::Groq.ResponseToolChoiceOptionEnum)

                    || typeToConvert == typeof(global::Groq.ResponseToolChoiceOptionEnum?)

                    || typeToConvert == typeof(global::Groq.ResponseNamedToolChoiceType)

                    || typeToConvert == typeof(global::Groq.ResponseNamedToolChoiceType?)

                    || typeToConvert == typeof(global::Groq.TextResponseFormatJsonSchemaType)

                    || typeToConvert == typeof(global::Groq.TextResponseFormatJsonSchemaType?)

                    || typeToConvert == typeof(global::Groq.CreateResponseResponseObject)

                    || typeToConvert == typeof(global::Groq.CreateResponseResponseObject?)

                    || typeToConvert == typeof(global::Groq.CreateResponseResponseStatus)

                    || typeToConvert == typeof(global::Groq.CreateResponseResponseStatus?)

                    || typeToConvert == typeof(global::Groq.CreateResponseResponseReasoningEffort)

                    || typeToConvert == typeof(global::Groq.CreateResponseResponseReasoningEffort?)

                    || typeToConvert == typeof(global::Groq.CreateResponseResponseTruncation)

                    || typeToConvert == typeof(global::Groq.CreateResponseResponseTruncation?)

                    || typeToConvert == typeof(global::Groq.CreateResponseResponseServiceTier)

                    || typeToConvert == typeof(global::Groq.CreateResponseResponseServiceTier?)

                    || typeToConvert == typeof(global::Groq.ResponseOutputItemDiscriminatorType)

                    || typeToConvert == typeof(global::Groq.ResponseOutputItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Groq.ResponseOutputMessageType)

                    || typeToConvert == typeof(global::Groq.ResponseOutputMessageType?)

                    || typeToConvert == typeof(global::Groq.ResponseOutputMessageStatus)

                    || typeToConvert == typeof(global::Groq.ResponseOutputMessageStatus?)

                    || typeToConvert == typeof(global::Groq.ResponseOutputMessageRole)

                    || typeToConvert == typeof(global::Groq.ResponseOutputMessageRole?)

                    || typeToConvert == typeof(global::Groq.ResponseOutputContentDiscriminatorType)

                    || typeToConvert == typeof(global::Groq.ResponseOutputContentDiscriminatorType?)

                    || typeToConvert == typeof(global::Groq.ResponseOutputTextContentType)

                    || typeToConvert == typeof(global::Groq.ResponseOutputTextContentType?)

                    || typeToConvert == typeof(global::Groq.ResponseAnnotationDiscriminatorType)

                    || typeToConvert == typeof(global::Groq.ResponseAnnotationDiscriminatorType?)

                    || typeToConvert == typeof(global::Groq.ResponseFileCitationType)

                    || typeToConvert == typeof(global::Groq.ResponseFileCitationType?)

                    || typeToConvert == typeof(global::Groq.ResponseUrlCitationType)

                    || typeToConvert == typeof(global::Groq.ResponseUrlCitationType?)

                    || typeToConvert == typeof(global::Groq.ResponseOutputFunctionCallType)

                    || typeToConvert == typeof(global::Groq.ResponseOutputFunctionCallType?)

                    || typeToConvert == typeof(global::Groq.ResponseOutputFunctionCallStatus)

                    || typeToConvert == typeof(global::Groq.ResponseOutputFunctionCallStatus?)

                    || typeToConvert == typeof(global::Groq.ResponseOutputReasoningType)

                    || typeToConvert == typeof(global::Groq.ResponseOutputReasoningType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Groq.ResponseFormatJsonObjectType))
                {
                    return new global::Groq.JsonConverters.ResponseFormatJsonObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseFormatJsonObjectType?))
                {
                    return new global::Groq.JsonConverters.ResponseFormatJsonObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseFormatTextType))
                {
                    return new global::Groq.JsonConverters.ResponseFormatTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseFormatTextType?))
                {
                    return new global::Groq.JsonConverters.ResponseFormatTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateResponseRequestModel))
                {
                    return new global::Groq.JsonConverters.CreateResponseRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateResponseRequestModel?))
                {
                    return new global::Groq.JsonConverters.CreateResponseRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateResponseRequestReasoningEffort))
                {
                    return new global::Groq.JsonConverters.CreateResponseRequestReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateResponseRequestReasoningEffort?))
                {
                    return new global::Groq.JsonConverters.CreateResponseRequestReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateResponseRequestServiceTier))
                {
                    return new global::Groq.JsonConverters.CreateResponseRequestServiceTierJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateResponseRequestServiceTier?))
                {
                    return new global::Groq.JsonConverters.CreateResponseRequestServiceTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateResponseRequestTruncation))
                {
                    return new global::Groq.JsonConverters.CreateResponseRequestTruncationJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateResponseRequestTruncation?))
                {
                    return new global::Groq.JsonConverters.CreateResponseRequestTruncationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseInputItemDiscriminatorType))
                {
                    return new global::Groq.JsonConverters.ResponseInputItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseInputItemDiscriminatorType?))
                {
                    return new global::Groq.JsonConverters.ResponseInputItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseEasyInputMessageRole))
                {
                    return new global::Groq.JsonConverters.ResponseEasyInputMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseEasyInputMessageRole?))
                {
                    return new global::Groq.JsonConverters.ResponseEasyInputMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseInputMessageType))
                {
                    return new global::Groq.JsonConverters.ResponseInputMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseInputMessageType?))
                {
                    return new global::Groq.JsonConverters.ResponseInputMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseInputMessageRole))
                {
                    return new global::Groq.JsonConverters.ResponseInputMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseInputMessageRole?))
                {
                    return new global::Groq.JsonConverters.ResponseInputMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseInputMessageStatus))
                {
                    return new global::Groq.JsonConverters.ResponseInputMessageStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseInputMessageStatus?))
                {
                    return new global::Groq.JsonConverters.ResponseInputMessageStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseInputContentDiscriminatorType))
                {
                    return new global::Groq.JsonConverters.ResponseInputContentDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseInputContentDiscriminatorType?))
                {
                    return new global::Groq.JsonConverters.ResponseInputContentDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseInputTextContentType))
                {
                    return new global::Groq.JsonConverters.ResponseInputTextContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseInputTextContentType?))
                {
                    return new global::Groq.JsonConverters.ResponseInputTextContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseItemReferenceType))
                {
                    return new global::Groq.JsonConverters.ResponseItemReferenceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseItemReferenceType?))
                {
                    return new global::Groq.JsonConverters.ResponseItemReferenceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseFunctionCallType))
                {
                    return new global::Groq.JsonConverters.ResponseFunctionCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseFunctionCallType?))
                {
                    return new global::Groq.JsonConverters.ResponseFunctionCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseFunctionCallStatus))
                {
                    return new global::Groq.JsonConverters.ResponseFunctionCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseFunctionCallStatus?))
                {
                    return new global::Groq.JsonConverters.ResponseFunctionCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseFunctionCallOutputType))
                {
                    return new global::Groq.JsonConverters.ResponseFunctionCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseFunctionCallOutputType?))
                {
                    return new global::Groq.JsonConverters.ResponseFunctionCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseFunctionCallOutputStatus))
                {
                    return new global::Groq.JsonConverters.ResponseFunctionCallOutputStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseFunctionCallOutputStatus?))
                {
                    return new global::Groq.JsonConverters.ResponseFunctionCallOutputStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseToolType))
                {
                    return new global::Groq.JsonConverters.ResponseToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseToolType?))
                {
                    return new global::Groq.JsonConverters.ResponseToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseToolChoiceOptionEnum))
                {
                    return new global::Groq.JsonConverters.ResponseToolChoiceOptionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseToolChoiceOptionEnum?))
                {
                    return new global::Groq.JsonConverters.ResponseToolChoiceOptionEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseNamedToolChoiceType))
                {
                    return new global::Groq.JsonConverters.ResponseNamedToolChoiceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseNamedToolChoiceType?))
                {
                    return new global::Groq.JsonConverters.ResponseNamedToolChoiceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.TextResponseFormatJsonSchemaType))
                {
                    return new global::Groq.JsonConverters.TextResponseFormatJsonSchemaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.TextResponseFormatJsonSchemaType?))
                {
                    return new global::Groq.JsonConverters.TextResponseFormatJsonSchemaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateResponseResponseObject))
                {
                    return new global::Groq.JsonConverters.CreateResponseResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateResponseResponseObject?))
                {
                    return new global::Groq.JsonConverters.CreateResponseResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateResponseResponseStatus))
                {
                    return new global::Groq.JsonConverters.CreateResponseResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateResponseResponseStatus?))
                {
                    return new global::Groq.JsonConverters.CreateResponseResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateResponseResponseReasoningEffort))
                {
                    return new global::Groq.JsonConverters.CreateResponseResponseReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateResponseResponseReasoningEffort?))
                {
                    return new global::Groq.JsonConverters.CreateResponseResponseReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateResponseResponseTruncation))
                {
                    return new global::Groq.JsonConverters.CreateResponseResponseTruncationJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateResponseResponseTruncation?))
                {
                    return new global::Groq.JsonConverters.CreateResponseResponseTruncationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateResponseResponseServiceTier))
                {
                    return new global::Groq.JsonConverters.CreateResponseResponseServiceTierJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateResponseResponseServiceTier?))
                {
                    return new global::Groq.JsonConverters.CreateResponseResponseServiceTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseOutputItemDiscriminatorType))
                {
                    return new global::Groq.JsonConverters.ResponseOutputItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseOutputItemDiscriminatorType?))
                {
                    return new global::Groq.JsonConverters.ResponseOutputItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseOutputMessageType))
                {
                    return new global::Groq.JsonConverters.ResponseOutputMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseOutputMessageType?))
                {
                    return new global::Groq.JsonConverters.ResponseOutputMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseOutputMessageStatus))
                {
                    return new global::Groq.JsonConverters.ResponseOutputMessageStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseOutputMessageStatus?))
                {
                    return new global::Groq.JsonConverters.ResponseOutputMessageStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseOutputMessageRole))
                {
                    return new global::Groq.JsonConverters.ResponseOutputMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseOutputMessageRole?))
                {
                    return new global::Groq.JsonConverters.ResponseOutputMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseOutputContentDiscriminatorType))
                {
                    return new global::Groq.JsonConverters.ResponseOutputContentDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseOutputContentDiscriminatorType?))
                {
                    return new global::Groq.JsonConverters.ResponseOutputContentDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseOutputTextContentType))
                {
                    return new global::Groq.JsonConverters.ResponseOutputTextContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseOutputTextContentType?))
                {
                    return new global::Groq.JsonConverters.ResponseOutputTextContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseAnnotationDiscriminatorType))
                {
                    return new global::Groq.JsonConverters.ResponseAnnotationDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseAnnotationDiscriminatorType?))
                {
                    return new global::Groq.JsonConverters.ResponseAnnotationDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseFileCitationType))
                {
                    return new global::Groq.JsonConverters.ResponseFileCitationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseFileCitationType?))
                {
                    return new global::Groq.JsonConverters.ResponseFileCitationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseUrlCitationType))
                {
                    return new global::Groq.JsonConverters.ResponseUrlCitationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseUrlCitationType?))
                {
                    return new global::Groq.JsonConverters.ResponseUrlCitationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseOutputFunctionCallType))
                {
                    return new global::Groq.JsonConverters.ResponseOutputFunctionCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseOutputFunctionCallType?))
                {
                    return new global::Groq.JsonConverters.ResponseOutputFunctionCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseOutputFunctionCallStatus))
                {
                    return new global::Groq.JsonConverters.ResponseOutputFunctionCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseOutputFunctionCallStatus?))
                {
                    return new global::Groq.JsonConverters.ResponseOutputFunctionCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseOutputReasoningType))
                {
                    return new global::Groq.JsonConverters.ResponseOutputReasoningTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.ResponseOutputReasoningType?))
                {
                    return new global::Groq.JsonConverters.ResponseOutputReasoningTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new ResponsesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}
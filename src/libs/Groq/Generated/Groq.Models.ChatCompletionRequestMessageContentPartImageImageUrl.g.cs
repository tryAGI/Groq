
#nullable enable

namespace Groq
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionRequestMessageContentPartImageImageUrl
    {
        /// <summary>
        /// Specifies the detail level of the image.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Groq.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailJsonConverter))]
        public global::Groq.ChatCompletionRequestMessageContentPartImageImageUrlDetail? Detail { get; set; }

        /// <summary>
        /// Either a URL of the image or the base64 encoded image data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartImageImageUrl" /> class.
        /// </summary>
        /// <param name="detail">
        /// Specifies the detail level of the image.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="url">
        /// Either a URL of the image or the base64 encoded image data.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionRequestMessageContentPartImageImageUrl(
            string url,
            global::Groq.ChatCompletionRequestMessageContentPartImageImageUrlDetail? detail)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartImageImageUrl" /> class.
        /// </summary>
        public ChatCompletionRequestMessageContentPartImageImageUrl()
        {
        }
    }
}
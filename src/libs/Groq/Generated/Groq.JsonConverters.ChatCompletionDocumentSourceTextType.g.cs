#nullable enable

namespace Groq.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatCompletionDocumentSourceTextTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Groq.ChatCompletionDocumentSourceTextType>
    {
        /// <inheritdoc />
        public override global::Groq.ChatCompletionDocumentSourceTextType Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Groq.ChatCompletionDocumentSourceTextTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Groq.ChatCompletionDocumentSourceTextType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Groq.ChatCompletionDocumentSourceTextType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Groq.ChatCompletionDocumentSourceTextType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Groq.ChatCompletionDocumentSourceTextTypeExtensions.ToValueString(value));
        }
    }
}

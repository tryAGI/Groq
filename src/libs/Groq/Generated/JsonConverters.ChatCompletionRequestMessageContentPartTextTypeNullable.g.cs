#nullable enable

namespace Groq.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatCompletionRequestMessageContentPartTextTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Groq.ChatCompletionRequestMessageContentPartTextType?>
    {
        /// <inheritdoc />
        public override global::Groq.ChatCompletionRequestMessageContentPartTextType? Read(
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
                        return global::Groq.ChatCompletionRequestMessageContentPartTextTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Groq.ChatCompletionRequestMessageContentPartTextType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Groq.ChatCompletionRequestMessageContentPartTextType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Groq.ChatCompletionRequestMessageContentPartTextTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}

#nullable enable

namespace Groq.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateChatCompletionStreamResponseServiceTierNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Groq.CreateChatCompletionStreamResponseServiceTier?>
    {
        /// <inheritdoc />
        public override global::Groq.CreateChatCompletionStreamResponseServiceTier? Read(
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
                        return global::Groq.CreateChatCompletionStreamResponseServiceTierExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Groq.CreateChatCompletionStreamResponseServiceTier)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Groq.CreateChatCompletionStreamResponseServiceTier?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Groq.CreateChatCompletionStreamResponseServiceTier? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Groq.CreateChatCompletionStreamResponseServiceTierExtensions.ToValueString(value.Value));
            }
        }
    }
}

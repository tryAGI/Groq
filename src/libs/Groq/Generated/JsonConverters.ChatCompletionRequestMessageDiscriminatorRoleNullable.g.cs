#nullable enable

namespace Groq.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatCompletionRequestMessageDiscriminatorRoleNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Groq.ChatCompletionRequestMessageDiscriminatorRole?>
    {
        /// <inheritdoc />
        public override global::Groq.ChatCompletionRequestMessageDiscriminatorRole? Read(
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
                        return global::Groq.ChatCompletionRequestMessageDiscriminatorRoleExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Groq.ChatCompletionRequestMessageDiscriminatorRole)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Groq.ChatCompletionRequestMessageDiscriminatorRole? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Groq.ChatCompletionRequestMessageDiscriminatorRoleExtensions.ToValueString(value.Value));
            }
        }
    }
}

#nullable enable

namespace Groq.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatCompletionRequestAssistantMessageRoleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Groq.ChatCompletionRequestAssistantMessageRole>
    {
        /// <inheritdoc />
        public override global::Groq.ChatCompletionRequestAssistantMessageRole Read(
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
                        return global::Groq.ChatCompletionRequestAssistantMessageRoleExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Groq.ChatCompletionRequestAssistantMessageRole)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Groq.ChatCompletionRequestAssistantMessageRole);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Groq.ChatCompletionRequestAssistantMessageRole value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Groq.ChatCompletionRequestAssistantMessageRoleExtensions.ToValueString(value));
        }
    }
}

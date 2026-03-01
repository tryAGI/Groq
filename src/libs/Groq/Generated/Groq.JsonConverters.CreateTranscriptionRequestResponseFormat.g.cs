#nullable enable

namespace Groq.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateTranscriptionRequestResponseFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Groq.CreateTranscriptionRequestResponseFormat>
    {
        /// <inheritdoc />
        public override global::Groq.CreateTranscriptionRequestResponseFormat Read(
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
                        return global::Groq.CreateTranscriptionRequestResponseFormatExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Groq.CreateTranscriptionRequestResponseFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Groq.CreateTranscriptionRequestResponseFormat);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Groq.CreateTranscriptionRequestResponseFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Groq.CreateTranscriptionRequestResponseFormatExtensions.ToValueString(value));
        }
    }
}

#nullable enable

namespace Groq.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateFileRequestPurposeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Groq.CreateFileRequestPurpose?>
    {
        /// <inheritdoc />
        public override global::Groq.CreateFileRequestPurpose? Read(
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
                        return global::Groq.CreateFileRequestPurposeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Groq.CreateFileRequestPurpose)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Groq.CreateFileRequestPurpose?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Groq.CreateFileRequestPurpose? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Groq.CreateFileRequestPurposeExtensions.ToValueString(value.Value));
            }
        }
    }
}

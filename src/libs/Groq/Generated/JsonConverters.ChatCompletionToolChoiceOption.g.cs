#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Groq.JsonConverters
{
    /// <inheritdoc />
    public class ChatCompletionToolChoiceOptionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Groq.ChatCompletionToolChoiceOption>
    {
        /// <inheritdoc />
        public override global::Groq.ChatCompletionToolChoiceOption Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Groq.ChatCompletionToolChoiceOptionEnum? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ChatCompletionToolChoiceOptionEnum), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ChatCompletionToolChoiceOptionEnum> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Groq.ChatCompletionToolChoiceOptionEnum).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Groq.ChatCompletionNamedToolChoice? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ChatCompletionNamedToolChoice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ChatCompletionNamedToolChoice> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Groq.ChatCompletionNamedToolChoice).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::Groq.ChatCompletionToolChoiceOption(
                value1,
                value2
                );

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ChatCompletionToolChoiceOptionEnum), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ChatCompletionToolChoiceOptionEnum> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Groq.ChatCompletionToolChoiceOptionEnum).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ChatCompletionNamedToolChoice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ChatCompletionNamedToolChoice> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Groq.ChatCompletionNamedToolChoice).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Groq.ChatCompletionToolChoiceOption value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ChatCompletionToolChoiceOptionEnum), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ChatCompletionToolChoiceOptionEnum?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Groq.ChatCompletionToolChoiceOptionEnum).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ChatCompletionNamedToolChoice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ChatCompletionNamedToolChoice?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Groq.ChatCompletionNamedToolChoice).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
        }
    }
}
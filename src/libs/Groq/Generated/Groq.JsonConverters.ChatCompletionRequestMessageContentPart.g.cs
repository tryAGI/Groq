#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Groq.JsonConverters
{
    /// <inheritdoc />
    public class ChatCompletionRequestMessageContentPartJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Groq.ChatCompletionRequestMessageContentPart>
    {
        /// <inheritdoc />
        public override global::Groq.ChatCompletionRequestMessageContentPart Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Groq.ChatCompletionRequestMessageContentPartText? textContentPart = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ChatCompletionRequestMessageContentPartText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ChatCompletionRequestMessageContentPartText> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Groq.ChatCompletionRequestMessageContentPartText).Name}");
                textContentPart = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Groq.ChatCompletionRequestMessageContentPartImage? imageContentPart = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ChatCompletionRequestMessageContentPartImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ChatCompletionRequestMessageContentPartImage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Groq.ChatCompletionRequestMessageContentPartImage).Name}");
                imageContentPart = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var __value = new global::Groq.ChatCompletionRequestMessageContentPart(
                textContentPart,

                imageContentPart
                );

            if (textContentPart != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ChatCompletionRequestMessageContentPartText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ChatCompletionRequestMessageContentPartText> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Groq.ChatCompletionRequestMessageContentPartText).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (imageContentPart != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ChatCompletionRequestMessageContentPartImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ChatCompletionRequestMessageContentPartImage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Groq.ChatCompletionRequestMessageContentPartImage).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Groq.ChatCompletionRequestMessageContentPart value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTextContentPart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ChatCompletionRequestMessageContentPartText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ChatCompletionRequestMessageContentPartText?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Groq.ChatCompletionRequestMessageContentPartText).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextContentPart, typeInfo);
            }
            else if (value.IsImageContentPart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ChatCompletionRequestMessageContentPartImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ChatCompletionRequestMessageContentPartImage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Groq.ChatCompletionRequestMessageContentPartImage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageContentPart, typeInfo);
            }
        }
    }
}
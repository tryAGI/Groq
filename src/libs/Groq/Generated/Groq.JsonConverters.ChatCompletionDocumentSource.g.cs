#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Groq.JsonConverters
{
    /// <inheritdoc />
    public class ChatCompletionDocumentSourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Groq.ChatCompletionDocumentSource>
    {
        /// <inheritdoc />
        public override global::Groq.ChatCompletionDocumentSource Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ChatCompletionDocumentSourceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ChatCompletionDocumentSourceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Groq.ChatCompletionDocumentSourceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Groq.ChatCompletionDocumentSourceText? text = default;
            if (discriminator?.Type == global::Groq.ChatCompletionDocumentSourceDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ChatCompletionDocumentSourceText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ChatCompletionDocumentSourceText> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Groq.ChatCompletionDocumentSourceText)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Groq.ChatCompletionDocumentSourceJSON? json = default;
            if (discriminator?.Type == global::Groq.ChatCompletionDocumentSourceDiscriminatorType.Json)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ChatCompletionDocumentSourceJSON), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ChatCompletionDocumentSourceJSON> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Groq.ChatCompletionDocumentSourceJSON)}");
                json = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Groq.ChatCompletionDocumentSource(
                discriminator?.Type,
                text,

                json
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Groq.ChatCompletionDocumentSource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ChatCompletionDocumentSourceText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ChatCompletionDocumentSourceText?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Groq.ChatCompletionDocumentSourceText).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
            else if (value.IsJson)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ChatCompletionDocumentSourceJSON), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ChatCompletionDocumentSourceJSON?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Groq.ChatCompletionDocumentSourceJSON).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Json!, typeInfo);
            }
        }
    }
}
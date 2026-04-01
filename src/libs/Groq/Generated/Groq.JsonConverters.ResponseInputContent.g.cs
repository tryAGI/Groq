#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Groq.JsonConverters
{
    /// <inheritdoc />
    public class ResponseInputContentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Groq.ResponseInputContent>
    {
        /// <inheritdoc />
        public override global::Groq.ResponseInputContent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ResponseInputContentDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ResponseInputContentDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Groq.ResponseInputContentDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Groq.ResponseInputTextContent? inputText = default;
            if (discriminator?.Type == global::Groq.ResponseInputContentDiscriminatorType.InputText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ResponseInputTextContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ResponseInputTextContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Groq.ResponseInputTextContent)}");
                inputText = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Groq.ResponseInputContent(
                discriminator?.Type,
                inputText
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Groq.ResponseInputContent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInputText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ResponseInputTextContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ResponseInputTextContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Groq.ResponseInputTextContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputText!, typeInfo);
            }
        }
    }
}
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Groq.JsonConverters
{
    /// <inheritdoc />
    public class ResponseAnnotationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Groq.ResponseAnnotation>
    {
        /// <inheritdoc />
        public override global::Groq.ResponseAnnotation Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ResponseAnnotationDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ResponseAnnotationDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Groq.ResponseAnnotationDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Groq.ResponseFileCitation? fileCitation = default;
            if (discriminator?.Type == global::Groq.ResponseAnnotationDiscriminatorType.FileCitation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ResponseFileCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ResponseFileCitation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Groq.ResponseFileCitation)}");
                fileCitation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Groq.ResponseUrlCitation? urlCitation = default;
            if (discriminator?.Type == global::Groq.ResponseAnnotationDiscriminatorType.UrlCitation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ResponseUrlCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ResponseUrlCitation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Groq.ResponseUrlCitation)}");
                urlCitation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Groq.ResponseAnnotation(
                discriminator?.Type,
                fileCitation,

                urlCitation
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Groq.ResponseAnnotation value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFileCitation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ResponseFileCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ResponseFileCitation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Groq.ResponseFileCitation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileCitation, typeInfo);
            }
            else if (value.IsUrlCitation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ResponseUrlCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ResponseUrlCitation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Groq.ResponseUrlCitation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UrlCitation, typeInfo);
            }
        }
    }
}
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Groq.JsonConverters
{
    /// <inheritdoc />
    public class ResponseOutputItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Groq.ResponseOutputItem>
    {
        /// <inheritdoc />
        public override global::Groq.ResponseOutputItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ResponseOutputItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ResponseOutputItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Groq.ResponseOutputItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Groq.ResponseOutputMessage? message = default;
            if (discriminator?.Type == global::Groq.ResponseOutputItemDiscriminatorType.Message)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ResponseOutputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ResponseOutputMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Groq.ResponseOutputMessage)}");
                message = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Groq.ResponseOutputFunctionCall? functionCall = default;
            if (discriminator?.Type == global::Groq.ResponseOutputItemDiscriminatorType.FunctionCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ResponseOutputFunctionCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ResponseOutputFunctionCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Groq.ResponseOutputFunctionCall)}");
                functionCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Groq.ResponseOutputReasoning? reasoning = default;
            if (discriminator?.Type == global::Groq.ResponseOutputItemDiscriminatorType.Reasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ResponseOutputReasoning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ResponseOutputReasoning> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Groq.ResponseOutputReasoning)}");
                reasoning = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Groq.ResponseOutputItem(
                discriminator?.Type,
                message,

                functionCall,

                reasoning
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Groq.ResponseOutputItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ResponseOutputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ResponseOutputMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Groq.ResponseOutputMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Message, typeInfo);
            }
            else if (value.IsFunctionCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ResponseOutputFunctionCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ResponseOutputFunctionCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Groq.ResponseOutputFunctionCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCall, typeInfo);
            }
            else if (value.IsReasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ResponseOutputReasoning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ResponseOutputReasoning?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Groq.ResponseOutputReasoning).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Reasoning, typeInfo);
            }
        }
    }
}
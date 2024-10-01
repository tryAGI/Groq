#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Groq.JsonConverters
{
    /// <inheritdoc />
    public class ChatCompletionRequestMessageJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Groq.ChatCompletionRequestMessage>
    {
        /// <inheritdoc />
        public override global::Groq.ChatCompletionRequestMessage Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Groq.ChatCompletionRequestSystemMessage? system = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ChatCompletionRequestSystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ChatCompletionRequestSystemMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Groq.ChatCompletionRequestSystemMessage).Name}");
                system = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Groq.ChatCompletionRequestUserMessage? user = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ChatCompletionRequestUserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ChatCompletionRequestUserMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Groq.ChatCompletionRequestUserMessage).Name}");
                user = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Groq.ChatCompletionRequestAssistantMessage? assistant = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ChatCompletionRequestAssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ChatCompletionRequestAssistantMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Groq.ChatCompletionRequestAssistantMessage).Name}");
                assistant = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Groq.ChatCompletionRequestToolMessage? tool = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ChatCompletionRequestToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ChatCompletionRequestToolMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Groq.ChatCompletionRequestToolMessage).Name}");
                tool = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Groq.ChatCompletionRequestFunctionMessage? function = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ChatCompletionRequestFunctionMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ChatCompletionRequestFunctionMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Groq.ChatCompletionRequestFunctionMessage).Name}");
                function = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::Groq.ChatCompletionRequestMessage(
                system,
                user,
                assistant,
                tool,
                function
                );

            if (system != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ChatCompletionRequestSystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ChatCompletionRequestSystemMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Groq.ChatCompletionRequestSystemMessage).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (user != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ChatCompletionRequestUserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ChatCompletionRequestUserMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Groq.ChatCompletionRequestUserMessage).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (assistant != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ChatCompletionRequestAssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ChatCompletionRequestAssistantMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Groq.ChatCompletionRequestAssistantMessage).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (tool != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ChatCompletionRequestToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ChatCompletionRequestToolMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Groq.ChatCompletionRequestToolMessage).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (function != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ChatCompletionRequestFunctionMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ChatCompletionRequestFunctionMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Groq.ChatCompletionRequestFunctionMessage).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Groq.ChatCompletionRequestMessage value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSystem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ChatCompletionRequestSystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ChatCompletionRequestSystemMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Groq.ChatCompletionRequestSystemMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.System, typeInfo);
            }
            else if (value.IsUser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ChatCompletionRequestUserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ChatCompletionRequestUserMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Groq.ChatCompletionRequestUserMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.User, typeInfo);
            }
            else if (value.IsAssistant)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ChatCompletionRequestAssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ChatCompletionRequestAssistantMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Groq.ChatCompletionRequestAssistantMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Assistant, typeInfo);
            }
            else if (value.IsTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ChatCompletionRequestToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ChatCompletionRequestToolMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Groq.ChatCompletionRequestToolMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeInfo);
            }
            else if (value.IsFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Groq.ChatCompletionRequestFunctionMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Groq.ChatCompletionRequestFunctionMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Groq.ChatCompletionRequestFunctionMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function, typeInfo);
            }
        }
    }
}
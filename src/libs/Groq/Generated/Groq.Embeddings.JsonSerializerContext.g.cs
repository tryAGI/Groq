
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Groq
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.OneOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.Embedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.OneOf<global::System.Collections.Generic.IList<double>, string>), TypeInfoPropertyName = "OneOfIListDoubleString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.EmbeddingObject), TypeInfoPropertyName = "EmbeddingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateEmbeddingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.AnyOf<string, global::Groq.CreateEmbeddingRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateEmbeddingRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateEmbeddingRequestModel), TypeInfoPropertyName = "CreateEmbeddingRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateEmbeddingRequestEncodingFormat), TypeInfoPropertyName = "CreateEmbeddingRequestEncodingFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateEmbeddingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.Embedding>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateEmbeddingResponseObject), TypeInfoPropertyName = "CreateEmbeddingResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateEmbeddingResponseUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.OneOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableOneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.OneOf<global::System.Collections.Generic.IList<double>, string>?), TypeInfoPropertyName = "NullableOneOfIListDoubleString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.EmbeddingObject?), TypeInfoPropertyName = "NullableEmbeddingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.AnyOf<string, global::Groq.CreateEmbeddingRequestModel?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateEmbeddingRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateEmbeddingRequestModel?), TypeInfoPropertyName = "NullableCreateEmbeddingRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateEmbeddingRequestEncodingFormat?), TypeInfoPropertyName = "NullableCreateEmbeddingRequestEncodingFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateEmbeddingResponseObject?), TypeInfoPropertyName = "NullableCreateEmbeddingResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.OneOf<global::System.Collections.Generic.List<double>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.Embedding>))]
    internal sealed partial class EmbeddingsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EmbeddingsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static EmbeddingsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private EmbeddingsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Groq.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Groq.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<double>, string>());
            options.Converters.Add(new global::Groq.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Groq.JsonConverters.AnyOfJsonConverter<string, global::Groq.CreateEmbeddingRequestModel?>());
            options.Converters.Add(new global::Groq.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Groq.EmbeddingObject)

                    || typeToConvert == typeof(global::Groq.EmbeddingObject?)

                    || typeToConvert == typeof(global::Groq.CreateEmbeddingRequestModel)

                    || typeToConvert == typeof(global::Groq.CreateEmbeddingRequestModel?)

                    || typeToConvert == typeof(global::Groq.CreateEmbeddingRequestEncodingFormat)

                    || typeToConvert == typeof(global::Groq.CreateEmbeddingRequestEncodingFormat?)

                    || typeToConvert == typeof(global::Groq.CreateEmbeddingResponseObject)

                    || typeToConvert == typeof(global::Groq.CreateEmbeddingResponseObject?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Groq.EmbeddingObject))
                {
                    return new global::Groq.JsonConverters.EmbeddingObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.EmbeddingObject?))
                {
                    return new global::Groq.JsonConverters.EmbeddingObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateEmbeddingRequestModel))
                {
                    return new global::Groq.JsonConverters.CreateEmbeddingRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateEmbeddingRequestModel?))
                {
                    return new global::Groq.JsonConverters.CreateEmbeddingRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateEmbeddingRequestEncodingFormat))
                {
                    return new global::Groq.JsonConverters.CreateEmbeddingRequestEncodingFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateEmbeddingRequestEncodingFormat?))
                {
                    return new global::Groq.JsonConverters.CreateEmbeddingRequestEncodingFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateEmbeddingResponseObject))
                {
                    return new global::Groq.JsonConverters.CreateEmbeddingResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateEmbeddingResponseObject?))
                {
                    return new global::Groq.JsonConverters.CreateEmbeddingResponseObjectNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new EmbeddingsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}
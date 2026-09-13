
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateSpeechRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.AnyOf<string, global::Groq.CreateSpeechRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateSpeechRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateSpeechRequestModel), TypeInfoPropertyName = "CreateSpeechRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateSpeechRequestResponseFormat), TypeInfoPropertyName = "CreateSpeechRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateTranscriptionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.AnyOf<string, global::Groq.CreateTranscriptionRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateTranscriptionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateTranscriptionRequestModel), TypeInfoPropertyName = "CreateTranscriptionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.AnyOf<string, global::Groq.CreateTranscriptionRequestLanguage?>), TypeInfoPropertyName = "AnyOfStringCreateTranscriptionRequestLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateTranscriptionRequestLanguage), TypeInfoPropertyName = "CreateTranscriptionRequestLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateTranscriptionRequestResponseFormat), TypeInfoPropertyName = "CreateTranscriptionRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Groq.CreateTranscriptionRequestTimestampGranularitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateTranscriptionRequestTimestampGranularitie), TypeInfoPropertyName = "CreateTranscriptionRequestTimestampGranularitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateTranscriptionResponseJson))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateTranslationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.AnyOf<string, global::Groq.CreateTranslationRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateTranslationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateTranslationRequestModel), TypeInfoPropertyName = "CreateTranslationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateTranslationRequestResponseFormat), TypeInfoPropertyName = "CreateTranslationRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateTranslationResponseJson))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.AnyOf<string, global::Groq.CreateSpeechRequestModel?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateSpeechRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateSpeechRequestModel?), TypeInfoPropertyName = "NullableCreateSpeechRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateSpeechRequestResponseFormat?), TypeInfoPropertyName = "NullableCreateSpeechRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.AnyOf<string, global::Groq.CreateTranscriptionRequestModel?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateTranscriptionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateTranscriptionRequestModel?), TypeInfoPropertyName = "NullableCreateTranscriptionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.AnyOf<string, global::Groq.CreateTranscriptionRequestLanguage?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateTranscriptionRequestLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateTranscriptionRequestLanguage?), TypeInfoPropertyName = "NullableCreateTranscriptionRequestLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateTranscriptionRequestResponseFormat?), TypeInfoPropertyName = "NullableCreateTranscriptionRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateTranscriptionRequestTimestampGranularitie?), TypeInfoPropertyName = "NullableCreateTranscriptionRequestTimestampGranularitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.AnyOf<string, global::Groq.CreateTranslationRequestModel?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateTranslationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateTranslationRequestModel?), TypeInfoPropertyName = "NullableCreateTranslationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Groq.CreateTranslationRequestResponseFormat?), TypeInfoPropertyName = "NullableCreateTranslationRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Groq.CreateTranscriptionRequestTimestampGranularitie>))]
    internal sealed partial class AudioSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AudioSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AudioSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AudioSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Groq.JsonConverters.AnyOfJsonConverter<string, global::Groq.CreateSpeechRequestModel?>());
            options.Converters.Add(new global::Groq.JsonConverters.AnyOfJsonConverter<string, global::Groq.CreateTranscriptionRequestModel?>());
            options.Converters.Add(new global::Groq.JsonConverters.AnyOfJsonConverter<string, global::Groq.CreateTranscriptionRequestLanguage?>());
            options.Converters.Add(new global::Groq.JsonConverters.AnyOfJsonConverter<string, global::Groq.CreateTranslationRequestModel?>());
            options.Converters.Add(new global::Groq.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Groq.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<double>, string>());
            options.Converters.Add(new global::Groq.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
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
                    typeToConvert == typeof(global::Groq.CreateSpeechRequestModel)

                    || typeToConvert == typeof(global::Groq.CreateSpeechRequestModel?)

                    || typeToConvert == typeof(global::Groq.CreateSpeechRequestResponseFormat)

                    || typeToConvert == typeof(global::Groq.CreateSpeechRequestResponseFormat?)

                    || typeToConvert == typeof(global::Groq.CreateTranscriptionRequestModel)

                    || typeToConvert == typeof(global::Groq.CreateTranscriptionRequestModel?)

                    || typeToConvert == typeof(global::Groq.CreateTranscriptionRequestLanguage)

                    || typeToConvert == typeof(global::Groq.CreateTranscriptionRequestLanguage?)

                    || typeToConvert == typeof(global::Groq.CreateTranscriptionRequestResponseFormat)

                    || typeToConvert == typeof(global::Groq.CreateTranscriptionRequestResponseFormat?)

                    || typeToConvert == typeof(global::Groq.CreateTranscriptionRequestTimestampGranularitie)

                    || typeToConvert == typeof(global::Groq.CreateTranscriptionRequestTimestampGranularitie?)

                    || typeToConvert == typeof(global::Groq.CreateTranslationRequestModel)

                    || typeToConvert == typeof(global::Groq.CreateTranslationRequestModel?)

                    || typeToConvert == typeof(global::Groq.CreateTranslationRequestResponseFormat)

                    || typeToConvert == typeof(global::Groq.CreateTranslationRequestResponseFormat?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Groq.CreateSpeechRequestModel))
                {
                    return new global::Groq.JsonConverters.CreateSpeechRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateSpeechRequestModel?))
                {
                    return new global::Groq.JsonConverters.CreateSpeechRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateSpeechRequestResponseFormat))
                {
                    return new global::Groq.JsonConverters.CreateSpeechRequestResponseFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateSpeechRequestResponseFormat?))
                {
                    return new global::Groq.JsonConverters.CreateSpeechRequestResponseFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateTranscriptionRequestModel))
                {
                    return new global::Groq.JsonConverters.CreateTranscriptionRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateTranscriptionRequestModel?))
                {
                    return new global::Groq.JsonConverters.CreateTranscriptionRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateTranscriptionRequestLanguage))
                {
                    return new global::Groq.JsonConverters.CreateTranscriptionRequestLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateTranscriptionRequestLanguage?))
                {
                    return new global::Groq.JsonConverters.CreateTranscriptionRequestLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateTranscriptionRequestResponseFormat))
                {
                    return new global::Groq.JsonConverters.CreateTranscriptionRequestResponseFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateTranscriptionRequestResponseFormat?))
                {
                    return new global::Groq.JsonConverters.CreateTranscriptionRequestResponseFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateTranscriptionRequestTimestampGranularitie))
                {
                    return new global::Groq.JsonConverters.CreateTranscriptionRequestTimestampGranularitieJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateTranscriptionRequestTimestampGranularitie?))
                {
                    return new global::Groq.JsonConverters.CreateTranscriptionRequestTimestampGranularitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateTranslationRequestModel))
                {
                    return new global::Groq.JsonConverters.CreateTranslationRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateTranslationRequestModel?))
                {
                    return new global::Groq.JsonConverters.CreateTranslationRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateTranslationRequestResponseFormat))
                {
                    return new global::Groq.JsonConverters.CreateTranslationRequestResponseFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Groq.CreateTranslationRequestResponseFormat?))
                {
                    return new global::Groq.JsonConverters.CreateTranslationRequestResponseFormatNullableJsonConverter();
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
                    0 => new AudioSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}
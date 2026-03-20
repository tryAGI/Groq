#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Groq
{
    /// <summary>
    /// An object specifying the format that the model must output.
    /// </summary>
    public readonly partial struct ResponseFormatConfiguration : global::System.IEquatable<ResponseFormatConfiguration>
    {
        /// <summary>
        /// Default response format. Used to generate text responses.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Groq.ResponseFormatText? Text { get; init; }
#else
        public global::Groq.ResponseFormatText? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// JSON object response format. An older method of generating JSON responses. Using `json_schema` is recommended for models that support it. Note that the model will not generate JSON without a system or user message instructing it to do so.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Groq.ResponseFormatJsonObject? JsonObject { get; init; }
#else
        public global::Groq.ResponseFormatJsonObject? JsonObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonObject))]
#endif
        public bool IsJsonObject => JsonObject != null;

        /// <summary>
        /// JSON Schema response format. Used to generate structured JSON responses.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Groq.TextResponseFormatJsonSchema? JsonSchema { get; init; }
#else
        public global::Groq.TextResponseFormatJsonSchema? JsonSchema { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonSchema))]
#endif
        public bool IsJsonSchema => JsonSchema != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseFormatConfiguration(global::Groq.ResponseFormatText value) => new ResponseFormatConfiguration((global::Groq.ResponseFormatText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Groq.ResponseFormatText?(ResponseFormatConfiguration @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormatConfiguration(global::Groq.ResponseFormatText? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseFormatConfiguration(global::Groq.ResponseFormatJsonObject value) => new ResponseFormatConfiguration((global::Groq.ResponseFormatJsonObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Groq.ResponseFormatJsonObject?(ResponseFormatConfiguration @this) => @this.JsonObject;

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormatConfiguration(global::Groq.ResponseFormatJsonObject? value)
        {
            JsonObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseFormatConfiguration(global::Groq.TextResponseFormatJsonSchema value) => new ResponseFormatConfiguration((global::Groq.TextResponseFormatJsonSchema?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Groq.TextResponseFormatJsonSchema?(ResponseFormatConfiguration @this) => @this.JsonSchema;

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormatConfiguration(global::Groq.TextResponseFormatJsonSchema? value)
        {
            JsonSchema = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormatConfiguration(
            global::Groq.ResponseFormatText? text,
            global::Groq.ResponseFormatJsonObject? jsonObject,
            global::Groq.TextResponseFormatJsonSchema? jsonSchema
            )
        {
            Text = text;
            JsonObject = jsonObject;
            JsonSchema = jsonSchema;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            JsonSchema as object ??
            JsonObject as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            JsonObject?.ToString() ??
            JsonSchema?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsJsonObject && !IsJsonSchema || !IsText && IsJsonObject && !IsJsonSchema || !IsText && !IsJsonObject && IsJsonSchema;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Groq.ResponseFormatText?, TResult>? text = null,
            global::System.Func<global::Groq.ResponseFormatJsonObject?, TResult>? jsonObject = null,
            global::System.Func<global::Groq.TextResponseFormatJsonSchema?, TResult>? jsonSchema = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsJsonObject && jsonObject != null)
            {
                return jsonObject(JsonObject!);
            }
            else if (IsJsonSchema && jsonSchema != null)
            {
                return jsonSchema(JsonSchema!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Groq.ResponseFormatText?>? text = null,
            global::System.Action<global::Groq.ResponseFormatJsonObject?>? jsonObject = null,
            global::System.Action<global::Groq.TextResponseFormatJsonSchema?>? jsonSchema = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsJsonObject)
            {
                jsonObject?.Invoke(JsonObject!);
            }
            else if (IsJsonSchema)
            {
                jsonSchema?.Invoke(JsonSchema!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::Groq.ResponseFormatText),
                JsonObject,
                typeof(global::Groq.ResponseFormatJsonObject),
                JsonSchema,
                typeof(global::Groq.TextResponseFormatJsonSchema),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ResponseFormatConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Groq.ResponseFormatText?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Groq.ResponseFormatJsonObject?>.Default.Equals(JsonObject, other.JsonObject) &&
                global::System.Collections.Generic.EqualityComparer<global::Groq.TextResponseFormatJsonSchema?>.Default.Equals(JsonSchema, other.JsonSchema) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponseFormatConfiguration obj1, ResponseFormatConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseFormatConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponseFormatConfiguration obj1, ResponseFormatConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseFormatConfiguration o && Equals(o);
        }
    }
}

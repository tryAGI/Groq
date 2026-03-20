#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Groq
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResponseInputContent : global::System.IEquatable<ResponseInputContent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ResponseInputContentDiscriminatorType? Type { get; }

        /// <summary>
        /// A text input to the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Groq.ResponseInputTextContent? InputText { get; init; }
#else
        public global::Groq.ResponseInputTextContent? InputText { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputText))]
#endif
        public bool IsInputText => InputText != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseInputContent(global::Groq.ResponseInputTextContent value) => new ResponseInputContent((global::Groq.ResponseInputTextContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Groq.ResponseInputTextContent?(ResponseInputContent @this) => @this.InputText;

        /// <summary>
        /// 
        /// </summary>
        public ResponseInputContent(global::Groq.ResponseInputTextContent? value)
        {
            InputText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResponseInputContent(
            global::Groq.ResponseInputContentDiscriminatorType? type,
            global::Groq.ResponseInputTextContent? inputText
            )
        {
            Type = type;

            InputText = inputText;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InputText as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputText?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputText;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Groq.ResponseInputTextContent?, TResult>? inputText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputText && inputText != null)
            {
                return inputText(InputText!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Groq.ResponseInputTextContent?>? inputText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputText)
            {
                inputText?.Invoke(InputText!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputText,
                typeof(global::Groq.ResponseInputTextContent),
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
        public bool Equals(ResponseInputContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Groq.ResponseInputTextContent?>.Default.Equals(InputText, other.InputText) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponseInputContent obj1, ResponseInputContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseInputContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponseInputContent obj1, ResponseInputContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseInputContent o && Equals(o);
        }
    }
}

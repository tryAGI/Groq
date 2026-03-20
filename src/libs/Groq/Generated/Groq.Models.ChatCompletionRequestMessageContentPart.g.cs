#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Groq
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatCompletionRequestMessageContentPart : global::System.IEquatable<ChatCompletionRequestMessageContentPart>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Groq.ChatCompletionRequestMessageContentPartText? TextContentPart { get; init; }
#else
        public global::Groq.ChatCompletionRequestMessageContentPartText? TextContentPart { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextContentPart))]
#endif
        public bool IsTextContentPart => TextContentPart != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Groq.ChatCompletionRequestMessageContentPartImage? ImageContentPart { get; init; }
#else
        public global::Groq.ChatCompletionRequestMessageContentPartImage? ImageContentPart { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageContentPart))]
#endif
        public bool IsImageContentPart => ImageContentPart != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Groq.ChatCompletionRequestMessageContentPartDocument? DocumentContentPart { get; init; }
#else
        public global::Groq.ChatCompletionRequestMessageContentPartDocument? DocumentContentPart { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DocumentContentPart))]
#endif
        public bool IsDocumentContentPart => DocumentContentPart != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestMessageContentPart(global::Groq.ChatCompletionRequestMessageContentPartText value) => new ChatCompletionRequestMessageContentPart((global::Groq.ChatCompletionRequestMessageContentPartText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Groq.ChatCompletionRequestMessageContentPartText?(ChatCompletionRequestMessageContentPart @this) => @this.TextContentPart;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessageContentPart(global::Groq.ChatCompletionRequestMessageContentPartText? value)
        {
            TextContentPart = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestMessageContentPart(global::Groq.ChatCompletionRequestMessageContentPartImage value) => new ChatCompletionRequestMessageContentPart((global::Groq.ChatCompletionRequestMessageContentPartImage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Groq.ChatCompletionRequestMessageContentPartImage?(ChatCompletionRequestMessageContentPart @this) => @this.ImageContentPart;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessageContentPart(global::Groq.ChatCompletionRequestMessageContentPartImage? value)
        {
            ImageContentPart = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestMessageContentPart(global::Groq.ChatCompletionRequestMessageContentPartDocument value) => new ChatCompletionRequestMessageContentPart((global::Groq.ChatCompletionRequestMessageContentPartDocument?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Groq.ChatCompletionRequestMessageContentPartDocument?(ChatCompletionRequestMessageContentPart @this) => @this.DocumentContentPart;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessageContentPart(global::Groq.ChatCompletionRequestMessageContentPartDocument? value)
        {
            DocumentContentPart = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessageContentPart(
            global::Groq.ChatCompletionRequestMessageContentPartText? textContentPart,
            global::Groq.ChatCompletionRequestMessageContentPartImage? imageContentPart,
            global::Groq.ChatCompletionRequestMessageContentPartDocument? documentContentPart
            )
        {
            TextContentPart = textContentPart;
            ImageContentPart = imageContentPart;
            DocumentContentPart = documentContentPart;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DocumentContentPart as object ??
            ImageContentPart as object ??
            TextContentPart as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TextContentPart?.ToString() ??
            ImageContentPart?.ToString() ??
            DocumentContentPart?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextContentPart && !IsImageContentPart && !IsDocumentContentPart || !IsTextContentPart && IsImageContentPart && !IsDocumentContentPart || !IsTextContentPart && !IsImageContentPart && IsDocumentContentPart;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Groq.ChatCompletionRequestMessageContentPartText?, TResult>? textContentPart = null,
            global::System.Func<global::Groq.ChatCompletionRequestMessageContentPartImage?, TResult>? imageContentPart = null,
            global::System.Func<global::Groq.ChatCompletionRequestMessageContentPartDocument?, TResult>? documentContentPart = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextContentPart && textContentPart != null)
            {
                return textContentPart(TextContentPart!);
            }
            else if (IsImageContentPart && imageContentPart != null)
            {
                return imageContentPart(ImageContentPart!);
            }
            else if (IsDocumentContentPart && documentContentPart != null)
            {
                return documentContentPart(DocumentContentPart!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Groq.ChatCompletionRequestMessageContentPartText?>? textContentPart = null,
            global::System.Action<global::Groq.ChatCompletionRequestMessageContentPartImage?>? imageContentPart = null,
            global::System.Action<global::Groq.ChatCompletionRequestMessageContentPartDocument?>? documentContentPart = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextContentPart)
            {
                textContentPart?.Invoke(TextContentPart!);
            }
            else if (IsImageContentPart)
            {
                imageContentPart?.Invoke(ImageContentPart!);
            }
            else if (IsDocumentContentPart)
            {
                documentContentPart?.Invoke(DocumentContentPart!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TextContentPart,
                typeof(global::Groq.ChatCompletionRequestMessageContentPartText),
                ImageContentPart,
                typeof(global::Groq.ChatCompletionRequestMessageContentPartImage),
                DocumentContentPart,
                typeof(global::Groq.ChatCompletionRequestMessageContentPartDocument),
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
        public bool Equals(ChatCompletionRequestMessageContentPart other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Groq.ChatCompletionRequestMessageContentPartText?>.Default.Equals(TextContentPart, other.TextContentPart) &&
                global::System.Collections.Generic.EqualityComparer<global::Groq.ChatCompletionRequestMessageContentPartImage?>.Default.Equals(ImageContentPart, other.ImageContentPart) &&
                global::System.Collections.Generic.EqualityComparer<global::Groq.ChatCompletionRequestMessageContentPartDocument?>.Default.Equals(DocumentContentPart, other.DocumentContentPart) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionRequestMessageContentPart obj1, ChatCompletionRequestMessageContentPart obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionRequestMessageContentPart>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionRequestMessageContentPart obj1, ChatCompletionRequestMessageContentPart obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionRequestMessageContentPart o && Equals(o);
        }
    }
}

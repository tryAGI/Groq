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
        public global::Groq.ChatCompletionRequestMessageContentPartText? Text { get; init; }
#else
        public global::Groq.ChatCompletionRequestMessageContentPartText? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestMessageContentPart(global::Groq.ChatCompletionRequestMessageContentPartText value) => new ChatCompletionRequestMessageContentPart(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Groq.ChatCompletionRequestMessageContentPartText?(ChatCompletionRequestMessageContentPart @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessageContentPart(global::Groq.ChatCompletionRequestMessageContentPartText? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Groq.ChatCompletionRequestMessageContentPartImage? Image { get; init; }
#else
        public global::Groq.ChatCompletionRequestMessageContentPartImage? Image { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestMessageContentPart(global::Groq.ChatCompletionRequestMessageContentPartImage value) => new ChatCompletionRequestMessageContentPart(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Groq.ChatCompletionRequestMessageContentPartImage?(ChatCompletionRequestMessageContentPart @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessageContentPart(global::Groq.ChatCompletionRequestMessageContentPartImage? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessageContentPart(
            global::Groq.ChatCompletionRequestMessageContentPartText? text,
            global::Groq.ChatCompletionRequestMessageContentPartImage? image
            )
        {
            Text = text;
            Image = image;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Image as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImage || !IsText && IsImage;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Groq.ChatCompletionRequestMessageContentPartText?, TResult>? text = null,
            global::System.Func<global::Groq.ChatCompletionRequestMessageContentPartImage?, TResult>? image = null,
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
            else if (IsImage && image != null)
            {
                return image(Image!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Groq.ChatCompletionRequestMessageContentPartText?>? text = null,
            global::System.Action<global::Groq.ChatCompletionRequestMessageContentPartImage?>? image = null,
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
            else if (IsImage)
            {
                image?.Invoke(Image!);
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
                typeof(global::Groq.ChatCompletionRequestMessageContentPartText),
                Image,
                typeof(global::Groq.ChatCompletionRequestMessageContentPartImage),
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
                global::System.Collections.Generic.EqualityComparer<global::Groq.ChatCompletionRequestMessageContentPartText?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Groq.ChatCompletionRequestMessageContentPartImage?>.Default.Equals(Image, other.Image) 
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

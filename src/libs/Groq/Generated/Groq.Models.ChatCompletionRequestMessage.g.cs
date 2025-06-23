#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Groq
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatCompletionRequestMessage : global::System.IEquatable<ChatCompletionRequestMessage>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Groq.ChatCompletionRequestMessageDiscriminatorRole? Role { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Groq.ChatCompletionRequestSystemMessage? System { get; init; }
#else
        public global::Groq.ChatCompletionRequestSystemMessage? System { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(System))]
#endif
        public bool IsSystem => System != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestMessage(global::Groq.ChatCompletionRequestSystemMessage value) => new ChatCompletionRequestMessage((global::Groq.ChatCompletionRequestSystemMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Groq.ChatCompletionRequestSystemMessage?(ChatCompletionRequestMessage @this) => @this.System;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(global::Groq.ChatCompletionRequestSystemMessage? value)
        {
            System = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Groq.ChatCompletionRequestUserMessage? User { get; init; }
#else
        public global::Groq.ChatCompletionRequestUserMessage? User { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(User))]
#endif
        public bool IsUser => User != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestMessage(global::Groq.ChatCompletionRequestUserMessage value) => new ChatCompletionRequestMessage((global::Groq.ChatCompletionRequestUserMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Groq.ChatCompletionRequestUserMessage?(ChatCompletionRequestMessage @this) => @this.User;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(global::Groq.ChatCompletionRequestUserMessage? value)
        {
            User = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Groq.ChatCompletionRequestAssistantMessage? Assistant { get; init; }
#else
        public global::Groq.ChatCompletionRequestAssistantMessage? Assistant { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Assistant))]
#endif
        public bool IsAssistant => Assistant != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestMessage(global::Groq.ChatCompletionRequestAssistantMessage value) => new ChatCompletionRequestMessage((global::Groq.ChatCompletionRequestAssistantMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Groq.ChatCompletionRequestAssistantMessage?(ChatCompletionRequestMessage @this) => @this.Assistant;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(global::Groq.ChatCompletionRequestAssistantMessage? value)
        {
            Assistant = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Groq.ChatCompletionRequestToolMessage? Tool { get; init; }
#else
        public global::Groq.ChatCompletionRequestToolMessage? Tool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Tool))]
#endif
        public bool IsTool => Tool != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestMessage(global::Groq.ChatCompletionRequestToolMessage value) => new ChatCompletionRequestMessage((global::Groq.ChatCompletionRequestToolMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Groq.ChatCompletionRequestToolMessage?(ChatCompletionRequestMessage @this) => @this.Tool;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(global::Groq.ChatCompletionRequestToolMessage? value)
        {
            Tool = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Groq.ChatCompletionRequestFunctionMessage? Function { get; init; }
#else
        public global::Groq.ChatCompletionRequestFunctionMessage? Function { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Function))]
#endif
        public bool IsFunction => Function != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestMessage(global::Groq.ChatCompletionRequestFunctionMessage value) => new ChatCompletionRequestMessage((global::Groq.ChatCompletionRequestFunctionMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Groq.ChatCompletionRequestFunctionMessage?(ChatCompletionRequestMessage @this) => @this.Function;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(global::Groq.ChatCompletionRequestFunctionMessage? value)
        {
            Function = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(
            global::Groq.ChatCompletionRequestMessageDiscriminatorRole? role,
            global::Groq.ChatCompletionRequestSystemMessage? system,
            global::Groq.ChatCompletionRequestUserMessage? user,
            global::Groq.ChatCompletionRequestAssistantMessage? assistant,
            global::Groq.ChatCompletionRequestToolMessage? tool,
            global::Groq.ChatCompletionRequestFunctionMessage? function
            )
        {
            Role = role;

            System = system;
            User = user;
            Assistant = assistant;
            Tool = tool;
            Function = function;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Function as object ??
            Tool as object ??
            Assistant as object ??
            User as object ??
            System as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            System?.ToString() ??
            User?.ToString() ??
            Assistant?.ToString() ??
            Tool?.ToString() ??
            Function?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSystem && !IsUser && !IsAssistant && !IsTool && !IsFunction || !IsSystem && IsUser && !IsAssistant && !IsTool && !IsFunction || !IsSystem && !IsUser && IsAssistant && !IsTool && !IsFunction || !IsSystem && !IsUser && !IsAssistant && IsTool && !IsFunction || !IsSystem && !IsUser && !IsAssistant && !IsTool && IsFunction;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Groq.ChatCompletionRequestSystemMessage?, TResult>? system = null,
            global::System.Func<global::Groq.ChatCompletionRequestUserMessage?, TResult>? user = null,
            global::System.Func<global::Groq.ChatCompletionRequestAssistantMessage?, TResult>? assistant = null,
            global::System.Func<global::Groq.ChatCompletionRequestToolMessage?, TResult>? tool = null,
            global::System.Func<global::Groq.ChatCompletionRequestFunctionMessage?, TResult>? function = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSystem && system != null)
            {
                return system(System!);
            }
            else if (IsUser && user != null)
            {
                return user(User!);
            }
            else if (IsAssistant && assistant != null)
            {
                return assistant(Assistant!);
            }
            else if (IsTool && tool != null)
            {
                return tool(Tool!);
            }
            else if (IsFunction && function != null)
            {
                return function(Function!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Groq.ChatCompletionRequestSystemMessage?>? system = null,
            global::System.Action<global::Groq.ChatCompletionRequestUserMessage?>? user = null,
            global::System.Action<global::Groq.ChatCompletionRequestAssistantMessage?>? assistant = null,
            global::System.Action<global::Groq.ChatCompletionRequestToolMessage?>? tool = null,
            global::System.Action<global::Groq.ChatCompletionRequestFunctionMessage?>? function = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSystem)
            {
                system?.Invoke(System!);
            }
            else if (IsUser)
            {
                user?.Invoke(User!);
            }
            else if (IsAssistant)
            {
                assistant?.Invoke(Assistant!);
            }
            else if (IsTool)
            {
                tool?.Invoke(Tool!);
            }
            else if (IsFunction)
            {
                function?.Invoke(Function!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                System,
                typeof(global::Groq.ChatCompletionRequestSystemMessage),
                User,
                typeof(global::Groq.ChatCompletionRequestUserMessage),
                Assistant,
                typeof(global::Groq.ChatCompletionRequestAssistantMessage),
                Tool,
                typeof(global::Groq.ChatCompletionRequestToolMessage),
                Function,
                typeof(global::Groq.ChatCompletionRequestFunctionMessage),
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
        public bool Equals(ChatCompletionRequestMessage other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Groq.ChatCompletionRequestSystemMessage?>.Default.Equals(System, other.System) &&
                global::System.Collections.Generic.EqualityComparer<global::Groq.ChatCompletionRequestUserMessage?>.Default.Equals(User, other.User) &&
                global::System.Collections.Generic.EqualityComparer<global::Groq.ChatCompletionRequestAssistantMessage?>.Default.Equals(Assistant, other.Assistant) &&
                global::System.Collections.Generic.EqualityComparer<global::Groq.ChatCompletionRequestToolMessage?>.Default.Equals(Tool, other.Tool) &&
                global::System.Collections.Generic.EqualityComparer<global::Groq.ChatCompletionRequestFunctionMessage?>.Default.Equals(Function, other.Function) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionRequestMessage obj1, ChatCompletionRequestMessage obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionRequestMessage>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionRequestMessage obj1, ChatCompletionRequestMessage obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionRequestMessage o && Equals(o);
        }
    }
}

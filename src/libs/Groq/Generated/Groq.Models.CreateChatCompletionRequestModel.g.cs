
#nullable enable

namespace Groq
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateChatCompletionRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        Gemma7bIt,
        /// <summary>
        /// 
        /// </summary>
        Llama370b8192,
        /// <summary>
        /// 
        /// </summary>
        Llama38b8192,
        /// <summary>
        /// 
        /// </summary>
        Mixtral8x7b32768,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChatCompletionRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionRequestModel value)
        {
            return value switch
            {
                CreateChatCompletionRequestModel.Gemma7bIt => "gemma-7b-it",
                CreateChatCompletionRequestModel.Llama370b8192 => "llama3-70b-8192",
                CreateChatCompletionRequestModel.Llama38b8192 => "llama3-8b-8192",
                CreateChatCompletionRequestModel.Mixtral8x7b32768 => "mixtral-8x7b-32768",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "gemma-7b-it" => CreateChatCompletionRequestModel.Gemma7bIt,
                "llama3-70b-8192" => CreateChatCompletionRequestModel.Llama370b8192,
                "llama3-8b-8192" => CreateChatCompletionRequestModel.Llama38b8192,
                "mixtral-8x7b-32768" => CreateChatCompletionRequestModel.Mixtral8x7b32768,
                _ => null,
            };
        }
    }
}
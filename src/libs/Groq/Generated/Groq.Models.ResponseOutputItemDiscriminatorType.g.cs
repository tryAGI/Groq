
#nullable enable

namespace Groq
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseOutputItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Message,
        /// <summary>
        /// 
        /// </summary>
        FunctionCall,
        /// <summary>
        /// 
        /// </summary>
        Reasoning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseOutputItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOutputItemDiscriminatorType value)
        {
            return value switch
            {
                ResponseOutputItemDiscriminatorType.Message => "message",
                ResponseOutputItemDiscriminatorType.FunctionCall => "function_call",
                ResponseOutputItemDiscriminatorType.Reasoning => "reasoning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOutputItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "message" => ResponseOutputItemDiscriminatorType.Message,
                "function_call" => ResponseOutputItemDiscriminatorType.FunctionCall,
                "reasoning" => ResponseOutputItemDiscriminatorType.Reasoning,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Groq
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseInputItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Message,
        /// <summary>
        /// 
        /// </summary>
        ItemReference,
        /// <summary>
        /// 
        /// </summary>
        FunctionCall,
        /// <summary>
        /// 
        /// </summary>
        FunctionCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseInputItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseInputItemDiscriminatorType value)
        {
            return value switch
            {
                ResponseInputItemDiscriminatorType.Message => "message",
                ResponseInputItemDiscriminatorType.ItemReference => "item_reference",
                ResponseInputItemDiscriminatorType.FunctionCall => "function_call",
                ResponseInputItemDiscriminatorType.FunctionCallOutput => "function_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseInputItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "message" => ResponseInputItemDiscriminatorType.Message,
                "item_reference" => ResponseInputItemDiscriminatorType.ItemReference,
                "function_call" => ResponseInputItemDiscriminatorType.FunctionCall,
                "function_call_output" => ResponseInputItemDiscriminatorType.FunctionCallOutput,
                _ => null,
            };
        }
    }
}
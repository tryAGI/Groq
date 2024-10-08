
#nullable enable

namespace Groq
{
    /// <summary>
    /// The format to return the embeddings in. Can only be `float` or `base64`.<br/>
    /// Default Value: float<br/>
    /// Example: float
    /// </summary>
    public enum CreateEmbeddingRequestEncodingFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Float,
        /// <summary>
        /// 
        /// </summary>
        Base64,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEmbeddingRequestEncodingFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEmbeddingRequestEncodingFormat value)
        {
            return value switch
            {
                CreateEmbeddingRequestEncodingFormat.Float => "float",
                CreateEmbeddingRequestEncodingFormat.Base64 => "base64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEmbeddingRequestEncodingFormat? ToEnum(string value)
        {
            return value switch
            {
                "float" => CreateEmbeddingRequestEncodingFormat.Float,
                "base64" => CreateEmbeddingRequestEncodingFormat.Base64,
                _ => null,
            };
        }
    }
}
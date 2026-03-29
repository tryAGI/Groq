
#nullable enable

namespace Groq
{
    /// <summary>
    /// The endpoint to be used for all requests in the batch. Currently `/v1/chat/completions` is supported.
    /// </summary>
    public enum CreateBatchRequestEndpoint
    {
        /// <summary>
        /// 
        /// </summary>
        Dividev1DividechatDividecompletions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateBatchRequestEndpointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBatchRequestEndpoint value)
        {
            return value switch
            {
                CreateBatchRequestEndpoint.Dividev1DividechatDividecompletions => "/v1/chat/completions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBatchRequestEndpoint? ToEnum(string value)
        {
            return value switch
            {
                "/v1/chat/completions" => CreateBatchRequestEndpoint.Dividev1DividechatDividecompletions,
                _ => null,
            };
        }
    }
}
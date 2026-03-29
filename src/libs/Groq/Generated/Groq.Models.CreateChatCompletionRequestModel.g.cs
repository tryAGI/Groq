
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
        CompoundBeta,
        /// <summary>
        /// 
        /// </summary>
        CompoundBetaMini,
        /// <summary>
        /// 
        /// </summary>
        Gemma29bIt,
        /// <summary>
        /// 
        /// </summary>
        Llama318bInstant,
        /// <summary>
        /// 
        /// </summary>
        Llama3370bVersatile,
        /// <summary>
        /// 
        /// </summary>
        MetaLlamaDividellama4Maverick17b128eInstruct,
        /// <summary>
        /// 
        /// </summary>
        MetaLlamaDividellama4Scout17b16eInstruct,
        /// <summary>
        /// 
        /// </summary>
        MetaLlamaDividellamaGuard412b,
        /// <summary>
        /// 
        /// </summary>
        MoonshotaiDividekimiK2Instruct,
        /// <summary>
        /// 
        /// </summary>
        OpenaiDividegptOss120b,
        /// <summary>
        /// 
        /// </summary>
        OpenaiDividegptOss20b,
        /// <summary>
        /// 
        /// </summary>
        QwenDivideqwen332b,
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
                CreateChatCompletionRequestModel.CompoundBeta => "compound-beta",
                CreateChatCompletionRequestModel.CompoundBetaMini => "compound-beta-mini",
                CreateChatCompletionRequestModel.Gemma29bIt => "gemma2-9b-it",
                CreateChatCompletionRequestModel.Llama318bInstant => "llama-3.1-8b-instant",
                CreateChatCompletionRequestModel.Llama3370bVersatile => "llama-3.3-70b-versatile",
                CreateChatCompletionRequestModel.MetaLlamaDividellama4Maverick17b128eInstruct => "meta-llama/llama-4-maverick-17b-128e-instruct",
                CreateChatCompletionRequestModel.MetaLlamaDividellama4Scout17b16eInstruct => "meta-llama/llama-4-scout-17b-16e-instruct",
                CreateChatCompletionRequestModel.MetaLlamaDividellamaGuard412b => "meta-llama/llama-guard-4-12b",
                CreateChatCompletionRequestModel.MoonshotaiDividekimiK2Instruct => "moonshotai/kimi-k2-instruct",
                CreateChatCompletionRequestModel.OpenaiDividegptOss120b => "openai/gpt-oss-120b",
                CreateChatCompletionRequestModel.OpenaiDividegptOss20b => "openai/gpt-oss-20b",
                CreateChatCompletionRequestModel.QwenDivideqwen332b => "qwen/qwen3-32b",
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
                "compound-beta" => CreateChatCompletionRequestModel.CompoundBeta,
                "compound-beta-mini" => CreateChatCompletionRequestModel.CompoundBetaMini,
                "gemma2-9b-it" => CreateChatCompletionRequestModel.Gemma29bIt,
                "llama-3.1-8b-instant" => CreateChatCompletionRequestModel.Llama318bInstant,
                "llama-3.3-70b-versatile" => CreateChatCompletionRequestModel.Llama3370bVersatile,
                "meta-llama/llama-4-maverick-17b-128e-instruct" => CreateChatCompletionRequestModel.MetaLlamaDividellama4Maverick17b128eInstruct,
                "meta-llama/llama-4-scout-17b-16e-instruct" => CreateChatCompletionRequestModel.MetaLlamaDividellama4Scout17b16eInstruct,
                "meta-llama/llama-guard-4-12b" => CreateChatCompletionRequestModel.MetaLlamaDividellamaGuard412b,
                "moonshotai/kimi-k2-instruct" => CreateChatCompletionRequestModel.MoonshotaiDividekimiK2Instruct,
                "openai/gpt-oss-120b" => CreateChatCompletionRequestModel.OpenaiDividegptOss120b,
                "openai/gpt-oss-20b" => CreateChatCompletionRequestModel.OpenaiDividegptOss20b,
                "qwen/qwen3-32b" => CreateChatCompletionRequestModel.QwenDivideqwen332b,
                _ => null,
            };
        }
    }
}
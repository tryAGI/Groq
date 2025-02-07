
#nullable enable

namespace Groq
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionObject
    {
        /// <summary>
        /// A description of what the function does, used by the model to choose when and how to call the function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The name of the function to be called. Must be a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The parameters the functions accepts, described as a JSON Schema object. See the docs on [tool use](/docs/tool-use) for examples, and the [JSON Schema reference](https://json-schema.org/understanding-json-schema/) for documentation about the format. <br/>
        /// Omitting `parameters` defines a function with an empty parameter list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionObject" /> class.
        /// </summary>
        /// <param name="description">
        /// A description of what the function does, used by the model to choose when and how to call the function.
        /// </param>
        /// <param name="name">
        /// The name of the function to be called. Must be a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64.
        /// </param>
        /// <param name="parameters">
        /// The parameters the functions accepts, described as a JSON Schema object. See the docs on [tool use](/docs/tool-use) for examples, and the [JSON Schema reference](https://json-schema.org/understanding-json-schema/) for documentation about the format. <br/>
        /// Omitting `parameters` defines a function with an empty parameter list.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionObject(
            string name,
            string? description,
            object? parameters)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionObject" /> class.
        /// </summary>
        public FunctionObject()
        {
        }
    }
}
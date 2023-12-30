// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// TestCollectionEndingWithWordList
    /// </summary>
    public partial class TestCollectionEndingWithWordList : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestCollectionEndingWithWordList" /> class.
        /// </summary>
        /// <param name="value">value</param>
        [JsonConstructor]
        public TestCollectionEndingWithWordList(Option<string?> value = default)
        {
            ValueOption = value;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Value
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ValueOption { get; private set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [JsonPropertyName("value")]
        public string? Value { get { return this. ValueOption; } set { this.ValueOption = new(value); } }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestCollectionEndingWithWordList {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="TestCollectionEndingWithWordList" />
    /// </summary>
    public class TestCollectionEndingWithWordListJsonConverter : JsonConverter<TestCollectionEndingWithWordList>
    {
        /// <summary>
        /// Deserializes json to <see cref="TestCollectionEndingWithWordList" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TestCollectionEndingWithWordList Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> value = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "value":
                            value = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (value.IsSet && value.Value == null)
                throw new ArgumentNullException(nameof(value), "Property is not nullable for class TestCollectionEndingWithWordList.");

            return new TestCollectionEndingWithWordList(value);
        }

        /// <summary>
        /// Serializes a <see cref="TestCollectionEndingWithWordList" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="testCollectionEndingWithWordList"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TestCollectionEndingWithWordList testCollectionEndingWithWordList, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, testCollectionEndingWithWordList, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TestCollectionEndingWithWordList" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="testCollectionEndingWithWordList"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, TestCollectionEndingWithWordList testCollectionEndingWithWordList, JsonSerializerOptions jsonSerializerOptions)
        {
            if (testCollectionEndingWithWordList.ValueOption.IsSet && testCollectionEndingWithWordList.Value == null)
                throw new ArgumentNullException(nameof(testCollectionEndingWithWordList.Value), "Property is required for class TestCollectionEndingWithWordList.");

            if (testCollectionEndingWithWordList.ValueOption.IsSet)
                writer.WriteString("value", testCollectionEndingWithWordList.Value);
        }
    }
}

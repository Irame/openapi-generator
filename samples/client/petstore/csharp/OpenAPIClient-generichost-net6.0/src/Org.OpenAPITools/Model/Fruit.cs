// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

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
    /// Fruit
    /// </summary>
    public partial class Fruit : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Fruit" /> class.
        /// </summary>
        /// <param name="apple"></param>
        /// <param name="color">color</param>
        public Fruit(Apple apple, Option<string> color = default)
        {
            Apple = apple;
            ColorOption = color;
            OnCreated();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Fruit" /> class.
        /// </summary>
        /// <param name="banana"></param>
        /// <param name="color">color</param>
        public Fruit(Banana banana, Option<string> color = default)
        {
            Banana = banana;
            ColorOption = color;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Apple
        /// </summary>
        public Apple Apple { get; set; }

        /// <summary>
        /// Gets or Sets Banana
        /// </summary>
        public Banana Banana { get; set; }

        /// <summary>
        /// Used to track the state of Color
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> ColorOption { get; private set; }

        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [JsonPropertyName("color")]
        public string Color { get { return this. ColorOption; } set { this.ColorOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Fruit {\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
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
    /// A Json converter for type <see cref="Fruit" />
    /// </summary>
    public class FruitJsonConverter : JsonConverter<Fruit>
    {
        /// <summary>
        /// Deserializes json to <see cref="Fruit" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Fruit Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> color = default;

            Apple apple = default;
            Banana banana = default;

            Utf8JsonReader utf8JsonReaderOneOf = utf8JsonReader;
            while (utf8JsonReaderOneOf.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReaderOneOf.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReaderOneOf.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReaderOneOf.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReaderOneOf.CurrentDepth)
                    break;

                if (utf8JsonReaderOneOf.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReaderOneOf.CurrentDepth - 1)
                {
                    Utf8JsonReader utf8JsonReaderApple = utf8JsonReader;
                    OpenAPIClientUtils.TryDeserialize<Apple>(ref utf8JsonReaderApple, jsonSerializerOptions, out apple);

                    Utf8JsonReader utf8JsonReaderBanana = utf8JsonReader;
                    OpenAPIClientUtils.TryDeserialize<Banana>(ref utf8JsonReaderBanana, jsonSerializerOptions, out banana);
                }
            }

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "color":
                            color = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (color.IsSet && color.Value == null)
                throw new ArgumentNullException(nameof(color), "Property is not nullable for class Fruit.");

            if (apple != null)
                return new Fruit(apple, color);

            if (banana != null)
                return new Fruit(banana, color);

            throw new JsonException();
        }

        /// <summary>
        /// Serializes a <see cref="Fruit" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="fruit"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Fruit fruit, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, fruit, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Fruit" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="fruit"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, Fruit fruit, JsonSerializerOptions jsonSerializerOptions)
        {
            if (fruit.ColorOption.IsSet && fruit.Color == null)
                throw new ArgumentNullException(nameof(fruit.Color), "Property is required for class Fruit.");

            if (fruit.ColorOption.IsSet)
                writer.WriteString("color", fruit.Color);
        }
    }
}

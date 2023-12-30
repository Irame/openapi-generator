// <auto-generated>
/*
 * Example
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
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
    /// A representation of a child
    /// </summary>
    public partial class Child : Person, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Child" /> class.
        /// </summary>
        /// <param name="age">age</param>
        /// <param name="firstName">firstName</param>
        /// <param name="lastName">lastName</param>
        /// <param name="type">type</param>
        /// <param name="boosterSeat">boosterSeat</param>
        [JsonConstructor]
        public Child(Option<int?> age = default, Option<string?> firstName = default, Option<string?> lastName = default, Option<string?> type = default, Option<bool?> boosterSeat = default) : base(firstName, lastName, type)
        {
            AgeOption = age;
            BoosterSeatOption = boosterSeat;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Age
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> AgeOption { get; private set; }

        /// <summary>
        /// Gets or Sets Age
        /// </summary>
        [JsonPropertyName("age")]
        public int? Age { get { return this. AgeOption; } set { this.AgeOption = new(value); } }

        /// <summary>
        /// Used to track the state of BoosterSeat
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> BoosterSeatOption { get; private set; }

        /// <summary>
        /// Gets or Sets BoosterSeat
        /// </summary>
        [JsonPropertyName("boosterSeat")]
        public bool? BoosterSeat { get { return this. BoosterSeatOption; } set { this.BoosterSeatOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Child {\n");
            sb.Append("  ").Append(base.ToString()?.Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Age: ").Append(Age).Append("\n");
            sb.Append("  BoosterSeat: ").Append(BoosterSeat).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="Child" />
    /// </summary>
    public class ChildJsonConverter : JsonConverter<Child>
    {
        /// <summary>
        /// Deserializes json to <see cref="Child" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Child Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> age = default;
            Option<string?> firstName = default;
            Option<string?> lastName = default;
            Option<string?> type = default;
            Option<bool?> boosterSeat = default;

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
                        case "age":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                age = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "firstName":
                            firstName = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "lastName":
                            lastName = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "$_type":
                            type = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "boosterSeat":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                boosterSeat = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (age.IsSet && age.Value == null)
                throw new ArgumentNullException(nameof(age), "Property is not nullable for class Child.");

            if (firstName.IsSet && firstName.Value == null)
                throw new ArgumentNullException(nameof(firstName), "Property is not nullable for class Child.");

            if (lastName.IsSet && lastName.Value == null)
                throw new ArgumentNullException(nameof(lastName), "Property is not nullable for class Child.");

            if (type.IsSet && type.Value == null)
                throw new ArgumentNullException(nameof(type), "Property is not nullable for class Child.");

            if (boosterSeat.IsSet && boosterSeat.Value == null)
                throw new ArgumentNullException(nameof(boosterSeat), "Property is not nullable for class Child.");

            return new Child(age, firstName, lastName, type, boosterSeat);
        }

        /// <summary>
        /// Serializes a <see cref="Child" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="child"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Child child, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, child, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Child" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="child"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, Child child, JsonSerializerOptions jsonSerializerOptions)
        {
            if (child.FirstNameOption.IsSet && child.FirstName == null)
                throw new ArgumentNullException(nameof(child.FirstName), "Property is required for class Child.");

            if (child.LastNameOption.IsSet && child.LastName == null)
                throw new ArgumentNullException(nameof(child.LastName), "Property is required for class Child.");

            if (child.TypeOption.IsSet && child.Type == null)
                throw new ArgumentNullException(nameof(child.Type), "Property is required for class Child.");

            if (child.AgeOption.IsSet)
                writer.WriteNumber("age", child.AgeOption.Value!.Value);

            if (child.FirstNameOption.IsSet)
                writer.WriteString("firstName", child.FirstName);

            if (child.LastNameOption.IsSet)
                writer.WriteString("lastName", child.LastName);

            if (child.TypeOption.IsSet)
                writer.WriteString("$_type", child.Type);

            if (child.BoosterSeatOption.IsSet)
                writer.WriteBoolean("boosterSeat", child.BoosterSeatOption.Value!.Value);
        }
    }
}

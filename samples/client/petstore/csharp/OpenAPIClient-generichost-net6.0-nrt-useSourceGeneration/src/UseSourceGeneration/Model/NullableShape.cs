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
using OpenAPIClientUtils = UseSourceGeneration.Client.ClientUtils;
using System.Text.Json.Serialization.Metadata;
using UseSourceGeneration.Client;

namespace UseSourceGeneration.Model
{
    /// <summary>
    /// The value may be a shape or the &#39;null&#39; value. The &#39;nullable&#39; attribute was introduced in OAS schema &gt;&#x3D; 3.0 and has been deprecated in OAS schema &gt;&#x3D; 3.1.
    /// </summary>
    public partial class NullableShape : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NullableShape" /> class.
        /// </summary>
        /// <param name="triangle"></param>
        /// <param name="shapeType">shapeType</param>
        public NullableShape(Triangle triangle, string shapeType)
        {
            Triangle = triangle;
            ShapeType = shapeType;
            OnCreated();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NullableShape" /> class.
        /// </summary>
        /// <param name="quadrilateral"></param>
        /// <param name="shapeType">shapeType</param>
        public NullableShape(Quadrilateral quadrilateral, string shapeType)
        {
            Quadrilateral = quadrilateral;
            ShapeType = shapeType;
            OnCreated();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NullableShape" /> class to be used with object initializers.
        /// </summary>
        public NullableShape() {}

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Triangle
        /// </summary>
        public Triangle? Triangle { get; set; }

        /// <summary>
        /// Gets or Sets Quadrilateral
        /// </summary>
        public Quadrilateral? Quadrilateral { get; set; }

        /// <summary>
        /// Gets or Sets ShapeType
        /// </summary>
        [JsonPropertyName("shapeType")]
        public required string ShapeType { get; set; }

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
            sb.Append("class NullableShape {\n");
            sb.Append("  ShapeType: ").Append(ShapeType).Append("\n");
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="NullableShape" />
    /// </summary>
    public class NullableShapeJsonConverter : JsonConverter<NullableShape>
    {
        /// <summary>
        /// Deserializes json to <see cref="NullableShape" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override NullableShape Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> shapeType = default;

            Quadrilateral? quadrilateral = null;
            Triangle? triangle = null;

            Utf8JsonReader utf8JsonReaderDiscriminator = utf8JsonReader;
            while (utf8JsonReaderDiscriminator.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReaderDiscriminator.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReaderDiscriminator.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReaderDiscriminator.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReaderDiscriminator.CurrentDepth)
                    break;

                if (utf8JsonReaderDiscriminator.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReaderDiscriminator.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReaderDiscriminator.GetString();
                    utf8JsonReaderDiscriminator.Read();
                    if (localVarJsonPropertyName?.Equals("shapeType") ?? false)
                    {
                        string? discriminator = utf8JsonReaderDiscriminator.GetString();
                        if (discriminator?.Equals("Quadrilateral") ?? false)
                        {
                            Utf8JsonReader utf8JsonReaderQuadrilateral = utf8JsonReader;
                            quadrilateral = JsonSerializer.Deserialize<Quadrilateral>(ref utf8JsonReaderQuadrilateral, jsonSerializerOptions);
                        }
                        if (discriminator?.Equals("Triangle") ?? false)
                        {
                            Utf8JsonReader utf8JsonReaderTriangle = utf8JsonReader;
                            triangle = JsonSerializer.Deserialize<Triangle>(ref utf8JsonReaderTriangle, jsonSerializerOptions);
                        }
                    }
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
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "shapeType":
                            shapeType = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!shapeType.IsSet)
                throw new ArgumentException("Property is required for class NullableShape.", nameof(shapeType));

            if (shapeType.IsSet && shapeType.Value == null)
                throw new ArgumentNullException(nameof(shapeType), "Property is not nullable for class NullableShape.");

            if (quadrilateral != null)
                return new NullableShape(quadrilateral, shapeType.Value!);

            if (triangle != null)
                return new NullableShape(triangle, shapeType.Value!);

            throw new JsonException();
        }

        /// <summary>
        /// Serializes a <see cref="NullableShape" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="nullableShape"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, NullableShape nullableShape, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            if (nullableShape.Quadrilateral != null) {
                QuadrilateralJsonConverter quadrilateralJsonConverter = (QuadrilateralJsonConverter) jsonSerializerOptions.Converters.First(c => c.CanConvert(nullableShape.Quadrilateral.GetType()));
                quadrilateralJsonConverter.WriteProperties(ref writer, nullableShape.Quadrilateral, jsonSerializerOptions);
            }

            if (nullableShape.Triangle != null) {
                TriangleJsonConverter triangleJsonConverter = (TriangleJsonConverter) jsonSerializerOptions.Converters.First(c => c.CanConvert(nullableShape.Triangle.GetType()));
                triangleJsonConverter.WriteProperties(ref writer, nullableShape.Triangle, jsonSerializerOptions);
            }

            WriteProperties(ref writer, nullableShape, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="NullableShape" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="nullableShape"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, NullableShape nullableShape, JsonSerializerOptions jsonSerializerOptions)
        {
            if (nullableShape.ShapeType == null)
                throw new ArgumentNullException(nameof(nullableShape.ShapeType), "Property is required for class NullableShape.");

            writer.WriteString("shapeType", nullableShape.ShapeType);
        }
    }

    /// <summary>
    /// The NullableShapeSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(NullableShape))]
    public partial class NullableShapeSerializationContext : JsonSerializerContext { }
}

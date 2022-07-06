using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sepidar.api.Base.JsonConverters
{
    public class DictionaryInt64Converter : JsonConverter<Dictionary<Int64, string>>
    {
        public override Dictionary<Int64, string> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException();
            }

            var value = new Dictionary<Int64, string>();

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject)
                {
                    return value;
                }

                string keyString = reader.GetString();

                if (!Int64.TryParse(keyString, out Int64 keyAsInt64))
                {
                    throw new JsonException($"Unable to convert \"{keyString}\" to System.Int64.");
                }

                reader.Read();

                string itemValue = reader.GetString();

                value.Add(keyAsInt64, itemValue);
            }

            throw new JsonException("Error Occured");
        }

        public override void Write(Utf8JsonWriter writer, Dictionary<Int64, string> value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            foreach (KeyValuePair<Int64, string> item in value)
            {
                writer.WriteString(item.Key.ToString(), item.Value);
            }

            writer.WriteEndObject();
        }
    }
}

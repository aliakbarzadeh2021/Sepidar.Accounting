using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sepidar.api.Base.JsonConverters
{
    public class GuidJsonConverter : JsonConverter<Guid>
    {
        public override Guid Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return Guid.TryParse(reader.GetString(), out Guid result) ? result : Guid.Empty;
        }

        public override void Write(Utf8JsonWriter writer, Guid value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}

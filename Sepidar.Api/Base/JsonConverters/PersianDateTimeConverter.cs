using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sepidar.api.Base.JsonConverters
{
    public class PersianDateTimeConverter : JsonConverter<DateTime>
    {
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
            DateTime.TryParse(reader.GetString(), CultureInfo.GetCultureInfo("fa-ir"), new DateTimeStyles(), out var result)
                ? result
                : DateTime.Parse("1921-03-21");

        /// <summary>
        /// به درخواست فرانت تاریخ ها میلادی میره سمتشون
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dateTimeValue"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, DateTime dateTimeValue, JsonSerializerOptions options) =>
            writer.WriteStringValue(dateTimeValue.ToString("yyyy/MM/dd", CultureInfo.GetCultureInfo("fa-ir")));


    }
}

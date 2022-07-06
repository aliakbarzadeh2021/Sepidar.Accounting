using Sepidar.Infrastructure.Base;
using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Sepidar.Infrastructure.Helpers
{
    /// <summary>
    /// دریافت توضیحات enum
    /// </summary>
    public static class EnumHelper
    {
        public static string GetDescription(this System.Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(
                    typeof(DescriptionAttribute),
                    false);

            if (attributes != null &&
                attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }
        public static T ParseEnum<T>(this string enumValue)
        {
            var enumType = typeof(T);
            try
            {
                var intValue = int.Parse(enumValue);
                return (T)System.Enum.Parse(enumType, intValue.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                var customAttributes = enumType.GetCustomAttributes(typeof(DescriptionAttribute)).First();
                throw new ManagedException($"نوع داده ورودی برای {customAttributes} صحیح نیست");
            }
        }
        public static TEnum ParseEnum<TEnum>(this int enumValue)
        {
            return ParseEnum<TEnum>(enumValue.ToString());
        }

        
        
    }
}

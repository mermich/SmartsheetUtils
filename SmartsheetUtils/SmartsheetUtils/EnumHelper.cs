using System;
using System.Globalization;
using System.Linq;

namespace SmartsheetUtils
{
    public static class EnumHelper
    {
        public static string GetSmartsheetValue<T>(this T e) where T : IConvertible
        {
            if (e is Enum)
            {
                Type type = e.GetType();

                foreach (int val in Enum.GetValues(type))
                {
                    if (val == e.ToInt32(CultureInfo.InvariantCulture))
                    {
                        var memInfo = type.GetMember(type.GetEnumName(val));
                        var descriptionAttribute = memInfo[0].GetCustomAttributes(typeof(SmartsheetValue), false).FirstOrDefault() as SmartsheetValue;

                        if (descriptionAttribute != null)
                        {
                            return descriptionAttribute.Value;
                        }
                        else
                        {
                            return e.ToString();
                        }
                    }
                }
            }

            return null; // could also return string.Empty
        }
    }
}

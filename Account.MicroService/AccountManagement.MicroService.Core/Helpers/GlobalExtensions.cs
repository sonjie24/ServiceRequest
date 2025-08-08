using System;
using System.Globalization;

namespace AccountManagement.Framework.Core
{
    public static class GlobalExtensions
    { 

        public static string FormatName(string str)
        {
            var cInfo = CultureInfo.InvariantCulture.TextInfo;
            // Set to Empty String all Null Parameters and Convert to Proper Casing
            var tmp = cInfo.ToTitleCase((str != null ? str : "").Trim().ToLower());
            return tmp;
        }

        public static DateTime ToDateTime(this string s,
                  string format = "ddMMyyyy", string cultureString = "tr-TR")
        {
            try
            {
                var r = DateTime.ParseExact(
                    s: s,
                    format: format,
                    provider: CultureInfo.GetCultureInfo(cultureString));
                return r;
            }
            catch (FormatException)
            {
                throw;
            }
            catch (CultureNotFoundException)
            {
                throw; // Given Culture is not supported culture
            }
        }

        public static DateTime ToDateTime(this string s,
                    string format, CultureInfo culture)
        {
            try
            {
                var r = DateTime.ParseExact(s: s, format: format,
                                        provider: culture);
                return r;
            }
            catch (FormatException)
            {
                throw;
            }
            catch (CultureNotFoundException)
            {
                throw; // Given Culture is not supported culture
            }

        }
    }



}

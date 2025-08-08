using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Text;
using TimeZoneConverter;

namespace AccountManagement.Framework.Core  
{
    public static class Common
    {
        /// <summary>
        ///     Get the full name of a person.
        /// </summary>
        /// <param name="prefix">Prefix Name (Like Mr/Ms/Mrs)</param>
        /// <param name="fName">First Name</param>
        /// <param name="mName">Middle Name</param>
        /// <param name="lName">Last Name</param>
        /// <param name="suffix">Suffix Name (Like Jr/Sr/III)</param>
        /// <param name="isMiddleInitial">Set true to enable middle initial</param>
        /// <returns>Returns a complete name</returns>
        public static string GetCompleteName(string prefix, string fName, string mName, string lName, string suffix, bool isMiddleInitial)
        {
            var cInfo = CultureInfo.InvariantCulture.TextInfo;
            // Set to Empty String all Null Parameters and Convert to Proper Casing
            var prefix_p = cInfo.ToTitleCase((prefix != null ? prefix : "").Trim().ToLower());
            var fName_p = cInfo.ToTitleCase((fName != null ? fName : "").Trim().ToLower());
            var mName_p = cInfo.ToTitleCase((mName != null ? mName : "").Trim().ToLower());
            var lName_p = cInfo.ToTitleCase((lName != null ? lName : "").Trim().ToLower());
            var suffix_p = cInfo.ToTitleCase((suffix != null ? suffix : "").Trim().ToLower());

            return String.Format("{0}{1}{2} {3}{4}",
                prefix_p.Length > 0 ? prefix_p + " " : "",
                fName_p.Length > 0 ? fName_p : "",
                mName_p.Length > 0 ? (" " + (isMiddleInitial ? (mName_p.Substring(0, 1) + ".") : mName_p)) : "",
                lName_p.Length > 0 ? lName_p : "",
                suffix_p.Length > 0 ? " " + suffix_p : "");
        }
        
           
        public static DateTime getDateNow()
        {
            var timeZoneInfo = TZConvert.GetTimeZoneInfo("Taipei Standard Time");// TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            return TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timeZoneInfo);
        }


        public static String NewGUID()
        {
            return Guid.NewGuid().ToString() + "-" + new Random().Next(100000, 999999) + "-" + new Random().Next(1000, 9999); 
        }

        //public static String CodeGenarator()
        //{
        //    return new Random().Next(100000, 999999).ToString();
        //}        

        //public static Double GetDistance(string point1, string point2)
        //{
        //    double distance = 0;
        //    try
        //    {
        //        string[] tmpPoint1 = point1.Split(',');
        //        string[] tmpPoint2 = point2.Split(',');
                   
        //        Point p1 = new Point(Int32.Parse(tmpPoint1[0]), Int32.Parse(tmpPoint1[1]));
        //        Point p2 = new Point(Int32.Parse(tmpPoint2[0]), Int32.Parse(tmpPoint2[1]));

        //        distance = Math.Sqrt((double)Math.Pow((p1.X - p2.X), 2.0) + (double)Math.Pow((p1.Y - p2.Y), 2.0));
                                
        //    }
        //    catch (Exception)
        //    {
              
        //    }
        //    return distance;
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace CodeDocs.Helpers
{
    public static class HelperFunctions
    {
        /// <summary>
        /// Splits a string into an array by commas.  Comma spaces are reduced to commas before parsing.
        /// </summary>
        /// <param name="value">Value to split to tags</param>
        public static string[] ToTags(this string value)
        {
            return string.IsNullOrEmpty(value) ? new string[0] : value.Replace(", ", ",").Split(',');
        }

        /// <summary>
        /// Converts an integer value from a 4 digit year, 2 digit month, and 2 digit day format into an actual DateTime.
        /// </summary>
        /// <param name="yyyymmdd">4 digit year, 2 digit month, and 2 digit day format</param>
        public static DateTime? ToDate(this int? yyyymmdd)
        {
            return yyyymmdd.HasValue ? (DateTime?) yyyymmdd.Value.ToDate() : null;
        }

        /// <summary>
        /// Converts an integer value from a 4 digit year, 2 digit month, and 2 digit day format into an actual DateTime.
        /// </summary>
        /// <param name="yyyymmdd">4 digit year, 2 digit month, and 2 digit day format</param>
        public static DateTime ToDate(this int yyyymmdd)
        {
            return DateTime.ParseExact(yyyymmdd.ToString(), "yyyyMMdd", CultureInfo.InvariantCulture);
        }

    }
}

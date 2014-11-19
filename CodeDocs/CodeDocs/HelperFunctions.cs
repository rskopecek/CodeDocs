using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CodeDocs.Helpers
{
    public static class HelperFunctions
    {

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

        /// <summary>
        /// Short-hand for Uri.IsWellFormedUriString(value, UriKind.RelativeOrAbsolute)
        /// </summary>
        public static bool IsUri(this string value)
        {
            return Uri.IsWellFormedUriString(value, UriKind.RelativeOrAbsolute);
        }

    }
}

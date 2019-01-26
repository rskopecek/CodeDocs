using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace CodeDocs
{
    public static class CodeDocExtensions
    {
        internal static long? ParseNullable(this long value)
            => value == long.MinValue ? (long?)null : value;

        internal static DateTime? ParseNullableIsoDate(this int value)
        {
            if (value == int.MinValue) return null;

            var max = int.Parse(DateTime.UtcNow.AddDays(1).ToString("yyyyMMdd"));

            if (value > max) return DateTime.MinValue.Date;

            try
            {
                return DateTime.ParseExact(value.ToString(), "yyyyMMdd", CultureInfo.InvariantCulture);
            }
            catch { return DateTime.MinValue.Date; }

        }

        internal static readonly char[] TagDelimiters = { ',' };

        internal static IEnumerable<string> ParseTags(this string value)
            => value.Trim()
                .Split(TagDelimiters, StringSplitOptions.RemoveEmptyEntries)
                .Select(t => t.Trim().ToLowerInvariant());

        internal static string CleanseComment(this string value)
            => value.Trim()
                    .Replace("\r", "").Replace("\n", "") // No new line characters
                    .Replace("\t", "") // No tabs
                    .Replace("\"",""); // No quotes

        public static string ToCsv(this IEnumerable<ICodeDoc> docs, bool withHeader = true)
        {
            var sb = new StringBuilder();

            if(withHeader)
                sb.AppendLine(CodeDocsAttribute.ToStringHeader);

            foreach (var doc in docs)
                sb.AppendLine(doc.ToString());

            return sb.ToString();
        }

        public static string ToCsv(this ICodeDoc doc)
            => $"{CodeDocsAttribute.ToStringHeader}{Environment.NewLine}{doc.ToString()}";

    }
}

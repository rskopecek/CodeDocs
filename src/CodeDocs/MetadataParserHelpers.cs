using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Helpers
{
    public static class MetadataParserHelpers
    {
        /// <summary>
        /// Short-hand for Uri.IsWellFormedUriString(value, UriKind.RelativeOrAbsolute)
        /// </summary>
        public static bool IsUri(this string value)
        {
            return Uri.IsWellFormedUriString(value, UriKind.RelativeOrAbsolute);
        }

        public static IEnumerable<string> GetTags(this IEnumerable<string> values )
        {
            return values.Where(q => !q.Contains(":"));
        }

        public static IEnumerable<string> GetUris(this IEnumerable<string> values )
        {
            return values.Where(q => q.IsUri());
        }

        public static IEnumerable<Tuple<string, string>> GetKeyValues(this IEnumerable<string> values)
        {
            return values
                .Where(q => !q.IsUri() && q.Contains(":"))
                .Select(item => item.Split(':'))
                .Select(set => new Tuple<string, string>(set[0], set[1]));
        }

    }
}

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;

namespace CodeDocs.Detection
{
    public static partial class Scanner
    {

        /// <summary>
        /// Acquires all docs for the list of objects, including their members.
        /// </summary>
        public static IEnumerable<ICodeDoc> GetCodeDocs(this IEnumerable<object> items)
            => items.SelectMany(GetCodeDocs);

        /// <summary>
        /// Acquires all docs for the provided object, including the members.
        /// </summary>
        public static IEnumerable<ICodeDoc> GetCodeDocs(this object item)
            => item.GetType().GetCodeDocs();

    }
}

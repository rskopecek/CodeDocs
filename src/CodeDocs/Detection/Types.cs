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
        /// Acquires all docs for the type list, including members.  Considers nested type preference defaulting to true.
        /// </summary>
        public static IEnumerable<ICodeDoc> GetCodeDocs(this IEnumerable<Type> types, bool includeNestedTypes = true)
            => types.SelectMany(t => t.GetCodeDocs(includeNestedTypes));

        /// <summary>
        /// Acquires all docs for the type, including members.  Considers nested type preference defaulting to true.
        /// </summary>
        public static IEnumerable<ICodeDoc> GetCodeDocs(this Type type, bool includeNestedTypes = true)
            => GetCodeDocAttributes(type) // Type Docs
                .Concat(type.DetectMembers(includeNestedTypes).GetCodeDocs(type)); // Type.Member Docs

    }
}

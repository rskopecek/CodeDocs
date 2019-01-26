using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;
using static System.Reflection.BindingFlags;

namespace CodeDocs.Detection
{
    public static partial class Scanner
    {

        /// <summary>
        /// Acquires all docs for the provided member list.
        /// </summary>
        public static IEnumerable<ICodeDoc> GetCodeDocs(this IEnumerable<MemberInfo> members, Type type)
            => members.SelectMany(m => m.GetCodeDocs(type));

        /// <summary>
        /// Acquires all docs for the provided member.
        /// </summary>
        public static IEnumerable<ICodeDoc> GetCodeDocs(this MemberInfo member, Type type)
            => GetCodeDocAttributes(type, member);


        /// <summary>
        /// Acquires all the members of the given type, considering preference of nested types to prevent duplication.
        /// BindingFlags (Public, NonPublic, Static, Instance)
        /// </summary>
        public static IEnumerable<MemberInfo> DetectMembers(this Type type, bool includeNestedTypes)
            => type.GetMembers(Public | NonPublic | Static | Instance)
            .Where(m => includeNestedTypes || !(m is Type));
                    

    }
}

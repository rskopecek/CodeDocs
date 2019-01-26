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
        /// Used to short-cut expression of GetCodeDocsAttributes(type,type) for readability
        /// </summary>
        internal static IEnumerable<ICodeDoc> GetCodeDocAttributes(Type type)
            => GetCodeDocAttributes(type, type);

        /// <summary>
        /// Used to get instances of CodeDocAttributes officially from a member, excluding inheritance, and binding context to the attribute.
        /// </summary>
        internal static IEnumerable<ICodeDoc> GetCodeDocAttributes(Type type, MemberInfo member)
            => member.GetCustomAttributes(typeof(CodeDocsAttribute), inherit: false)
                    .Select(att => FinalizeContext(att, type, member));

        /// <summary>
        /// Binds the type and member info to the CodeDocsAttribute since attributes are not aware of their context
        /// </summary>
        internal static ICodeDoc FinalizeContext(object att, Type type, MemberInfo member)
            => ((CodeDocsAttribute)att).UpdateContext(type, member);

    }
}

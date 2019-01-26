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
        /// Acquires all docs for the assembly list, their types, and members.
        /// </summary>
        public static IEnumerable<ICodeDoc> GetCodeDocs(this IEnumerable<Assembly> assemblies)
            => assemblies.SelectMany(asm => asm.GetCodeDocs());

        /// <summary>
        /// Acquires all docs given the type query including the members.
        /// </summary>
        public static IEnumerable<ICodeDoc> GetCodeDocs(this Assembly assembly, Func<Type, bool> predicate)
            => assembly.GetTypes().Where(predicate).GetCodeDocs(includeNestedTypes: false);

        /// <summary>
        /// Acquires all docs given the assembly, its types, and members.
        /// </summary>
        public static IEnumerable<ICodeDoc> GetCodeDocs(this Assembly assembly)
            => assembly.GetTypes().GetCodeDocs(includeNestedTypes: false);


    }
}

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
        /// Acquires all docs for the appdomain given the assembly query, including their types and members.
        /// Query is required to encourage reasonable scoping.
        /// </summary>
        public static IEnumerable<ICodeDoc> GetCodeDocs(this AppDomain domain, Func<Assembly, bool> predicate)
            => domain.GetAssemblies().Where(predicate).GetCodeDocs();


    }
}

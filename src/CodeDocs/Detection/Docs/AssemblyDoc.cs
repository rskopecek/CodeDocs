using System;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;

namespace CodeDocs.Detection
{
    public class AssemblyDoc : ICodeDoc
    {
        public AssemblyDoc(Assembly assembly, IEnumerable<TypeDoc> types)
        {
            Assembly = assembly;
            Types = types.ToList();

            HasDocs = Types.Count > 0;
        }

        public Assembly Assembly { get; }
        public List<TypeDoc> Types { get; }

        public bool HasDocs { get; }

        public string Name => Assembly.GetName().Name;
        public string FullName => Assembly.GetName().FullName;

        public List<CodeDocsAttribute> Docs => new List<CodeDocsAttribute>();

        public IEnumerable<ICodeDoc> AllDocs()
        {
            yield return this;

            foreach (var t in Types)
                foreach (var doc in t.AllDocs())
                    yield return doc;
        }
    }
}

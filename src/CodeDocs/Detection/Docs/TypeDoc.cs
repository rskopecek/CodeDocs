using System;
using System.Linq;
using System.Collections.Generic;

namespace CodeDocs.Detection
{
    public class TypeDoc : ICodeDoc
    {
        public TypeDoc(Type type, IEnumerable<CodeDocsAttribute> docs, IEnumerable<MemberDoc> members)
        {
            Type = type;
            Docs = docs.ToList();
            Members = members.ToList();

            HasDocs = Docs.Count > 0 || Members.Count > 0;
        }

        public Type Type { get; }
        public List<CodeDocsAttribute> Docs { get; }
        public List<MemberDoc> Members { get; }

        public bool HasDocs { get; }

        public string Name => Type.Name;
        public string FullName => Type.FullName;

        public IEnumerable<ICodeDoc> AllDocs()
        {
            yield return this;

            foreach (var m in Members)
                foreach (var doc in m.AllDocs())
                    yield return doc;
        }
    }
}

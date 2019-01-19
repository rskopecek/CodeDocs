using System;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;

namespace CodeDocs.Detection
{
    public class MemberDoc : ICodeDoc
    {
        public MemberDoc(Type type, MemberInfo member, IEnumerable<CodeDocsAttribute> docs)
        {
            Type = type;
            Member = member;
            Docs = docs.ToList();

            HasDocs = Docs.Count > 0;
            
            
        }
        public Type Type { get; }
        public MemberInfo Member { get; }
        public List<CodeDocsAttribute> Docs { get; }

        public bool HasDocs { get; }

        public string Name => Member.Name;
        public string FullName => Type.FullName + ":" + Member.Name;


        public IEnumerable<ICodeDoc> AllDocs() { yield return this; }
       
    }
}

using System;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;

namespace CodeDocs.Detection
{
    public class DomainDoc : ICodeDoc
    {
        public DomainDoc(AppDomain domain, Func<Assembly, bool> predicate, IEnumerable<AssemblyDoc> assemblies)
        {
            Domain = domain;
            Predicate = predicate;
            Assemblies = assemblies.ToList();
        }


        public AppDomain Domain { get; }
        public Func<Assembly, bool> Predicate { get; }
        public List<AssemblyDoc> Assemblies { get; }

        public string Name => Domain.FriendlyName;
        public string FullName => Domain.FriendlyName;

        public List<CodeDocsAttribute> Docs => new List<CodeDocsAttribute>();

        public IEnumerable<ICodeDoc> AllDocs()
        {
            yield return this;

            foreach (var a in Assemblies)
                foreach (var doc in a.AllDocs())
                    yield return doc;
        }
    }
}

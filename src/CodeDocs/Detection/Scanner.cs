using System;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;

namespace CodeDocs.Detection
{
    // Nested Type inclusion is enabled by default for type specific detection and disabled for assembly/domain level 
    // detection to prevent duplicates.

    public static class Scanner
    {
        // - Domain Detection

        public static DomainDoc GetCodeDocs(this AppDomain domain, Func<Assembly, bool> predicate)
            => new DomainDoc(domain, predicate, domain.GetAssemblies().Where(predicate).GetCodeDocs());

        // - Assembly Detection

        public static IEnumerable<AssemblyDoc> GetCodeDocs(this IEnumerable<Assembly> assemblies)
            => assemblies.Select(GetCodeDocs).Where(a => a.HasDocs);

        public static AssemblyDoc GetCodeDocs(this Assembly assembly)
            => new AssemblyDoc(assembly, GetCodeDocs(assembly.GetTypes(), includeNestedTypes: false));


        // - Instance Detection

        public static TypeDoc GetCodeDocs(this object value)
            => value.GetType().GetCodeDocs();


        // - Type Detection

        public static IEnumerable<TypeDoc> GetCodeDocs(this IEnumerable<Type> types, bool includeNestedTypes = true)
            => types.Select(t=> t.GetCodeDocs(includeNestedTypes)).Where(d => d.HasDocs);


        public static TypeDoc GetCodeDocs(this Type type, bool includeNestedTypes = true)
            => new TypeDoc(type, GetCodeDocAttributes(type), type.DetectMembers(includeNestedTypes).GetCodeDocs(type));


        // - Member Detection


        public static IEnumerable<MemberDoc> GetCodeDocs(this IEnumerable<MemberInfo> members, Type type)
            => members.Select(m=> m.GetCodeDocs(type)).Where(m=> m.HasDocs);

        public static MemberDoc GetCodeDocs(this MemberInfo member, Type type)
            => new MemberDoc(type, member, GetCodeDocAttributes(member));


        // - Attribute Detection

        public const BindingFlags Flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance;

        private static Type DocType = typeof(CodeDocsAttribute);


        public static IEnumerable<MemberInfo> DetectMembers(this Type type, bool includeNestedTypes)
            => type.GetMembers(Flags).Where(m => Attribute.IsDefined(m, DocType) && (m is TypeInfo) == includeNestedTypes);

        public static IEnumerable<CodeDocsAttribute> GetCodeDocAttributes(MemberInfo member)
            => member.GetCustomAttributes(DocType, false)
                .Select(a => (CodeDocsAttribute)a);

        // - Formatting

        public static IEnumerable<(ICodeDoc doc, CodeDocsAttribute att)> Flatten(this IEnumerable<ICodeDoc> docs)
        {
            foreach (var doc in docs)
                foreach (var att in doc.Docs)
                    yield return (doc, att);
        }

    }
}

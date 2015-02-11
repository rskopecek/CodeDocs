using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CodeDocs
{
    public static class Detector
    {
        const BindingFlags Flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance;

        #region Assembly Level Detections

        /// <summary>
        /// Acquires the all of the CodeDoceAttributes attached to the assemblies provided and all of their types
        /// </summary>
        public static IEnumerable<AssemblyDetection> GetCodeDocs(this IEnumerable<Assembly> assemblies)
        {
            return assemblies.Select(asm => asm.GetCodeDocs());
        }

        /// <summary>
        /// Acquires the all of the CodeDoceAttributes attached to the assembly and all of it's types and their members
        /// </summary>
        public static AssemblyDetection GetCodeDocs(this Assembly assembly)
        {
            var result = new AssemblyDetection(assembly);

            result.Detections.AddRange(assembly.GetCustomAttributes<CodeDocsAttribute>());

            foreach(var type in assembly.GetTypes())
                result.TypeDetections.Add(type.GetCodeDocs());

            return result;
        }

        /// <summary>
        /// Detects and returns custom attributes of a particular type from an assembly
        /// </summary>
        public static IEnumerable<T> GetCustomAttributes<T>(this Assembly assembly) where T : Attribute
        {
            return assembly.GetCustomAttributes(typeof(T), true).Select(a => (T)a);
        }

        #endregion

        #region Type Level Detection

        /// <summary>
        /// Acquires the all of the CodeDoceAttributes attached to the type and it's members
        /// </summary>
        public static TypeDetection GetCodeDocs(this Type type)
        {
            var result = new TypeDetection(type);

            result.Detections.AddRange(type.GetCustomAttributes<CodeDocsAttribute>());

            foreach (var member in type.GetMembers(Flags))
                result.MemberDetections.Add(member.GetCodeDocs());

            return result;
        }

        #endregion

        #region Member Level Detection

        /// <summary>
        /// Acquires the all of the CodeDoceAttributes attached to the member
        /// </summary>
        public static MemberDetection GetCodeDocs(this MemberInfo member)
        {
            var result = new MemberDetection(member);

            result.Detections.AddRange(member.GetCustomAttributes<CodeDocsAttribute>());

            return result;
        }

        /// <summary>
        /// Detects and returns custom attributes of a particular type from a member
        /// </summary>
        public static IEnumerable<T> GetCustomAttributes<T>(this MemberInfo member) where T : Attribute
        {
            return member.GetCustomAttributes(typeof(T), true).Select(a => (T)a);
        }

        #endregion

        /// <summary>
        /// Acquires the all of the CodeDoceAttributes attached to the type of the instance object
        /// </summary>
        public static TypeDetection GetCodeDocs(this object obj)
        {
            return obj.GetType().GetCodeDocs();
        }

    }
}

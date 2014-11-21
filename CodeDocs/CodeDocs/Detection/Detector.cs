using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CodeDocs
{
    public static class Detector
    {

        //public static List<Detection> Detect(this Assembly assembly)
        //{
        //    var types = assembly.GetTypes();
        
             
        //}

        public static List<Detection> Detect(this Type type)
        {
            const BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance;

            var results = new List<Detection>();

            var atts = type.GetCustomAttributes(typeof (CodeDocsAttribute), true).Select(a => (CodeDocsAttribute) a);

            results.AddRange(atts.Select(item => new Detection(type, type, item)));

            foreach (var member in type.GetMembers(flags))
                results.AddRange(type.Detect(member));

            return results;
        }

        public static List<Detection> Detect(this Type type, MemberInfo member)
        {
            var results = new List<Detection>();

            var atts = member.GetCustomAttributes(typeof(CodeDocsAttribute), true).Select(a => (CodeDocsAttribute)a);

            results.AddRange(atts.Select(item => new Detection(type, member, item)));

            return results;
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CodeDocs
{
    public class TypeDetection : IDetectionScope
    {
        public TypeDetection(Type type)
        {
            Type = type;
            Detections = new List<CodeDocsAttribute>();
            MemberDetections = new List<MemberDetection>();
        }

        /// <summary>
        /// Type used to detect
        /// </summary>
        public Type Type { get; private set; }

        /// <summary>
        /// Detections directly attached to the type
        /// </summary>
        public List<CodeDocsAttribute> Detections { get; private set; }

        /// <summary>
        /// Detections attached downstream from members
        /// </summary>
        public List<MemberDetection> MemberDetections { get; private set; }

        /// <summary>
        /// Returns the type
        /// </summary>
        public object Context
        {
            get { return Type; }
        }

        /// <summary>
        /// Returns both the detections directly attached and detections downstream
        /// </summary>
        public List<CodeDocsAttribute> GetAllDetections()
        {
            var detections = new List<CodeDocsAttribute>(Detections);

            foreach (var member in MemberDetections)
                detections.AddRange(member.GetAllDetections());

            return detections;
        }
    }
}

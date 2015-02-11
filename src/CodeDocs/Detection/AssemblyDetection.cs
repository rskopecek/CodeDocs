using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CodeDocs
{
    public class AssemblyDetection : IDetectionScope
    {
        public AssemblyDetection(Assembly assembly)
        {
            Assembly = assembly;
            Detections = new List<CodeDocsAttribute>();
            TypeDetections = new List<TypeDetection>();
        }

        /// <summary>
        /// Assembly used to detect
        /// </summary>
        public Assembly Assembly { get; private set; }

        /// <summary>
        /// Detections directly attached to the assembly
        /// </summary>
        public List<CodeDocsAttribute> Detections { get; private set; }

        /// <summary>
        /// Detections attached downstream from types and members
        /// </summary>
        public List<TypeDetection> TypeDetections { get; private set; }

        /// <summary>
        /// Returns the assembly
        /// </summary>
        public object Context
        {
            get { return Assembly; }
        }

        /// <summary>
        /// Returns both the detections directly attached and detections downstream
        /// </summary>
        public List<CodeDocsAttribute> GetAllDetections()
        {
            var detections = new List<CodeDocsAttribute>(Detections);

            detections.AddRange(TypeDetections.SelectMany(i => i.GetAllDetections()));

            return detections.Distinct().ToList();
        }
    }
}

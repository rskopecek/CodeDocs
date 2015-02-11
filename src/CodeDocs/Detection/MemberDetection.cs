using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CodeDocs
{
    public class MemberDetection : IDetectionScope
    {
        public MemberDetection(MemberInfo member)
        {
            Member = member;
            Detections = new List<CodeDocsAttribute>();
        }

        /// <summary>
        /// Member used to detect
        /// </summary>
        public MemberInfo Member { get; private set; }

        /// <summary>
        /// Detections directly attached to the member
        /// </summary>
        public List<CodeDocsAttribute> Detections { get; private set; }


        /// <summary>
        /// Returns the member used to detect
        /// </summary>
        public object Context
        {
            get { return Member; }
        }

        /// <summary>
        /// Returns Detections
        /// </summary>
        public List<CodeDocsAttribute> GetAllDetections()
        {
            return Detections;
        }
    }
}

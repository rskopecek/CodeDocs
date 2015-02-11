using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs
{
    public interface IDetectionScope
    {
        /// <summary>
        /// Returns the Assembly, Type, or Member
        /// </summary>
        object Context { get; }

        /// <summary>
        /// Returns detections directly attached to the scope
        /// </summary>
        List<CodeDocsAttribute> Detections { get; }

        /// <summary>
        /// Returns both the detections directly attached and detections downstream
        /// </summary>
        List<CodeDocsAttribute> GetAllDetections();

    }
}

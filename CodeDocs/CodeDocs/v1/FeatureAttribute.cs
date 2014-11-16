using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.v1
{
    [Obsolete(Constants.v1_Obsolete_Message)]
    public class FeatureAttribute : DocsAttribute
    {
        public FeatureAttribute(string title, string description)
            : base(title, description)
        {
        }
    }
}

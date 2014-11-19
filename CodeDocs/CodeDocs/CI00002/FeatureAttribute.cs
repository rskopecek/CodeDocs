using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.CI00002
{
    [Obsolete(Constants.Ci00002ObsoleteMessage)]
    public class FeatureAttribute : DocsAttribute
    {
        public FeatureAttribute(string title, string description)
            : base(title, description)
        {
        }
    }
}

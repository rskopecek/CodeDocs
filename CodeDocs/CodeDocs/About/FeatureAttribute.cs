using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.About
{
    public class FeatureAttribute : DocsAttribute
    {
        public FeatureAttribute(string title, string description)
            : base(title, description)
        {
        }
    }
}
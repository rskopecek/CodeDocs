using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Definitions.v2
{
    public class FeatureDefinition : Definition
    {
        public FeatureDefinition()
            : base(
                "Feature", true,
                Risk.None,
                Effort.None,
                "A distinctive function/attribute about what the application does.",
                "Feature")
        {
        }
    }
}

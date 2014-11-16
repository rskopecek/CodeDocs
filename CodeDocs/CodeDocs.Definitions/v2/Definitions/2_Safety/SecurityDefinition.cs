using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Definitions.v2
{
    public class SecurityDefinition : Definition
    {
        public SecurityDefinition()
            : base(
                "Security", true,
                Risk.None,
                Effort.None,
                "A note about security in relation to the context, not necessarily a risk.",
                 "Security")
        {
        }
    }
}

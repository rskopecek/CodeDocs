using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Definitions.v2
{
    public class CiteDefinition : Definition
    {
        public CiteDefinition()
            : base(
                "Cite", true,
                Risk.None,
                Effort.None,
                "Used to identify external resources (like StakeOverflow, blogs, etc) that would add value to the context this attribute is applied to.",
                "Meaning")
        {
        }
    }
}

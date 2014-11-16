using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Definitions.v2
{
    public class FutureDefinition : Definition 
    {
        public FutureDefinition()
            : base(
                "Future", true,
                Risk.Low,
                Effort.None,
                "A potential future scenario, in which this will need to be changed or these are some insights about the change.",
                 "Work", "Future")
        {
        }
    }
}

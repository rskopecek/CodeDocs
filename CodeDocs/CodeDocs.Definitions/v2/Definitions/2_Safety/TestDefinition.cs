using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Definitions.v2
{
    public class TestDefinition : Definition
    {
        public TestDefinition()
            : base(
                "Test", true,
                Risk.Extreme,
                Effort.Small,
                "Test scenario that appears to be missing.",
                "Degredation")
        {
        }
    }
}

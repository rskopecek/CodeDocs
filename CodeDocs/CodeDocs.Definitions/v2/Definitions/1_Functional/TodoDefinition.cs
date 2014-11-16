using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Definitions.v2
{
    public class TodoDefinition : Definition
    {
        public TodoDefinition()
            : base(
                "Todo", true,
                Risk.Extreme,
                Effort.Medium,
                "Uncompleted feature.",
                "Work")
        {
        }
    }
}

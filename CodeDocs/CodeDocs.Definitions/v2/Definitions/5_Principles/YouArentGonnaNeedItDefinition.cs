using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Definitions.v2
{
    public class YouArentGonnaNeedItDefinition : Definition
    {
        public YouArentGonnaNeedItDefinition()
            : base( // Acronym: YAGNI
                "YouArentGonnaNeedIt", true,
                Risk.Moderate,
                Effort.Medium,
                "Always implement things when you actually need them, never when you just foresee that you need them.",
                 "Principles")
        {
        }
    }
}

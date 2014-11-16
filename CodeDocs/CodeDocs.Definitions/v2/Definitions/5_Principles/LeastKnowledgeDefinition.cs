using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Definitions.v2
{
    public class LeastKnowledgeDefinition : Definition
    {
        public LeastKnowledgeDefinition()
            : base( // Acronym: LoD
                "LeastKnowledge", true,
                Risk.Moderate,
                Effort.Medium,
                "[Law of Demeter] A component or object shold not know about internal details of other components or objects.",
                 "Principles")
        {
        }
    }
}

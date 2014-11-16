using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeDocs.Definitions.v2;

namespace CodeDocs.v2
{
    public interface ICodeDocsAttribute
    {
        Definition Definition { get; }

        DateTime? Date { get;  }

        Risk? Risk { get;  }

        Effort? Effort { get; }

        string Details { get; }

        string[] Tags { get;  }

        string[] Urls { get; }

        Risk GetRisk();

        Effort GetEffort();

        Risk GetRisk(IQualityEvaluator evaluator);

        Effort GetEffort(IQualityEvaluator evaluator);

        Risk GetMetaRisk();

        Risk GetMetaRisk(IQualityEvaluator evaluator);


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs
{
    public interface ICodeDocsAttribute
    {
        IDefinition Definition { get; }

        DateTime? Date { get;  }

        Risk Risk { get;  }

        Effort Effort { get; }

        string Details { get; }


        Risk GetRisk();

        Effort GetEffort();

        Risk GetRisk(IQualityEvaluator evaluator);

        Effort GetEffort(IQualityEvaluator evaluator);

        Risk GetMetaRisk();

        Risk GetMetaRisk(IQualityEvaluator evaluator);


    }
}

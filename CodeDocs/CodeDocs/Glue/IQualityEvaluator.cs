using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs
{
    public interface IQualityEvaluator
    {

        Risk? GetRiskOverride(ICodeDocsAttribute att);

        Effort? GetEffortOverride(ICodeDocsAttribute att);

        Risk? GetMetaRiskOverride(ICodeDocsAttribute att);

    }
}

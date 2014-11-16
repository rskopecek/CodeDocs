using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeDocs.Definitions.v2;

namespace CodeDocs.v2
{
    public interface IQualityEvaluator
    {

        Risk? GetRiskOverride(ICodeDocsAttribute att);

        Effort? GetEffortOverride(ICodeDocsAttribute att);

        Risk? GetMetaRiskOverride(ICodeDocsAttribute att);

    }
}

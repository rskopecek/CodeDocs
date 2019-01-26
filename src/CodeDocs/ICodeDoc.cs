using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CodeDocs
{
    public interface ICodeDoc
    {


        string Name { get; }

        string Comment { get; }

        DateTime? AsOf { get; }

        Level Risk { get; }
        long? RiskAmount { get; }

        Level Effort { get; }
        long? EffortAmount { get; }

        Level Profit { get; }
        long? ProfitAmount { get; }

        string See { get; }

        IEnumerable<string> Tags { get; }

        string Id { get; }

        PatternsAndPrinciples PatternsAndPrinciples { get; }

        Assembly Assembly { get; }
        Type Type { get; }
        MemberInfo Member { get; }


    }
}

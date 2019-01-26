using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Linq;
using static System.AttributeTargets;
using System.Runtime.CompilerServices;

#if DEBUG
[assembly: InternalsVisibleTo("CodeDocs.Tests")]
#endif
namespace CodeDocs
{

    public enum Level
    {
        NotSet, Tiny, Small, Medium, Large, Massive, Unknown
    }

    [AttributeUsage(DetectionScope, AllowMultiple = false, Inherited = false)]
    public abstract class CodeDocsAttribute : Attribute, ICodeDoc
    {
        public const AttributeTargets DetectionScope = AttributeTargets.Assembly | Class | Struct | Interface | AttributeTargets.Enum | Field | Property | AttributeTargets.Delegate | Event | Constructor | Method;


        public CodeDocsAttribute(
            string comment = "",
            int asOf = int.MinValue,

            Level risk = Level.NotSet,
            long riskAmount = long.MinValue,

            Level effort = Level.NotSet,
            long effortAmount = long.MinValue,


            Level profit = Level.NotSet,
            long profitAmount = long.MinValue,

            string see = "",

            string tags = "",
            string id = "",

            // Patterns & Principles
            Solid solid = Solid.NotSet,
            Grasp grasp = Grasp.NotSet,
            Creational creational = Creational.NotSet,
            Structural structural = Structural.NotSet,
            Behavioral behavioral = Behavioral.NotSet,
            Concurrency concurrency = Concurrency.NotSet,
            Functional functional = Functional.NotSet,
            Architectural architectural = Architectural.NotSet,
            CloudDistributed cloudDistributed = CloudDistributed.NotSet,
            General general = General.NotSet



            )
        {
            Comment = comment == null ? "" : comment.CleanseComment(); // net35 doesn't have IsNullOrEmpty/etc
            AsOf = asOf.ParseNullableIsoDate();

            Risk = risk;
            RiskAmount = riskAmount.ParseNullable();

            Effort = effort;
            EffortAmount = effortAmount.ParseNullable();

            Profit = profit;
            ProfitAmount = profitAmount.ParseNullable();

            See = see;
            
            Tags = tags.ParseTags();
            Id = id;

            PatternsAndPrinciples = new PatternsAndPrinciples(solid, grasp, creational, structural, behavioral, concurrency, functional, architectural, cloudDistributed, general);

            Name = GetType().Name.Replace("Attribute", "");
        }


        public string Name { get; }

        public string Comment { get; }

        public DateTime? AsOf { get; }

        public Level Risk { get; }
        public long? RiskAmount { get; }

        public Level Effort { get; }
        public long? EffortAmount { get; }

        public Level Profit { get; }
        public long? ProfitAmount { get; }

        public string See { get; }


        public IEnumerable<string> Tags { get; }

        public string Id { get; } 

        public PatternsAndPrinciples PatternsAndPrinciples { get; }

        public Assembly Assembly { get; private set; }
        public Type Type { get; private set; }
        public MemberInfo Member { get; private set; }

        internal CodeDocsAttribute UpdateContext(Type type, MemberInfo member)
        {
            if (Assembly != null) return this;

            Assembly = type.Assembly;
            Type = type;
            Member = member;

            return this;
        }

        public static string ToStringHeader
            => "Assembly,Type,Member,Attribute,Comment,AsOf,Risk,RiskAmount,Effort,EffortAmount,Profit,ProfitAmount,See,Tags,Id,PatternAndPrinciples";

        public override string ToString()
        {
            var values = new string[]
            {
                Assembly.GetName().Name,
                Type.FullName,
                Member.Name,
                Name,
                $"\"{Comment}\"",
                AsOf.HasValue ? AsOf.Value.ToString("yyyy-MM-dd") : "",
                Risk == Level.NotSet ? "" : Risk.ToString(),
                RiskAmount.HasValue ? RiskAmount.Value.ToString() : "",
                Effort == Level.NotSet ? "" : Effort.ToString(),
                EffortAmount.HasValue ? EffortAmount.Value.ToString() : "",
                Profit == Level.NotSet ? "" : Profit.ToString(),
                ProfitAmount.HasValue ? ProfitAmount.Value.ToString() : "",
                See,
                $"\"{string.Join(",", Tags.ToArray())}\"",
                Id,
                $"\"{PatternsAndPrinciples.ToString()}\""
            };

            return string.Join(",", values);

        }


    }
}

using System;
using System.Collections.Generic;

namespace CodeDocs
{
    public static class Constants
    {
        public const AttributeTargets DetectionScope = AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Delegate | AttributeTargets.Event | AttributeTargets.Constructor | AttributeTargets.Method;
    }

    public enum Level
    {
        NotSet, Tiny, Small, Medium, Large, Massive, Unknown
    }

    [AttributeUsage(Constants.DetectionScope, AllowMultiple = false, Inherited = false)]
    public abstract class CodeDocsAttribute : Attribute
    {
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
            Comment = comment;
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



    }
}

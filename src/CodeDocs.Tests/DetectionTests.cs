using System;
using System.Linq;
using System.Collections.Generic;
using CodeDocs;
using CodeDocs.Detection;
using Xunit;

namespace CodeDocs.Tests
{


    public class DetectionTests
    {

        [Fact]
        [Bug("comment", id: "id", asOf: 20190101, see: "reference", tags: "tag",
        risk: Level.Tiny, riskAmount: 3, effort: Level.Small, effortAmount: 5,
        profit: Level.Medium, profitAmount: 300,

        solid: Solid.DependencyInversion | Solid.SingleResponsibility,
        grasp: Grasp.HighCohesion | Grasp.Polymorphism,
        creational: Creational.AbstractFactory | Creational.Builder,
        structural: Structural.Adapter | Structural.Bridge,
        behavioral: Behavioral.Blackboard | Behavioral.ChainOfResponsibility,
        concurrency: Concurrency.ActiveObject | Concurrency.ReadWriterLock,
        functional: Functional.Closure | Functional.Monad,
        architectural: Architectural.ActiveRecord | Architectural.ClientServer,
        cloudDistributed: CloudDistributed.Ambassador | CloudDistributed.Bulkhead,
        general: General.DontRepeatYourself | General.NoSideEffects
        )]
        public void AllValuesSave()
        {
            var att = typeof(DetectionTests).GetCodeDocs().AllDocs().Flatten().FirstOrDefault().att;

            Assert.Equal("comment", att.Comment);
            Assert.Equal("id", att.Id);
            Assert.Equal(new DateTime(2019, 1, 1), att.AsOf);
            Assert.Equal(Level.Tiny, att.Risk);
            Assert.Equal(3, att.RiskAmount);
            Assert.Equal(Level.Small, att.Effort);
            Assert.Equal(5, att.EffortAmount);
            Assert.Equal(Level.Medium, att.Profit);
            Assert.Equal(300, att.ProfitAmount);
            Assert.Equal("reference", att.See);
            Assert.Equal(new []{"tag"}, att.Tags.ToArray());
            Assert.Equal(Solid.DependencyInversion | Solid.SingleResponsibility, att.PatternsAndPractices.Solid);
            Assert.Equal(Grasp.HighCohesion | Grasp.Polymorphism, att.PatternsAndPractices.Grasp);
            Assert.Equal(Creational.AbstractFactory | Creational.Builder, att.PatternsAndPractices.Creational);
            Assert.Equal(Structural.Adapter | Structural.Bridge, att.PatternsAndPractices.Structural);
            Assert.Equal(Behavioral.Blackboard | Behavioral.ChainOfResponsibility, att.PatternsAndPractices.Behavioral);
            Assert.Equal(Concurrency.ActiveObject | Concurrency.ReadWriterLock, att.PatternsAndPractices.Concurrency);
            Assert.Equal(Functional.Closure | Functional.Monad, att.PatternsAndPractices.Functional);
            Assert.Equal(Architectural.ActiveRecord | Architectural.ClientServer, att.PatternsAndPractices.Architectural);
            Assert.Equal(CloudDistributed.Ambassador | CloudDistributed.Bulkhead, att.PatternsAndPractices.CloudDistributed);
            Assert.Equal(General.DontRepeatYourself | General.NoSideEffects, att.PatternsAndPractices.General);

        }



    }
}

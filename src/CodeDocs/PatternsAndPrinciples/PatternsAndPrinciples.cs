using System;

namespace CodeDocs
{
    public class PatternsAndPrinciples
    {
        public PatternsAndPrinciples
        (
            Solid solid, Grasp grasp,
            Creational creational, Structural structural, Behavioral behavioral, Concurrency concurrency,
            Functional functional,
            Architectural architectural,
            CloudDistributed cloudDistributed,
            General general
            )
        {
            Solid = solid;
            Grasp = grasp;

            Creational = creational;
            Structural = structural;
            Behavioral = behavioral;
            Concurrency = concurrency;

            Functional = functional;
            Architectural = architectural;

            CloudDistributed = cloudDistributed;
            General = general;

        }

        public Solid Solid { get; }
        public Grasp Grasp { get; }

        public Creational Creational { get; }
        public Structural Structural { get; }
        public Behavioral Behavioral { get; }
        public Concurrency Concurrency { get; }

        public Functional Functional { get; }

        public Architectural Architectural { get; }
        public CloudDistributed CloudDistributed { get; }

        public General General { get; }

    }
}

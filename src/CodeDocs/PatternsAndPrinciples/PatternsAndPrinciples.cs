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

        public override string ToString()
        {
            var values = new string[] 
            {
                Solid.ToString(),
                Grasp.ToString(),
                Creational.ToString(),
                Structural.ToString(),
                Behavioral.ToString(),
                Concurrency.ToString(),
                Functional.ToString(),
                Architectural.ToString(),
                CloudDistributed.ToString(),
                General.ToString()
            };

            string[] splitter = new string[] { "," };

            return String.Join(",",string.Join(",", values).Replace(" ", "").Replace("NotSet","").Split(splitter, StringSplitOptions.RemoveEmptyEntries));
        }

    }
}

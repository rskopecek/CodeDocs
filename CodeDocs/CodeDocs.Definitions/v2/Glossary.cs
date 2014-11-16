using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace CodeDocs.Definitions.v2
{
    public static class Glossary
    {

        public static List<Definition> Definitions()
        {
            return new List<Definition>
            {
                // Functional
                Bug, MajorFix, MinorFix, Slow, Todo,

                // Safety
                Security, InSecure, Toxic, Consequence, DeadCode, Test,

                // Belonging
                Cite, Feature, MajorChange, MinorChange, Naming, Readability, Location, Standards, Reviewed,

                // Confidence
                Hack, Refactor, Clarification, Purpose, Future,

                // Principles
                SingleResponsibility, OpenClosed, LiskovSubstitution, InterfaceSegregation, DependancyInversion,
                DontRepeatYourself, LeastKnowledge, OccamsRazor, SeparationOfConcerns, YouArentGonnaNeedIt
            };
        }

        public static IEnumerable<string> Tags(this IEnumerable<Definition> definitions)
        {
            return definitions.SelectMany(i => i.Tags).Distinct();
        }

        #region Definition Specifics

        // Functional

        public static readonly Definition Bug = new BugDefinition();
        public static readonly Definition MajorFix = new MajorFixDefinition();
        public static readonly Definition MinorFix = new MinorFixDefinition();        
        public static readonly Definition Slow = new SlowDefinition();        
        public static readonly Definition Todo = new TodoDefinition();        
        
        // Safety

        public static readonly Definition Security = new SecurityDefinition();
        public static readonly Definition InSecure = new InSecureDefinition();
        public static readonly Definition Toxic = new ToxicDefinition();
        public static readonly Definition Consequence = new ConsequenceDefinition();
        public static readonly Definition DeadCode = new DeadCodeDefinition();
        public static readonly Definition Test = new TestDefinition();


        // Belonging
        
        public static readonly Definition Cite = new CiteDefinition();
        public static readonly Definition Feature = new FeatureDefinition();
        public static readonly Definition MajorChange = new MajorChangeDefinition();
        public static readonly Definition MinorChange = new MinorChangeDefinition();
        public static readonly Definition Naming = new NamingDefinition();
        public static readonly Definition Readability = new ReadabilityDefinition();
        public static readonly Definition Location = new LocationDefinition();
        public static readonly Definition Standards = new StandardsDefinition();
        public static readonly Definition Reviewed = new ReviewedDefinition();


        // Confidence

        public static readonly Definition Hack = new HackDefinition();
        public static readonly Definition Refactor = new RefactorDefinition();
        public static readonly Definition Clarification = new ClarificationDefinition();
        public static readonly Definition Purpose = new PurposeDefinition();
        public static readonly Definition Future = new FutureDefinition();


        // Principles

        public static readonly Definition DependancyInversion = new DependancyInversionDefinition();
        public static readonly Definition DontRepeatYourself = new DontRepeatYourselfDefinition();
        public static readonly Definition InterfaceSegregation = new InterfaceSegregationDefinition();
        public static readonly Definition LeastKnowledge = new LeastKnowledgeDefinition();
        public static readonly Definition LiskovSubstitution = new LiskovSubstitutionDefinition();
        public static readonly Definition OccamsRazor = new OccamsRazorDefinition();
        public static readonly Definition OpenClosed = new OpenClosedDefinition();
        public static readonly Definition SeparationOfConcerns = new SeparationOfConcernsDefinition();
        public static readonly Definition SingleResponsibility = new SingleResponsibilityDefinition();
        public static readonly Definition YouArentGonnaNeedIt = new YouArentGonnaNeedItDefinition();

        #endregion

    }
}

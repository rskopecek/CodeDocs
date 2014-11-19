
using System;
using System.Collections.ObjectModel;

namespace CodeDocs
{
	public static partial class Glossary
	{
		static Glossary()
		{
			Bug = new BugDefinition();
			MajorFix = new MajorFixDefinition();
			MinorFix = new MinorFixDefinition();
			Slow = new SlowDefinition();
			Todo = new TodoDefinition();
			Consequence = new ConsequenceDefinition();
			DeadCode = new DeadCodeDefinition();
			Security = new SecurityDefinition();
			Insecure = new InsecureDefinition();
			Test = new TestDefinition();
			Toxic = new ToxicDefinition();
			Cite = new CiteDefinition();
			Feature = new FeatureDefinition();
			Location = new LocationDefinition();
			MajorChange = new MajorChangeDefinition();
			MinorChange = new MinorChangeDefinition();
			Naming = new NamingDefinition();
			Readability = new ReadabilityDefinition();
			Reviewed = new ReviewedDefinition();
			Standards = new StandardsDefinition();
			Clarification = new ClarificationDefinition();
			Future = new FutureDefinition();
			Hack = new HackDefinition();
			Purpose = new PurposeDefinition();
			Refactor = new RefactorDefinition();
			DependancyInversion = new DependancyInversionDefinition();
			DontRepeatYourself = new DontRepeatYourselfDefinition();
			InterfaceSegregation = new InterfaceSegregationDefinition();
			LeastKnowledge = new LeastKnowledgeDefinition();
			LiskovSubstitution = new LiskovSubstitutionDefinition();
			OccamsRazor = new OccamsRazorDefinition();
			OpenClosed = new OpenClosedDefinition();
			SeparationOfConcerns = new SeparationOfConcernsDefinition();
			SingleResponsibility = new SingleResponsibilityDefinition();
			YouArentGonnaNeedIt = new YouArentGonnaNeedItDefinition();

			Definitions = new ReadOnlyCollection<IDefinition>(new []{ Bug, MajorFix, MinorFix, Slow, Todo, Consequence, DeadCode, Security, Insecure, Test, Toxic, Cite, Feature, Location, MajorChange, MinorChange, Naming, Readability, Reviewed, Standards, Clarification, Future, Hack, Purpose, Refactor, DependancyInversion, DontRepeatYourself, InterfaceSegregation, LeastKnowledge, LiskovSubstitution, OccamsRazor, OpenClosed, SeparationOfConcerns, SingleResponsibility, YouArentGonnaNeedIt });
			Tags = new ReadOnlyCollection<string>(new []{ "Degredation", "Change", "Major", "Fix", "Minor", "Performance", "Work", "Consequence", "DeadCode", "Security", "InSecure", "Toxic", "Meaning", "Feature", "Review", "Standards", "Future", "YAGNI", "SRP", "Principles", "SOLID", "DIP", "DRY", "ISP", "LoD", "LSP", "OCP", "SoC" });
		}

		public static readonly ReadOnlyCollection<IDefinition> Definitions;
		public static readonly ReadOnlyCollection<string> Tags;

		#region Static ReadOnly Definitions

		public static readonly IDefinition Bug;
		public static readonly IDefinition MajorFix;
		public static readonly IDefinition MinorFix;
		public static readonly IDefinition Slow;
		public static readonly IDefinition Todo;
		public static readonly IDefinition Consequence;
		public static readonly IDefinition DeadCode;
		public static readonly IDefinition Security;
		public static readonly IDefinition Insecure;
		public static readonly IDefinition Test;
		public static readonly IDefinition Toxic;
		public static readonly IDefinition Cite;
		public static readonly IDefinition Feature;
		public static readonly IDefinition Location;
		public static readonly IDefinition MajorChange;
		public static readonly IDefinition MinorChange;
		public static readonly IDefinition Naming;
		public static readonly IDefinition Readability;
		public static readonly IDefinition Reviewed;
		public static readonly IDefinition Standards;
		public static readonly IDefinition Clarification;
		public static readonly IDefinition Future;
		public static readonly IDefinition Hack;
		public static readonly IDefinition Purpose;
		public static readonly IDefinition Refactor;
		public static readonly IDefinition DependancyInversion;
		public static readonly IDefinition DontRepeatYourself;
		public static readonly IDefinition InterfaceSegregation;
		public static readonly IDefinition LeastKnowledge;
		public static readonly IDefinition LiskovSubstitution;
		public static readonly IDefinition OccamsRazor;
		public static readonly IDefinition OpenClosed;
		public static readonly IDefinition SeparationOfConcerns;
		public static readonly IDefinition SingleResponsibility;
		public static readonly IDefinition YouArentGonnaNeedIt;

		#endregion
	}
}
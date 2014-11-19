﻿
using System;
using System.Collections.ObjectModel;
using CodeDocs.Definitions;

namespace CodeDocs
{
	/// <summary>
	/// Static glossary of all definitions and tags for easy use and reference
	/// </summary>
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
			Risks = new ReadOnlyCollection<Risk>(new []{ Risk.None, Risk.Low, Risk.Moderate, Risk.High, Risk.Extreme });
			Efforts = new ReadOnlyCollection<Effort>(new []{ Effort.None, Effort.VerySmall, Effort.Small, Effort.Medium, Effort.Large, Effort.VeryLarge, Effort.Unknown });
			Tags = new ReadOnlyCollection<Tag>(new []{ Tag.Degredation, Tag.Change, Tag.Major, Tag.Fix, Tag.Minor, Tag.Performance, Tag.Work, Tag.Consequence, Tag.DeadCode, Tag.Security, Tag.InSecure, Tag.Toxic, Tag.Meaning, Tag.Feature, Tag.Review, Tag.Standards, Tag.Future, Tag.YAGNI, Tag.SRP, Tag.Principles, Tag.SOLID, Tag.DIP, Tag.DRY, Tag.ISP, Tag.LoD, Tag.LSP, Tag.OCP, Tag.SoC });
		}

		/// <summary>
		/// Static enumerable definition list for easy use and reference
		/// </summary>
		public static readonly ReadOnlyCollection<IDefinition> Definitions;

		/// <summary>
		/// Static enumerable risk list for easy use and reference
		/// </summary>
		public static readonly ReadOnlyCollection<Risk> Risks;

		/// <summary>
		/// Static enumerable effort list for easy use and reference
		/// </summary>
		public static readonly ReadOnlyCollection<Effort> Efforts;

		/// <summary>
		/// Static enumerable tag list for easy use and reference
		/// </summary>
		public static readonly ReadOnlyCollection<Tag> Tags;



		#region Static ReadOnly Definitions

		/// <summary>
		/// Used to acknowledge and identify code that has a live issue even though a resolution has not been identified or implemented.
		/// </summary>
		public static readonly IDefinition Bug;
		/// <summary>
		/// Identification of a major fix that is important to communicate and potentially worthy of moving the [incr] version # forward if any exist during deployment (major.minor.incr).
		/// </summary>
		public static readonly IDefinition MajorFix;
		/// <summary>
		/// Identification of a minor fix that is important to communicate and potentially worthy of moving the [incr] version # forward if any exist during deployment (major.minor.incr).
		/// </summary>
		public static readonly IDefinition MinorFix;
		/// <summary>
		/// A piece of code that is slower than desired and need refactored.
		/// </summary>
		public static readonly IDefinition Slow;
		/// <summary>
		/// Uncompleted feature.
		/// </summary>
		public static readonly IDefinition Todo;
		/// <summary>
		/// A side-effect that may occur either by the behavior of the code or if a change is made to the code.
		/// </summary>
		public static readonly IDefinition Consequence;
		/// <summary>
		/// Typically code that is commented out or code that exists but is never used.
		/// </summary>
		public static readonly IDefinition DeadCode;
		/// <summary>
		/// A note about security in relation to the context, not necessarily a risk.
		/// </summary>
		public static readonly IDefinition Security;
		/// <summary>
		/// An identified security issue.
		/// </summary>
		public static readonly IDefinition Insecure;
		/// <summary>
		/// Test scenario that appears to be missing
		/// </summary>
		public static readonly IDefinition Test;
		/// <summary>
		/// A piece of code that is extremely tempermental, developers should be cautioned, and refactoring is required.
		/// </summary>
		public static readonly IDefinition Toxic;
		/// <summary>
		/// Used to identify external resources (like StakeOverflow, blogs, etc) that would add value to the context this attribute is applied to.
		/// </summary>
		public static readonly IDefinition Cite;
		/// <summary>
		/// A distinctive function/attribute about what the application does.
		/// </summary>
		public static readonly IDefinition Feature;
		/// <summary>
		/// Piece of code that appears to be in the wrong place.
		/// </summary>
		public static readonly IDefinition Location;
		/// <summary>
		/// Identification of a major change that is important to communicate and potentially worthy of moving the version # forward if any exist during deployment (major.minor.incr).
		/// </summary>
		public static readonly IDefinition MajorChange;
		/// <summary>
		/// Identification of a minor change that is important to communicate and potentially worthy of moving the version # forward if any exist during deployment (major.minor.incr).
		/// </summary>
		public static readonly IDefinition MinorChange;
		/// <summary>
		/// Intent is clear.  However, naming could be cleaner.
		/// </summary>
		public static readonly IDefinition Naming;
		/// <summary>
		/// Hard to read at first glance for one or more people.
		/// </summary>
		public static readonly IDefinition Readability;
		/// <summary>
		/// Used to tag that an area of code has been reviewed by one or more people.
		/// </summary>
		public static readonly IDefinition Reviewed;
		/// <summary>
		/// A piece of code that needs refactored to adhere to code/design standards.
		/// </summary>
		public static readonly IDefinition Standards;
		/// <summary>
		/// Readable, but missing a 'good to know' for people trying to understand.
		/// </summary>
		public static readonly IDefinition Clarification;
		/// <summary>
		/// A potential future scenario, in which this will need to be changed or these are some insights about the change.
		/// </summary>
		public static readonly IDefinition Future;
		/// <summary>
		/// Working feature.  Requires refactoring due to shortcuts needed to make it work.
		/// </summary>
		public static readonly IDefinition Hack;
		/// <summary>
		/// Unsure of actual intent.  Might be doing too many things.
		/// </summary>
		public static readonly IDefinition Purpose;
		/// <summary>
		/// Working feature that needs improvement
		/// </summary>
		public static readonly IDefinition Refactor;
		/// <summary>
		/// [The D in SOLID] Depend upon Abstractions. Do not depend upon concretions.
		/// </summary>
		public static readonly IDefinition DependancyInversion;
		/// <summary>
		/// (DRY) Every piece of knowledge must have a single, unambiguous, authoritative representation within a system.
		/// </summary>
		public static readonly IDefinition DontRepeatYourself;
		/// <summary>
		/// [The I in SOLID] Many client-specific interfaces are better than one general-purpose interface.
		/// </summary>
		public static readonly IDefinition InterfaceSegregation;
		/// <summary>
		/// [Law of Demeter] A component or object shold not know about internal details of other components or objects.
		/// </summary>
		public static readonly IDefinition LeastKnowledge;
		/// <summary>
		/// [The L in SOLID] Objects in a program should be replaceable with instances of their subtypes without altering the correctness of that program.
		/// </summary>
		public static readonly IDefinition LiskovSubstitution;
		/// <summary>
		/// The path with the fewest assumptions should be selected even if other directions may eventually prove correct.
		/// </summary>
		public static readonly IDefinition OccamsRazor;
		/// <summary>
		/// [The O in SOLID] Software entities should be open for extension, but closed for modification.
		/// </summary>
		public static readonly IDefinition OpenClosed;
		/// <summary>
		/// The design should divide areas of concern into their own distinct sections.
		/// </summary>
		public static readonly IDefinition SeparationOfConcerns;
		/// <summary>
		/// [The S in SOLID] Each context of code should do one thing and thus have only one reason to change.
		/// </summary>
		public static readonly IDefinition SingleResponsibility;
		/// <summary>
		/// Always implement things when you actually need them, never when you just foresee that you need them.
		/// </summary>
		public static readonly IDefinition YouArentGonnaNeedIt;

		#endregion
	}
}
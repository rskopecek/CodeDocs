
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs
{

	public sealed class BugDefinition : IDefinition, IFunctionalGroup, IDegredationTag, IExtremeRiskTag, IUnknownEffortTag
	{
		public string Group { get { return "Functional";} }
		public string Name { get { return "Bug"; } }
		public string Description { get { return "Used to acknowledge and identify code that has a live issue even though a resolution has not been identified or implemented."; } }
		public Risk DefaultRisk { get { return Risk.Extreme; } }
		public Effort DefaultEffort { get { return Effort.Unknown; } }
		public Tag[] Tags { get { return new[]{ Tag.Degredation }; } }
		public bool OnePerContext { get { return false; } }
	}

	public sealed class MajorFixDefinition : IDefinition, IFunctionalGroup, IChangeTag, IMajorTag, IFixTag, INoneRiskTag, INoneEffortTag
	{
		public string Group { get { return "Functional";} }
		public string Name { get { return "Major Fix"; } }
		public string Description { get { return "Identification of a major fix that is important to communicate and potentially worthy of moving the [incr] version # forward if any exist during deployment (major.minor.incr)."; } }
		public Risk DefaultRisk { get { return Risk.None; } }
		public Effort DefaultEffort { get { return Effort.None; } }
		public Tag[] Tags { get { return new[]{ Tag.Change, Tag.Major, Tag.Fix }; } }
		public bool OnePerContext { get { return false; } }
	}

	public sealed class MinorFixDefinition : IDefinition, IFunctionalGroup, IChangeTag, IMinorTag, IFixTag, INoneRiskTag, INoneEffortTag
	{
		public string Group { get { return "Functional";} }
		public string Name { get { return "Minor Fix"; } }
		public string Description { get { return "Identification of a minor fix that is important to communicate and potentially worthy of moving the [incr] version # forward if any exist during deployment (major.minor.incr)."; } }
		public Risk DefaultRisk { get { return Risk.None; } }
		public Effort DefaultEffort { get { return Effort.None; } }
		public Tag[] Tags { get { return new[]{ Tag.Change, Tag.Minor, Tag.Fix }; } }
		public bool OnePerContext { get { return false; } }
	}

	public sealed class SlowDefinition : IDefinition, IFunctionalGroup, IPerformanceTag, IDegredationTag, IModerateRiskTag, IMediumEffortTag, IOnePerContextTag
	{
		public string Group { get { return "Functional";} }
		public string Name { get { return "Slow"; } }
		public string Description { get { return "A piece of code that is slower than desired and need refactored."; } }
		public Risk DefaultRisk { get { return Risk.Moderate; } }
		public Effort DefaultEffort { get { return Effort.Medium; } }
		public Tag[] Tags { get { return new[]{ Tag.Performance, Tag.Degredation }; } }
		public bool OnePerContext { get { return true; } }
	}

	public sealed class TodoDefinition : IDefinition, IFunctionalGroup, IWorkTag, IDegredationTag, IExtremeRiskTag, IMediumEffortTag
	{
		public string Group { get { return "Functional";} }
		public string Name { get { return "Todo"; } }
		public string Description { get { return "Uncompleted feature."; } }
		public Risk DefaultRisk { get { return Risk.Extreme; } }
		public Effort DefaultEffort { get { return Effort.Medium; } }
		public Tag[] Tags { get { return new[]{ Tag.Work, Tag.Degredation }; } }
		public bool OnePerContext { get { return false; } }
	}

	public sealed class ConsequenceDefinition : IDefinition, ISafetyGroup, IConsequenceTag, IModerateRiskTag, IUnknownEffortTag
	{
		public string Group { get { return "Safety";} }
		public string Name { get { return "Consequence"; } }
		public string Description { get { return "A side-effect that may occur either by the behavior of the code or if a change is made to the code."; } }
		public Risk DefaultRisk { get { return Risk.Moderate; } }
		public Effort DefaultEffort { get { return Effort.Unknown; } }
		public Tag[] Tags { get { return new[]{ Tag.Consequence }; } }
		public bool OnePerContext { get { return false; } }
	}

	public sealed class DeadCodeDefinition : IDefinition, ISafetyGroup, IDeadCodeTag, IConsequenceTag, ILowRiskTag, IVerySmallEffortTag, IOnePerContextTag
	{
		public string Group { get { return "Safety";} }
		public string Name { get { return "Dead Code"; } }
		public string Description { get { return "Typically code that is commented out or code that exists but is never used."; } }
		public Risk DefaultRisk { get { return Risk.Low; } }
		public Effort DefaultEffort { get { return Effort.VerySmall; } }
		public Tag[] Tags { get { return new[]{ Tag.DeadCode, Tag.Consequence }; } }
		public bool OnePerContext { get { return true; } }
	}

	public sealed class SecurityDefinition : IDefinition, ISafetyGroup, ISecurityTag, INoneRiskTag, INoneEffortTag
	{
		public string Group { get { return "Safety";} }
		public string Name { get { return "Security"; } }
		public string Description { get { return "A note about security in relation to the context, not necessarily a risk."; } }
		public Risk DefaultRisk { get { return Risk.None; } }
		public Effort DefaultEffort { get { return Effort.None; } }
		public Tag[] Tags { get { return new[]{ Tag.Security }; } }
		public bool OnePerContext { get { return false; } }
	}

	public sealed class InsecureDefinition : IDefinition, ISafetyGroup, ISecurityTag, IInSecureTag, IDegredationTag, IExtremeRiskTag, IUnknownEffortTag
	{
		public string Group { get { return "Safety";} }
		public string Name { get { return "Insecure"; } }
		public string Description { get { return "An identified security issue."; } }
		public Risk DefaultRisk { get { return Risk.Extreme; } }
		public Effort DefaultEffort { get { return Effort.Unknown; } }
		public Tag[] Tags { get { return new[]{ Tag.Security, Tag.InSecure, Tag.Degredation }; } }
		public bool OnePerContext { get { return false; } }
	}

	public sealed class TestDefinition : IDefinition, ISafetyGroup, IDegredationTag, IExtremeRiskTag, ISmallEffortTag
	{
		public string Group { get { return "Safety";} }
		public string Name { get { return "Test"; } }
		public string Description { get { return "Test scenario that appears to be missing"; } }
		public Risk DefaultRisk { get { return Risk.Extreme; } }
		public Effort DefaultEffort { get { return Effort.Small; } }
		public Tag[] Tags { get { return new[]{ Tag.Degredation }; } }
		public bool OnePerContext { get { return false; } }
	}

	public sealed class ToxicDefinition : IDefinition, ISafetyGroup, IToxicTag, IDegredationTag, IExtremeRiskTag, IUnknownEffortTag, IOnePerContextTag
	{
		public string Group { get { return "Safety";} }
		public string Name { get { return "Toxic"; } }
		public string Description { get { return "A piece of code that is extremely tempermental, developers should be cautioned, and refactoring is required."; } }
		public Risk DefaultRisk { get { return Risk.Extreme; } }
		public Effort DefaultEffort { get { return Effort.Unknown; } }
		public Tag[] Tags { get { return new[]{ Tag.Toxic, Tag.Degredation }; } }
		public bool OnePerContext { get { return true; } }
	}

	public sealed class CiteDefinition : IDefinition, IBelongingGroup, IMeaningTag, INoneRiskTag, INoneEffortTag
	{
		public string Group { get { return "Belonging";} }
		public string Name { get { return "Cite"; } }
		public string Description { get { return "Used to identify external resources (like StakeOverflow, blogs, etc) that would add value to the context this attribute is applied to."; } }
		public Risk DefaultRisk { get { return Risk.None; } }
		public Effort DefaultEffort { get { return Effort.None; } }
		public Tag[] Tags { get { return new[]{ Tag.Meaning }; } }
		public bool OnePerContext { get { return false; } }
	}

	public sealed class FeatureDefinition : IDefinition, IBelongingGroup, IFeatureTag, INoneRiskTag, INoneEffortTag
	{
		public string Group { get { return "Belonging";} }
		public string Name { get { return "Feature"; } }
		public string Description { get { return "A distinctive function/attribute about what the application does."; } }
		public Risk DefaultRisk { get { return Risk.None; } }
		public Effort DefaultEffort { get { return Effort.None; } }
		public Tag[] Tags { get { return new[]{ Tag.Feature }; } }
		public bool OnePerContext { get { return false; } }
	}

	public sealed class LocationDefinition : IDefinition, IBelongingGroup, IMeaningTag, ILowRiskTag, IUnknownEffortTag, IOnePerContextTag
	{
		public string Group { get { return "Belonging";} }
		public string Name { get { return "Location"; } }
		public string Description { get { return "Piece of code that appears to be in the wrong place."; } }
		public Risk DefaultRisk { get { return Risk.Low; } }
		public Effort DefaultEffort { get { return Effort.Unknown; } }
		public Tag[] Tags { get { return new[]{ Tag.Meaning }; } }
		public bool OnePerContext { get { return true; } }
	}

	public sealed class MajorChangeDefinition : IDefinition, IBelongingGroup, IChangeTag, IMajorTag, INoneRiskTag, INoneEffortTag
	{
		public string Group { get { return "Belonging";} }
		public string Name { get { return "Major Change"; } }
		public string Description { get { return "Identification of a major change that is important to communicate and potentially worthy of moving the version # forward if any exist during deployment (major.minor.incr)."; } }
		public Risk DefaultRisk { get { return Risk.None; } }
		public Effort DefaultEffort { get { return Effort.None; } }
		public Tag[] Tags { get { return new[]{ Tag.Change, Tag.Major }; } }
		public bool OnePerContext { get { return false; } }
	}

	public sealed class MinorChangeDefinition : IDefinition, IBelongingGroup, IChangeTag, IMinorTag, INoneRiskTag, INoneEffortTag
	{
		public string Group { get { return "Belonging";} }
		public string Name { get { return "Minor Change"; } }
		public string Description { get { return "Identification of a minor change that is important to communicate and potentially worthy of moving the version # forward if any exist during deployment (major.minor.incr)."; } }
		public Risk DefaultRisk { get { return Risk.None; } }
		public Effort DefaultEffort { get { return Effort.None; } }
		public Tag[] Tags { get { return new[]{ Tag.Change, Tag.Minor }; } }
		public bool OnePerContext { get { return false; } }
	}

	public sealed class NamingDefinition : IDefinition, IBelongingGroup, IMeaningTag, ILowRiskTag, ISmallEffortTag, IOnePerContextTag
	{
		public string Group { get { return "Belonging";} }
		public string Name { get { return "Naming"; } }
		public string Description { get { return "Intent is clear.  However, naming could be cleaner."; } }
		public Risk DefaultRisk { get { return Risk.Low; } }
		public Effort DefaultEffort { get { return Effort.Small; } }
		public Tag[] Tags { get { return new[]{ Tag.Meaning }; } }
		public bool OnePerContext { get { return true; } }
	}

	public sealed class ReadabilityDefinition : IDefinition, IBelongingGroup, IMeaningTag, ILowRiskTag, ISmallEffortTag, IOnePerContextTag
	{
		public string Group { get { return "Belonging";} }
		public string Name { get { return "Readability"; } }
		public string Description { get { return "Hard to read at first glance for one or more people."; } }
		public Risk DefaultRisk { get { return Risk.Low; } }
		public Effort DefaultEffort { get { return Effort.Small; } }
		public Tag[] Tags { get { return new[]{ Tag.Meaning }; } }
		public bool OnePerContext { get { return true; } }
	}

	public sealed class ReviewedDefinition : IDefinition, IBelongingGroup, IReviewTag, INoneRiskTag, INoneEffortTag
	{
		public string Group { get { return "Belonging";} }
		public string Name { get { return "Reviewed"; } }
		public string Description { get { return "Used to tag that an area of code has been reviewed by one or more people."; } }
		public Risk DefaultRisk { get { return Risk.None; } }
		public Effort DefaultEffort { get { return Effort.None; } }
		public Tag[] Tags { get { return new[]{ Tag.Review }; } }
		public bool OnePerContext { get { return false; } }
	}

	public sealed class StandardsDefinition : IDefinition, IBelongingGroup, IStandardsTag, ILowRiskTag, IVerySmallEffortTag, IOnePerContextTag
	{
		public string Group { get { return "Belonging";} }
		public string Name { get { return "Standards"; } }
		public string Description { get { return "A piece of code that needs refactored to adhere to code/design standards."; } }
		public Risk DefaultRisk { get { return Risk.Low; } }
		public Effort DefaultEffort { get { return Effort.VerySmall; } }
		public Tag[] Tags { get { return new[]{ Tag.Standards }; } }
		public bool OnePerContext { get { return true; } }
	}

	public sealed class ClarificationDefinition : IDefinition, IConfidenceGroup, IMeaningTag, ILowRiskTag, IVerySmallEffortTag
	{
		public string Group { get { return "Confidence";} }
		public string Name { get { return "Clarification"; } }
		public string Description { get { return "Readable, but missing a 'good to know' for people trying to understand."; } }
		public Risk DefaultRisk { get { return Risk.Low; } }
		public Effort DefaultEffort { get { return Effort.VerySmall; } }
		public Tag[] Tags { get { return new[]{ Tag.Meaning }; } }
		public bool OnePerContext { get { return false; } }
	}

	public sealed class FutureDefinition : IDefinition, IConfidenceGroup, IWorkTag, IFutureTag, IYAGNITag, ILowRiskTag, INoneEffortTag
	{
		public string Group { get { return "Confidence";} }
		public string Name { get { return "Future"; } }
		public string Description { get { return "A potential future scenario, in which this will need to be changed or these are some insights about the change."; } }
		public Risk DefaultRisk { get { return Risk.Low; } }
		public Effort DefaultEffort { get { return Effort.None; } }
		public Tag[] Tags { get { return new[]{ Tag.Work, Tag.Future, Tag.YAGNI }; } }
		public bool OnePerContext { get { return false; } }
	}

	public sealed class HackDefinition : IDefinition, IConfidenceGroup, IDegredationTag, IModerateRiskTag, IUnknownEffortTag
	{
		public string Group { get { return "Confidence";} }
		public string Name { get { return "Hack"; } }
		public string Description { get { return "Working feature.  Requires refactoring due to shortcuts needed to make it work."; } }
		public Risk DefaultRisk { get { return Risk.Moderate; } }
		public Effort DefaultEffort { get { return Effort.Unknown; } }
		public Tag[] Tags { get { return new[]{ Tag.Degredation }; } }
		public bool OnePerContext { get { return false; } }
	}

	public sealed class PurposeDefinition : IDefinition, IConfidenceGroup, IMeaningTag, ISRPTag, IModerateRiskTag, IMediumEffortTag, IOnePerContextTag
	{
		public string Group { get { return "Confidence";} }
		public string Name { get { return "Purpose"; } }
		public string Description { get { return "Unsure of actual intent.  Might be doing too many things."; } }
		public Risk DefaultRisk { get { return Risk.Moderate; } }
		public Effort DefaultEffort { get { return Effort.Medium; } }
		public Tag[] Tags { get { return new[]{ Tag.Meaning, Tag.SRP }; } }
		public bool OnePerContext { get { return true; } }
	}

	public sealed class RefactorDefinition : IDefinition, IConfidenceGroup, IDegredationTag, ILowRiskTag, IUnknownEffortTag, IOnePerContextTag
	{
		public string Group { get { return "Confidence";} }
		public string Name { get { return "Refactor"; } }
		public string Description { get { return "Working feature that needs improvement"; } }
		public Risk DefaultRisk { get { return Risk.Low; } }
		public Effort DefaultEffort { get { return Effort.Unknown; } }
		public Tag[] Tags { get { return new[]{ Tag.Degredation }; } }
		public bool OnePerContext { get { return true; } }
	}

	public sealed class DependancyInversionDefinition : IDefinition, IPrinciplesGroup, IPrinciplesTag, ISOLIDTag, IDIPTag, IModerateRiskTag, IMediumEffortTag
	{
		public string Group { get { return "Principles";} }
		public string Name { get { return "Dependancy Inversion"; } }
		public string Description { get { return "[The D in SOLID] Depend upon Abstractions. Do not depend upon concretions."; } }
		public Risk DefaultRisk { get { return Risk.Moderate; } }
		public Effort DefaultEffort { get { return Effort.Medium; } }
		public Tag[] Tags { get { return new[]{ Tag.Principles, Tag.SOLID, Tag.DIP }; } }
		public bool OnePerContext { get { return false; } }
	}

	public sealed class DontRepeatYourselfDefinition : IDefinition, IPrinciplesGroup, IPrinciplesTag, ISOLIDTag, IDRYTag, IModerateRiskTag, IMediumEffortTag
	{
		public string Group { get { return "Principles";} }
		public string Name { get { return "Don't Repeat Yourself"; } }
		public string Description { get { return "(DRY) Every piece of knowledge must have a single, unambiguous, authoritative representation within a system."; } }
		public Risk DefaultRisk { get { return Risk.Moderate; } }
		public Effort DefaultEffort { get { return Effort.Medium; } }
		public Tag[] Tags { get { return new[]{ Tag.Principles, Tag.SOLID, Tag.DRY }; } }
		public bool OnePerContext { get { return false; } }
	}

	public sealed class InterfaceSegregationDefinition : IDefinition, IPrinciplesGroup, IPrinciplesTag, ISOLIDTag, IISPTag, IModerateRiskTag, IMediumEffortTag
	{
		public string Group { get { return "Principles";} }
		public string Name { get { return "Interface Segregation"; } }
		public string Description { get { return "[The I in SOLID] Many client-specific interfaces are better than one general-purpose interface."; } }
		public Risk DefaultRisk { get { return Risk.Moderate; } }
		public Effort DefaultEffort { get { return Effort.Medium; } }
		public Tag[] Tags { get { return new[]{ Tag.Principles, Tag.SOLID, Tag.ISP }; } }
		public bool OnePerContext { get { return false; } }
	}

	public sealed class LeastKnowledgeDefinition : IDefinition, IPrinciplesGroup, IPrinciplesTag, ILoDTag, IModerateRiskTag, IMediumEffortTag
	{
		public string Group { get { return "Principles";} }
		public string Name { get { return "Least Knowledge"; } }
		public string Description { get { return "[Law of Demeter] A component or object shold not know about internal details of other components or objects."; } }
		public Risk DefaultRisk { get { return Risk.Moderate; } }
		public Effort DefaultEffort { get { return Effort.Medium; } }
		public Tag[] Tags { get { return new[]{ Tag.Principles, Tag.LoD }; } }
		public bool OnePerContext { get { return false; } }
	}

	public sealed class LiskovSubstitutionDefinition : IDefinition, IPrinciplesGroup, IPrinciplesTag, ISOLIDTag, ILSPTag, IModerateRiskTag, IMediumEffortTag
	{
		public string Group { get { return "Principles";} }
		public string Name { get { return "Liskov Substitution"; } }
		public string Description { get { return "[The L in SOLID] Objects in a program should be replaceable with instances of their subtypes without altering the correctness of that program."; } }
		public Risk DefaultRisk { get { return Risk.Moderate; } }
		public Effort DefaultEffort { get { return Effort.Medium; } }
		public Tag[] Tags { get { return new[]{ Tag.Principles, Tag.SOLID, Tag.LSP }; } }
		public bool OnePerContext { get { return false; } }
	}

	public sealed class OccamsRazorDefinition : IDefinition, IPrinciplesGroup, IPrinciplesTag, IModerateRiskTag, IMediumEffortTag
	{
		public string Group { get { return "Principles";} }
		public string Name { get { return "Occams Razor"; } }
		public string Description { get { return "The path with the fewest assumptions should be selected even if other directions may eventually prove correct."; } }
		public Risk DefaultRisk { get { return Risk.Moderate; } }
		public Effort DefaultEffort { get { return Effort.Medium; } }
		public Tag[] Tags { get { return new[]{ Tag.Principles }; } }
		public bool OnePerContext { get { return false; } }
	}

	public sealed class OpenClosedDefinition : IDefinition, IPrinciplesGroup, IPrinciplesTag, ISOLIDTag, IOCPTag, IModerateRiskTag, IMediumEffortTag
	{
		public string Group { get { return "Principles";} }
		public string Name { get { return "Open Closed"; } }
		public string Description { get { return "[The O in SOLID] Software entities should be open for extension, but closed for modification."; } }
		public Risk DefaultRisk { get { return Risk.Moderate; } }
		public Effort DefaultEffort { get { return Effort.Medium; } }
		public Tag[] Tags { get { return new[]{ Tag.Principles, Tag.SOLID, Tag.OCP }; } }
		public bool OnePerContext { get { return false; } }
	}

	public sealed class SeparationOfConcernsDefinition : IDefinition, IPrinciplesGroup, IPrinciplesTag, ISoCTag, IModerateRiskTag, IMediumEffortTag
	{
		public string Group { get { return "Principles";} }
		public string Name { get { return "Separation Of Concerns"; } }
		public string Description { get { return "The design should divide areas of concern into their own distinct sections."; } }
		public Risk DefaultRisk { get { return Risk.Moderate; } }
		public Effort DefaultEffort { get { return Effort.Medium; } }
		public Tag[] Tags { get { return new[]{ Tag.Principles, Tag.SoC }; } }
		public bool OnePerContext { get { return false; } }
	}

	public sealed class SingleResponsibilityDefinition : IDefinition, IPrinciplesGroup, IPrinciplesTag, ISOLIDTag, ISRPTag, IModerateRiskTag, IMediumEffortTag
	{
		public string Group { get { return "Principles";} }
		public string Name { get { return "Single Responsibility"; } }
		public string Description { get { return "[The S in SOLID] Each context of code should do one thing and thus have only one reason to change."; } }
		public Risk DefaultRisk { get { return Risk.Moderate; } }
		public Effort DefaultEffort { get { return Effort.Medium; } }
		public Tag[] Tags { get { return new[]{ Tag.Principles, Tag.SOLID, Tag.SRP }; } }
		public bool OnePerContext { get { return false; } }
	}

	public sealed class YouArentGonnaNeedItDefinition : IDefinition, IPrinciplesGroup, IPrinciplesTag, IYAGNITag, IModerateRiskTag, IMediumEffortTag
	{
		public string Group { get { return "Principles";} }
		public string Name { get { return "You Aren't Gonna Need It"; } }
		public string Description { get { return "Always implement things when you actually need them, never when you just foresee that you need them."; } }
		public Risk DefaultRisk { get { return Risk.Moderate; } }
		public Effort DefaultEffort { get { return Effort.Medium; } }
		public Tag[] Tags { get { return new[]{ Tag.Principles, Tag.YAGNI }; } }
		public bool OnePerContext { get { return false; } }
	}


}

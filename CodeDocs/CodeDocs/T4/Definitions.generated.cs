
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Definitions
{

    /// <summary>
    /// Definition class for Bug
    /// </summary>
	public sealed class BugDefinition : IDefinition, IFunctionalGroup, IDegredationTag, IExtremeRiskTag, IUnknownEffortTag
	{
		/// <summary>
		/// Name of the primary group this definition is organized into
		/// </summary>
		public string Group { get { return "Functional";} }

		/// <summary>
		/// Name of the definition
		/// </summary>
		public string Name { get { return "Bug"; } }

		/// <summary>
		/// Decription of the definition (ie the "definition" itself)
		/// </summary>
		public string Description { get { return "Used to acknowledge and identify code that has a live issue even though a resolution has not been identified or implemented."; } }

		/// <summary>
		/// Default risk used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Risk DefaultRisk { get { return Risk.Extreme; } }

		/// <summary>
		/// Default effort used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Effort DefaultEffort { get { return Effort.Unknown; } }

		/// <summary>
		/// Set of tags used to aid in describing the definition.  Also applied to the attribute as an interface for polymorphic routing.
		/// </summary>
		public Tag[] Tags { get { return new[]{ Tag.Degredation }; } }

		/// <summary>
		/// Identifies if an attribute of this type can only be attached one at a time to a particular context.
		/// </summary>
		public bool OnePerContext { get { return false; } }
	}

    /// <summary>
    /// Definition class for MajorFix
    /// </summary>
	public sealed class MajorFixDefinition : IDefinition, IFunctionalGroup, IChangeTag, IMajorTag, IFixTag, INoneRiskTag, INoneEffortTag
	{
		/// <summary>
		/// Name of the primary group this definition is organized into
		/// </summary>
		public string Group { get { return "Functional";} }

		/// <summary>
		/// Name of the definition
		/// </summary>
		public string Name { get { return "Major Fix"; } }

		/// <summary>
		/// Decription of the definition (ie the "definition" itself)
		/// </summary>
		public string Description { get { return "Identification of a major fix that is important to communicate and potentially worthy of moving the [incr] version # forward if any exist during deployment (major.minor.incr)."; } }

		/// <summary>
		/// Default risk used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Risk DefaultRisk { get { return Risk.None; } }

		/// <summary>
		/// Default effort used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Effort DefaultEffort { get { return Effort.None; } }

		/// <summary>
		/// Set of tags used to aid in describing the definition.  Also applied to the attribute as an interface for polymorphic routing.
		/// </summary>
		public Tag[] Tags { get { return new[]{ Tag.Change, Tag.Major, Tag.Fix }; } }

		/// <summary>
		/// Identifies if an attribute of this type can only be attached one at a time to a particular context.
		/// </summary>
		public bool OnePerContext { get { return false; } }
	}

    /// <summary>
    /// Definition class for MinorFix
    /// </summary>
	public sealed class MinorFixDefinition : IDefinition, IFunctionalGroup, IChangeTag, IMinorTag, IFixTag, INoneRiskTag, INoneEffortTag
	{
		/// <summary>
		/// Name of the primary group this definition is organized into
		/// </summary>
		public string Group { get { return "Functional";} }

		/// <summary>
		/// Name of the definition
		/// </summary>
		public string Name { get { return "Minor Fix"; } }

		/// <summary>
		/// Decription of the definition (ie the "definition" itself)
		/// </summary>
		public string Description { get { return "Identification of a minor fix that is important to communicate and potentially worthy of moving the [incr] version # forward if any exist during deployment (major.minor.incr)."; } }

		/// <summary>
		/// Default risk used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Risk DefaultRisk { get { return Risk.None; } }

		/// <summary>
		/// Default effort used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Effort DefaultEffort { get { return Effort.None; } }

		/// <summary>
		/// Set of tags used to aid in describing the definition.  Also applied to the attribute as an interface for polymorphic routing.
		/// </summary>
		public Tag[] Tags { get { return new[]{ Tag.Change, Tag.Minor, Tag.Fix }; } }

		/// <summary>
		/// Identifies if an attribute of this type can only be attached one at a time to a particular context.
		/// </summary>
		public bool OnePerContext { get { return false; } }
	}

    /// <summary>
    /// Definition class for Slow
    /// </summary>
	public sealed class SlowDefinition : IDefinition, IFunctionalGroup, IPerformanceTag, IDegredationTag, IModerateRiskTag, IMediumEffortTag, IOnePerContextTag
	{
		/// <summary>
		/// Name of the primary group this definition is organized into
		/// </summary>
		public string Group { get { return "Functional";} }

		/// <summary>
		/// Name of the definition
		/// </summary>
		public string Name { get { return "Slow"; } }

		/// <summary>
		/// Decription of the definition (ie the "definition" itself)
		/// </summary>
		public string Description { get { return "A piece of code that is slower than desired and need refactored."; } }

		/// <summary>
		/// Default risk used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Risk DefaultRisk { get { return Risk.Moderate; } }

		/// <summary>
		/// Default effort used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Effort DefaultEffort { get { return Effort.Medium; } }

		/// <summary>
		/// Set of tags used to aid in describing the definition.  Also applied to the attribute as an interface for polymorphic routing.
		/// </summary>
		public Tag[] Tags { get { return new[]{ Tag.Performance, Tag.Degredation }; } }

		/// <summary>
		/// Identifies if an attribute of this type can only be attached one at a time to a particular context.
		/// </summary>
		public bool OnePerContext { get { return true; } }
	}

    /// <summary>
    /// Definition class for Todo
    /// </summary>
	public sealed class TodoDefinition : IDefinition, IFunctionalGroup, IWorkTag, IDegredationTag, IExtremeRiskTag, IMediumEffortTag
	{
		/// <summary>
		/// Name of the primary group this definition is organized into
		/// </summary>
		public string Group { get { return "Functional";} }

		/// <summary>
		/// Name of the definition
		/// </summary>
		public string Name { get { return "Todo"; } }

		/// <summary>
		/// Decription of the definition (ie the "definition" itself)
		/// </summary>
		public string Description { get { return "Uncompleted feature."; } }

		/// <summary>
		/// Default risk used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Risk DefaultRisk { get { return Risk.Extreme; } }

		/// <summary>
		/// Default effort used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Effort DefaultEffort { get { return Effort.Medium; } }

		/// <summary>
		/// Set of tags used to aid in describing the definition.  Also applied to the attribute as an interface for polymorphic routing.
		/// </summary>
		public Tag[] Tags { get { return new[]{ Tag.Work, Tag.Degredation }; } }

		/// <summary>
		/// Identifies if an attribute of this type can only be attached one at a time to a particular context.
		/// </summary>
		public bool OnePerContext { get { return false; } }
	}

    /// <summary>
    /// Definition class for Consequence
    /// </summary>
	public sealed class ConsequenceDefinition : IDefinition, ISafetyGroup, IConsequenceTag, IModerateRiskTag, IUnknownEffortTag
	{
		/// <summary>
		/// Name of the primary group this definition is organized into
		/// </summary>
		public string Group { get { return "Safety";} }

		/// <summary>
		/// Name of the definition
		/// </summary>
		public string Name { get { return "Consequence"; } }

		/// <summary>
		/// Decription of the definition (ie the "definition" itself)
		/// </summary>
		public string Description { get { return "A side-effect that may occur either by the behavior of the code or if a change is made to the code."; } }

		/// <summary>
		/// Default risk used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Risk DefaultRisk { get { return Risk.Moderate; } }

		/// <summary>
		/// Default effort used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Effort DefaultEffort { get { return Effort.Unknown; } }

		/// <summary>
		/// Set of tags used to aid in describing the definition.  Also applied to the attribute as an interface for polymorphic routing.
		/// </summary>
		public Tag[] Tags { get { return new[]{ Tag.Consequence }; } }

		/// <summary>
		/// Identifies if an attribute of this type can only be attached one at a time to a particular context.
		/// </summary>
		public bool OnePerContext { get { return false; } }
	}

    /// <summary>
    /// Definition class for DeadCode
    /// </summary>
	public sealed class DeadCodeDefinition : IDefinition, ISafetyGroup, IDeadCodeTag, IConsequenceTag, ILowRiskTag, IVerySmallEffortTag, IOnePerContextTag
	{
		/// <summary>
		/// Name of the primary group this definition is organized into
		/// </summary>
		public string Group { get { return "Safety";} }

		/// <summary>
		/// Name of the definition
		/// </summary>
		public string Name { get { return "Dead Code"; } }

		/// <summary>
		/// Decription of the definition (ie the "definition" itself)
		/// </summary>
		public string Description { get { return "Typically code that is commented out or code that exists but is never used."; } }

		/// <summary>
		/// Default risk used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Risk DefaultRisk { get { return Risk.Low; } }

		/// <summary>
		/// Default effort used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Effort DefaultEffort { get { return Effort.VerySmall; } }

		/// <summary>
		/// Set of tags used to aid in describing the definition.  Also applied to the attribute as an interface for polymorphic routing.
		/// </summary>
		public Tag[] Tags { get { return new[]{ Tag.DeadCode, Tag.Consequence }; } }

		/// <summary>
		/// Identifies if an attribute of this type can only be attached one at a time to a particular context.
		/// </summary>
		public bool OnePerContext { get { return true; } }
	}

    /// <summary>
    /// Definition class for Security
    /// </summary>
	public sealed class SecurityDefinition : IDefinition, ISafetyGroup, ISecurityTag, INoneRiskTag, INoneEffortTag
	{
		/// <summary>
		/// Name of the primary group this definition is organized into
		/// </summary>
		public string Group { get { return "Safety";} }

		/// <summary>
		/// Name of the definition
		/// </summary>
		public string Name { get { return "Security"; } }

		/// <summary>
		/// Decription of the definition (ie the "definition" itself)
		/// </summary>
		public string Description { get { return "A note about security in relation to the context, not necessarily a risk."; } }

		/// <summary>
		/// Default risk used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Risk DefaultRisk { get { return Risk.None; } }

		/// <summary>
		/// Default effort used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Effort DefaultEffort { get { return Effort.None; } }

		/// <summary>
		/// Set of tags used to aid in describing the definition.  Also applied to the attribute as an interface for polymorphic routing.
		/// </summary>
		public Tag[] Tags { get { return new[]{ Tag.Security }; } }

		/// <summary>
		/// Identifies if an attribute of this type can only be attached one at a time to a particular context.
		/// </summary>
		public bool OnePerContext { get { return false; } }
	}

    /// <summary>
    /// Definition class for Insecure
    /// </summary>
	public sealed class InsecureDefinition : IDefinition, ISafetyGroup, ISecurityTag, IInSecureTag, IDegredationTag, IExtremeRiskTag, IUnknownEffortTag
	{
		/// <summary>
		/// Name of the primary group this definition is organized into
		/// </summary>
		public string Group { get { return "Safety";} }

		/// <summary>
		/// Name of the definition
		/// </summary>
		public string Name { get { return "Insecure"; } }

		/// <summary>
		/// Decription of the definition (ie the "definition" itself)
		/// </summary>
		public string Description { get { return "An identified security issue."; } }

		/// <summary>
		/// Default risk used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Risk DefaultRisk { get { return Risk.Extreme; } }

		/// <summary>
		/// Default effort used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Effort DefaultEffort { get { return Effort.Unknown; } }

		/// <summary>
		/// Set of tags used to aid in describing the definition.  Also applied to the attribute as an interface for polymorphic routing.
		/// </summary>
		public Tag[] Tags { get { return new[]{ Tag.Security, Tag.InSecure, Tag.Degredation }; } }

		/// <summary>
		/// Identifies if an attribute of this type can only be attached one at a time to a particular context.
		/// </summary>
		public bool OnePerContext { get { return false; } }
	}

    /// <summary>
    /// Definition class for Test
    /// </summary>
	public sealed class TestDefinition : IDefinition, ISafetyGroup, IDegredationTag, IExtremeRiskTag, ISmallEffortTag
	{
		/// <summary>
		/// Name of the primary group this definition is organized into
		/// </summary>
		public string Group { get { return "Safety";} }

		/// <summary>
		/// Name of the definition
		/// </summary>
		public string Name { get { return "Test"; } }

		/// <summary>
		/// Decription of the definition (ie the "definition" itself)
		/// </summary>
		public string Description { get { return "Test scenario that appears to be missing"; } }

		/// <summary>
		/// Default risk used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Risk DefaultRisk { get { return Risk.Extreme; } }

		/// <summary>
		/// Default effort used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Effort DefaultEffort { get { return Effort.Small; } }

		/// <summary>
		/// Set of tags used to aid in describing the definition.  Also applied to the attribute as an interface for polymorphic routing.
		/// </summary>
		public Tag[] Tags { get { return new[]{ Tag.Degredation }; } }

		/// <summary>
		/// Identifies if an attribute of this type can only be attached one at a time to a particular context.
		/// </summary>
		public bool OnePerContext { get { return false; } }
	}

    /// <summary>
    /// Definition class for Toxic
    /// </summary>
	public sealed class ToxicDefinition : IDefinition, ISafetyGroup, IToxicTag, IDegredationTag, IExtremeRiskTag, IUnknownEffortTag, IOnePerContextTag
	{
		/// <summary>
		/// Name of the primary group this definition is organized into
		/// </summary>
		public string Group { get { return "Safety";} }

		/// <summary>
		/// Name of the definition
		/// </summary>
		public string Name { get { return "Toxic"; } }

		/// <summary>
		/// Decription of the definition (ie the "definition" itself)
		/// </summary>
		public string Description { get { return "A piece of code that is extremely tempermental, developers should be cautioned, and refactoring is required."; } }

		/// <summary>
		/// Default risk used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Risk DefaultRisk { get { return Risk.Extreme; } }

		/// <summary>
		/// Default effort used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Effort DefaultEffort { get { return Effort.Unknown; } }

		/// <summary>
		/// Set of tags used to aid in describing the definition.  Also applied to the attribute as an interface for polymorphic routing.
		/// </summary>
		public Tag[] Tags { get { return new[]{ Tag.Toxic, Tag.Degredation }; } }

		/// <summary>
		/// Identifies if an attribute of this type can only be attached one at a time to a particular context.
		/// </summary>
		public bool OnePerContext { get { return true; } }
	}

    /// <summary>
    /// Definition class for Cite
    /// </summary>
	public sealed class CiteDefinition : IDefinition, IBelongingGroup, IMeaningTag, INoneRiskTag, INoneEffortTag
	{
		/// <summary>
		/// Name of the primary group this definition is organized into
		/// </summary>
		public string Group { get { return "Belonging";} }

		/// <summary>
		/// Name of the definition
		/// </summary>
		public string Name { get { return "Cite"; } }

		/// <summary>
		/// Decription of the definition (ie the "definition" itself)
		/// </summary>
		public string Description { get { return "Used to identify external resources (like StakeOverflow, blogs, etc) that would add value to the context this attribute is applied to."; } }

		/// <summary>
		/// Default risk used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Risk DefaultRisk { get { return Risk.None; } }

		/// <summary>
		/// Default effort used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Effort DefaultEffort { get { return Effort.None; } }

		/// <summary>
		/// Set of tags used to aid in describing the definition.  Also applied to the attribute as an interface for polymorphic routing.
		/// </summary>
		public Tag[] Tags { get { return new[]{ Tag.Meaning }; } }

		/// <summary>
		/// Identifies if an attribute of this type can only be attached one at a time to a particular context.
		/// </summary>
		public bool OnePerContext { get { return false; } }
	}

    /// <summary>
    /// Definition class for Feature
    /// </summary>
	public sealed class FeatureDefinition : IDefinition, IBelongingGroup, IFeatureTag, INoneRiskTag, INoneEffortTag
	{
		/// <summary>
		/// Name of the primary group this definition is organized into
		/// </summary>
		public string Group { get { return "Belonging";} }

		/// <summary>
		/// Name of the definition
		/// </summary>
		public string Name { get { return "Feature"; } }

		/// <summary>
		/// Decription of the definition (ie the "definition" itself)
		/// </summary>
		public string Description { get { return "A distinctive function/attribute about what the application does."; } }

		/// <summary>
		/// Default risk used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Risk DefaultRisk { get { return Risk.None; } }

		/// <summary>
		/// Default effort used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Effort DefaultEffort { get { return Effort.None; } }

		/// <summary>
		/// Set of tags used to aid in describing the definition.  Also applied to the attribute as an interface for polymorphic routing.
		/// </summary>
		public Tag[] Tags { get { return new[]{ Tag.Feature }; } }

		/// <summary>
		/// Identifies if an attribute of this type can only be attached one at a time to a particular context.
		/// </summary>
		public bool OnePerContext { get { return false; } }
	}

    /// <summary>
    /// Definition class for Location
    /// </summary>
	public sealed class LocationDefinition : IDefinition, IBelongingGroup, IMeaningTag, ILowRiskTag, IUnknownEffortTag, IOnePerContextTag
	{
		/// <summary>
		/// Name of the primary group this definition is organized into
		/// </summary>
		public string Group { get { return "Belonging";} }

		/// <summary>
		/// Name of the definition
		/// </summary>
		public string Name { get { return "Location"; } }

		/// <summary>
		/// Decription of the definition (ie the "definition" itself)
		/// </summary>
		public string Description { get { return "Piece of code that appears to be in the wrong place."; } }

		/// <summary>
		/// Default risk used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Risk DefaultRisk { get { return Risk.Low; } }

		/// <summary>
		/// Default effort used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Effort DefaultEffort { get { return Effort.Unknown; } }

		/// <summary>
		/// Set of tags used to aid in describing the definition.  Also applied to the attribute as an interface for polymorphic routing.
		/// </summary>
		public Tag[] Tags { get { return new[]{ Tag.Meaning }; } }

		/// <summary>
		/// Identifies if an attribute of this type can only be attached one at a time to a particular context.
		/// </summary>
		public bool OnePerContext { get { return true; } }
	}

    /// <summary>
    /// Definition class for MajorChange
    /// </summary>
	public sealed class MajorChangeDefinition : IDefinition, IBelongingGroup, IChangeTag, IMajorTag, INoneRiskTag, INoneEffortTag
	{
		/// <summary>
		/// Name of the primary group this definition is organized into
		/// </summary>
		public string Group { get { return "Belonging";} }

		/// <summary>
		/// Name of the definition
		/// </summary>
		public string Name { get { return "Major Change"; } }

		/// <summary>
		/// Decription of the definition (ie the "definition" itself)
		/// </summary>
		public string Description { get { return "Identification of a major change that is important to communicate and potentially worthy of moving the version # forward if any exist during deployment (major.minor.incr)."; } }

		/// <summary>
		/// Default risk used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Risk DefaultRisk { get { return Risk.None; } }

		/// <summary>
		/// Default effort used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Effort DefaultEffort { get { return Effort.None; } }

		/// <summary>
		/// Set of tags used to aid in describing the definition.  Also applied to the attribute as an interface for polymorphic routing.
		/// </summary>
		public Tag[] Tags { get { return new[]{ Tag.Change, Tag.Major }; } }

		/// <summary>
		/// Identifies if an attribute of this type can only be attached one at a time to a particular context.
		/// </summary>
		public bool OnePerContext { get { return false; } }
	}

    /// <summary>
    /// Definition class for MinorChange
    /// </summary>
	public sealed class MinorChangeDefinition : IDefinition, IBelongingGroup, IChangeTag, IMinorTag, INoneRiskTag, INoneEffortTag
	{
		/// <summary>
		/// Name of the primary group this definition is organized into
		/// </summary>
		public string Group { get { return "Belonging";} }

		/// <summary>
		/// Name of the definition
		/// </summary>
		public string Name { get { return "Minor Change"; } }

		/// <summary>
		/// Decription of the definition (ie the "definition" itself)
		/// </summary>
		public string Description { get { return "Identification of a minor change that is important to communicate and potentially worthy of moving the version # forward if any exist during deployment (major.minor.incr)."; } }

		/// <summary>
		/// Default risk used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Risk DefaultRisk { get { return Risk.None; } }

		/// <summary>
		/// Default effort used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Effort DefaultEffort { get { return Effort.None; } }

		/// <summary>
		/// Set of tags used to aid in describing the definition.  Also applied to the attribute as an interface for polymorphic routing.
		/// </summary>
		public Tag[] Tags { get { return new[]{ Tag.Change, Tag.Minor }; } }

		/// <summary>
		/// Identifies if an attribute of this type can only be attached one at a time to a particular context.
		/// </summary>
		public bool OnePerContext { get { return false; } }
	}

    /// <summary>
    /// Definition class for Naming
    /// </summary>
	public sealed class NamingDefinition : IDefinition, IBelongingGroup, IMeaningTag, ILowRiskTag, ISmallEffortTag, IOnePerContextTag
	{
		/// <summary>
		/// Name of the primary group this definition is organized into
		/// </summary>
		public string Group { get { return "Belonging";} }

		/// <summary>
		/// Name of the definition
		/// </summary>
		public string Name { get { return "Naming"; } }

		/// <summary>
		/// Decription of the definition (ie the "definition" itself)
		/// </summary>
		public string Description { get { return "Intent is clear.  However, naming could be cleaner."; } }

		/// <summary>
		/// Default risk used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Risk DefaultRisk { get { return Risk.Low; } }

		/// <summary>
		/// Default effort used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Effort DefaultEffort { get { return Effort.Small; } }

		/// <summary>
		/// Set of tags used to aid in describing the definition.  Also applied to the attribute as an interface for polymorphic routing.
		/// </summary>
		public Tag[] Tags { get { return new[]{ Tag.Meaning }; } }

		/// <summary>
		/// Identifies if an attribute of this type can only be attached one at a time to a particular context.
		/// </summary>
		public bool OnePerContext { get { return true; } }
	}

    /// <summary>
    /// Definition class for Readability
    /// </summary>
	public sealed class ReadabilityDefinition : IDefinition, IBelongingGroup, IMeaningTag, ILowRiskTag, ISmallEffortTag, IOnePerContextTag
	{
		/// <summary>
		/// Name of the primary group this definition is organized into
		/// </summary>
		public string Group { get { return "Belonging";} }

		/// <summary>
		/// Name of the definition
		/// </summary>
		public string Name { get { return "Readability"; } }

		/// <summary>
		/// Decription of the definition (ie the "definition" itself)
		/// </summary>
		public string Description { get { return "Hard to read at first glance for one or more people."; } }

		/// <summary>
		/// Default risk used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Risk DefaultRisk { get { return Risk.Low; } }

		/// <summary>
		/// Default effort used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Effort DefaultEffort { get { return Effort.Small; } }

		/// <summary>
		/// Set of tags used to aid in describing the definition.  Also applied to the attribute as an interface for polymorphic routing.
		/// </summary>
		public Tag[] Tags { get { return new[]{ Tag.Meaning }; } }

		/// <summary>
		/// Identifies if an attribute of this type can only be attached one at a time to a particular context.
		/// </summary>
		public bool OnePerContext { get { return true; } }
	}

    /// <summary>
    /// Definition class for Reviewed
    /// </summary>
	public sealed class ReviewedDefinition : IDefinition, IBelongingGroup, IReviewTag, INoneRiskTag, INoneEffortTag
	{
		/// <summary>
		/// Name of the primary group this definition is organized into
		/// </summary>
		public string Group { get { return "Belonging";} }

		/// <summary>
		/// Name of the definition
		/// </summary>
		public string Name { get { return "Reviewed"; } }

		/// <summary>
		/// Decription of the definition (ie the "definition" itself)
		/// </summary>
		public string Description { get { return "Used to tag that an area of code has been reviewed by one or more people."; } }

		/// <summary>
		/// Default risk used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Risk DefaultRisk { get { return Risk.None; } }

		/// <summary>
		/// Default effort used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Effort DefaultEffort { get { return Effort.None; } }

		/// <summary>
		/// Set of tags used to aid in describing the definition.  Also applied to the attribute as an interface for polymorphic routing.
		/// </summary>
		public Tag[] Tags { get { return new[]{ Tag.Review }; } }

		/// <summary>
		/// Identifies if an attribute of this type can only be attached one at a time to a particular context.
		/// </summary>
		public bool OnePerContext { get { return false; } }
	}

    /// <summary>
    /// Definition class for Standards
    /// </summary>
	public sealed class StandardsDefinition : IDefinition, IBelongingGroup, IStandardsTag, ILowRiskTag, IVerySmallEffortTag, IOnePerContextTag
	{
		/// <summary>
		/// Name of the primary group this definition is organized into
		/// </summary>
		public string Group { get { return "Belonging";} }

		/// <summary>
		/// Name of the definition
		/// </summary>
		public string Name { get { return "Standards"; } }

		/// <summary>
		/// Decription of the definition (ie the "definition" itself)
		/// </summary>
		public string Description { get { return "A piece of code that needs refactored to adhere to code/design standards."; } }

		/// <summary>
		/// Default risk used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Risk DefaultRisk { get { return Risk.Low; } }

		/// <summary>
		/// Default effort used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Effort DefaultEffort { get { return Effort.VerySmall; } }

		/// <summary>
		/// Set of tags used to aid in describing the definition.  Also applied to the attribute as an interface for polymorphic routing.
		/// </summary>
		public Tag[] Tags { get { return new[]{ Tag.Standards }; } }

		/// <summary>
		/// Identifies if an attribute of this type can only be attached one at a time to a particular context.
		/// </summary>
		public bool OnePerContext { get { return true; } }
	}

    /// <summary>
    /// Definition class for Clarification
    /// </summary>
	public sealed class ClarificationDefinition : IDefinition, IConfidenceGroup, IMeaningTag, ILowRiskTag, IVerySmallEffortTag
	{
		/// <summary>
		/// Name of the primary group this definition is organized into
		/// </summary>
		public string Group { get { return "Confidence";} }

		/// <summary>
		/// Name of the definition
		/// </summary>
		public string Name { get { return "Clarification"; } }

		/// <summary>
		/// Decription of the definition (ie the "definition" itself)
		/// </summary>
		public string Description { get { return "Readable, but missing a 'good to know' for people trying to understand."; } }

		/// <summary>
		/// Default risk used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Risk DefaultRisk { get { return Risk.Low; } }

		/// <summary>
		/// Default effort used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Effort DefaultEffort { get { return Effort.VerySmall; } }

		/// <summary>
		/// Set of tags used to aid in describing the definition.  Also applied to the attribute as an interface for polymorphic routing.
		/// </summary>
		public Tag[] Tags { get { return new[]{ Tag.Meaning }; } }

		/// <summary>
		/// Identifies if an attribute of this type can only be attached one at a time to a particular context.
		/// </summary>
		public bool OnePerContext { get { return false; } }
	}

    /// <summary>
    /// Definition class for Future
    /// </summary>
	public sealed class FutureDefinition : IDefinition, IConfidenceGroup, IWorkTag, IFutureTag, IYAGNITag, ILowRiskTag, INoneEffortTag
	{
		/// <summary>
		/// Name of the primary group this definition is organized into
		/// </summary>
		public string Group { get { return "Confidence";} }

		/// <summary>
		/// Name of the definition
		/// </summary>
		public string Name { get { return "Future"; } }

		/// <summary>
		/// Decription of the definition (ie the "definition" itself)
		/// </summary>
		public string Description { get { return "A potential future scenario, in which this will need to be changed or these are some insights about the change."; } }

		/// <summary>
		/// Default risk used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Risk DefaultRisk { get { return Risk.Low; } }

		/// <summary>
		/// Default effort used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Effort DefaultEffort { get { return Effort.None; } }

		/// <summary>
		/// Set of tags used to aid in describing the definition.  Also applied to the attribute as an interface for polymorphic routing.
		/// </summary>
		public Tag[] Tags { get { return new[]{ Tag.Work, Tag.Future, Tag.YAGNI }; } }

		/// <summary>
		/// Identifies if an attribute of this type can only be attached one at a time to a particular context.
		/// </summary>
		public bool OnePerContext { get { return false; } }
	}

    /// <summary>
    /// Definition class for Hack
    /// </summary>
	public sealed class HackDefinition : IDefinition, IConfidenceGroup, IDegredationTag, IModerateRiskTag, IUnknownEffortTag
	{
		/// <summary>
		/// Name of the primary group this definition is organized into
		/// </summary>
		public string Group { get { return "Confidence";} }

		/// <summary>
		/// Name of the definition
		/// </summary>
		public string Name { get { return "Hack"; } }

		/// <summary>
		/// Decription of the definition (ie the "definition" itself)
		/// </summary>
		public string Description { get { return "Working feature.  Requires refactoring due to shortcuts needed to make it work."; } }

		/// <summary>
		/// Default risk used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Risk DefaultRisk { get { return Risk.Moderate; } }

		/// <summary>
		/// Default effort used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Effort DefaultEffort { get { return Effort.Unknown; } }

		/// <summary>
		/// Set of tags used to aid in describing the definition.  Also applied to the attribute as an interface for polymorphic routing.
		/// </summary>
		public Tag[] Tags { get { return new[]{ Tag.Degredation }; } }

		/// <summary>
		/// Identifies if an attribute of this type can only be attached one at a time to a particular context.
		/// </summary>
		public bool OnePerContext { get { return false; } }
	}

    /// <summary>
    /// Definition class for Purpose
    /// </summary>
	public sealed class PurposeDefinition : IDefinition, IConfidenceGroup, IMeaningTag, ISRPTag, IModerateRiskTag, IMediumEffortTag, IOnePerContextTag
	{
		/// <summary>
		/// Name of the primary group this definition is organized into
		/// </summary>
		public string Group { get { return "Confidence";} }

		/// <summary>
		/// Name of the definition
		/// </summary>
		public string Name { get { return "Purpose"; } }

		/// <summary>
		/// Decription of the definition (ie the "definition" itself)
		/// </summary>
		public string Description { get { return "Unsure of actual intent.  Might be doing too many things."; } }

		/// <summary>
		/// Default risk used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Risk DefaultRisk { get { return Risk.Moderate; } }

		/// <summary>
		/// Default effort used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Effort DefaultEffort { get { return Effort.Medium; } }

		/// <summary>
		/// Set of tags used to aid in describing the definition.  Also applied to the attribute as an interface for polymorphic routing.
		/// </summary>
		public Tag[] Tags { get { return new[]{ Tag.Meaning, Tag.SRP }; } }

		/// <summary>
		/// Identifies if an attribute of this type can only be attached one at a time to a particular context.
		/// </summary>
		public bool OnePerContext { get { return true; } }
	}

    /// <summary>
    /// Definition class for Refactor
    /// </summary>
	public sealed class RefactorDefinition : IDefinition, IConfidenceGroup, IDegredationTag, ILowRiskTag, IUnknownEffortTag, IOnePerContextTag
	{
		/// <summary>
		/// Name of the primary group this definition is organized into
		/// </summary>
		public string Group { get { return "Confidence";} }

		/// <summary>
		/// Name of the definition
		/// </summary>
		public string Name { get { return "Refactor"; } }

		/// <summary>
		/// Decription of the definition (ie the "definition" itself)
		/// </summary>
		public string Description { get { return "Working feature that needs improvement"; } }

		/// <summary>
		/// Default risk used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Risk DefaultRisk { get { return Risk.Low; } }

		/// <summary>
		/// Default effort used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Effort DefaultEffort { get { return Effort.Unknown; } }

		/// <summary>
		/// Set of tags used to aid in describing the definition.  Also applied to the attribute as an interface for polymorphic routing.
		/// </summary>
		public Tag[] Tags { get { return new[]{ Tag.Degredation }; } }

		/// <summary>
		/// Identifies if an attribute of this type can only be attached one at a time to a particular context.
		/// </summary>
		public bool OnePerContext { get { return true; } }
	}

    /// <summary>
    /// Definition class for DependancyInversion
    /// </summary>
	public sealed class DependancyInversionDefinition : IDefinition, IPrinciplesGroup, IPrinciplesTag, ISOLIDTag, IDIPTag, IModerateRiskTag, IMediumEffortTag
	{
		/// <summary>
		/// Name of the primary group this definition is organized into
		/// </summary>
		public string Group { get { return "Principles";} }

		/// <summary>
		/// Name of the definition
		/// </summary>
		public string Name { get { return "Dependancy Inversion"; } }

		/// <summary>
		/// Decription of the definition (ie the "definition" itself)
		/// </summary>
		public string Description { get { return "[The D in SOLID] Depend upon Abstractions. Do not depend upon concretions."; } }

		/// <summary>
		/// Default risk used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Risk DefaultRisk { get { return Risk.Moderate; } }

		/// <summary>
		/// Default effort used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Effort DefaultEffort { get { return Effort.Medium; } }

		/// <summary>
		/// Set of tags used to aid in describing the definition.  Also applied to the attribute as an interface for polymorphic routing.
		/// </summary>
		public Tag[] Tags { get { return new[]{ Tag.Principles, Tag.SOLID, Tag.DIP }; } }

		/// <summary>
		/// Identifies if an attribute of this type can only be attached one at a time to a particular context.
		/// </summary>
		public bool OnePerContext { get { return false; } }
	}

    /// <summary>
    /// Definition class for DontRepeatYourself
    /// </summary>
	public sealed class DontRepeatYourselfDefinition : IDefinition, IPrinciplesGroup, IPrinciplesTag, ISOLIDTag, IDRYTag, IModerateRiskTag, IMediumEffortTag
	{
		/// <summary>
		/// Name of the primary group this definition is organized into
		/// </summary>
		public string Group { get { return "Principles";} }

		/// <summary>
		/// Name of the definition
		/// </summary>
		public string Name { get { return "Don't Repeat Yourself"; } }

		/// <summary>
		/// Decription of the definition (ie the "definition" itself)
		/// </summary>
		public string Description { get { return "(DRY) Every piece of knowledge must have a single, unambiguous, authoritative representation within a system."; } }

		/// <summary>
		/// Default risk used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Risk DefaultRisk { get { return Risk.Moderate; } }

		/// <summary>
		/// Default effort used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Effort DefaultEffort { get { return Effort.Medium; } }

		/// <summary>
		/// Set of tags used to aid in describing the definition.  Also applied to the attribute as an interface for polymorphic routing.
		/// </summary>
		public Tag[] Tags { get { return new[]{ Tag.Principles, Tag.SOLID, Tag.DRY }; } }

		/// <summary>
		/// Identifies if an attribute of this type can only be attached one at a time to a particular context.
		/// </summary>
		public bool OnePerContext { get { return false; } }
	}

    /// <summary>
    /// Definition class for InterfaceSegregation
    /// </summary>
	public sealed class InterfaceSegregationDefinition : IDefinition, IPrinciplesGroup, IPrinciplesTag, ISOLIDTag, IISPTag, IModerateRiskTag, IMediumEffortTag
	{
		/// <summary>
		/// Name of the primary group this definition is organized into
		/// </summary>
		public string Group { get { return "Principles";} }

		/// <summary>
		/// Name of the definition
		/// </summary>
		public string Name { get { return "Interface Segregation"; } }

		/// <summary>
		/// Decription of the definition (ie the "definition" itself)
		/// </summary>
		public string Description { get { return "[The I in SOLID] Many client-specific interfaces are better than one general-purpose interface."; } }

		/// <summary>
		/// Default risk used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Risk DefaultRisk { get { return Risk.Moderate; } }

		/// <summary>
		/// Default effort used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Effort DefaultEffort { get { return Effort.Medium; } }

		/// <summary>
		/// Set of tags used to aid in describing the definition.  Also applied to the attribute as an interface for polymorphic routing.
		/// </summary>
		public Tag[] Tags { get { return new[]{ Tag.Principles, Tag.SOLID, Tag.ISP }; } }

		/// <summary>
		/// Identifies if an attribute of this type can only be attached one at a time to a particular context.
		/// </summary>
		public bool OnePerContext { get { return false; } }
	}

    /// <summary>
    /// Definition class for LeastKnowledge
    /// </summary>
	public sealed class LeastKnowledgeDefinition : IDefinition, IPrinciplesGroup, IPrinciplesTag, ILoDTag, IModerateRiskTag, IMediumEffortTag
	{
		/// <summary>
		/// Name of the primary group this definition is organized into
		/// </summary>
		public string Group { get { return "Principles";} }

		/// <summary>
		/// Name of the definition
		/// </summary>
		public string Name { get { return "Least Knowledge"; } }

		/// <summary>
		/// Decription of the definition (ie the "definition" itself)
		/// </summary>
		public string Description { get { return "[Law of Demeter] A component or object shold not know about internal details of other components or objects."; } }

		/// <summary>
		/// Default risk used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Risk DefaultRisk { get { return Risk.Moderate; } }

		/// <summary>
		/// Default effort used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Effort DefaultEffort { get { return Effort.Medium; } }

		/// <summary>
		/// Set of tags used to aid in describing the definition.  Also applied to the attribute as an interface for polymorphic routing.
		/// </summary>
		public Tag[] Tags { get { return new[]{ Tag.Principles, Tag.LoD }; } }

		/// <summary>
		/// Identifies if an attribute of this type can only be attached one at a time to a particular context.
		/// </summary>
		public bool OnePerContext { get { return false; } }
	}

    /// <summary>
    /// Definition class for LiskovSubstitution
    /// </summary>
	public sealed class LiskovSubstitutionDefinition : IDefinition, IPrinciplesGroup, IPrinciplesTag, ISOLIDTag, ILSPTag, IModerateRiskTag, IMediumEffortTag
	{
		/// <summary>
		/// Name of the primary group this definition is organized into
		/// </summary>
		public string Group { get { return "Principles";} }

		/// <summary>
		/// Name of the definition
		/// </summary>
		public string Name { get { return "Liskov Substitution"; } }

		/// <summary>
		/// Decription of the definition (ie the "definition" itself)
		/// </summary>
		public string Description { get { return "[The L in SOLID] Objects in a program should be replaceable with instances of their subtypes without altering the correctness of that program."; } }

		/// <summary>
		/// Default risk used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Risk DefaultRisk { get { return Risk.Moderate; } }

		/// <summary>
		/// Default effort used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Effort DefaultEffort { get { return Effort.Medium; } }

		/// <summary>
		/// Set of tags used to aid in describing the definition.  Also applied to the attribute as an interface for polymorphic routing.
		/// </summary>
		public Tag[] Tags { get { return new[]{ Tag.Principles, Tag.SOLID, Tag.LSP }; } }

		/// <summary>
		/// Identifies if an attribute of this type can only be attached one at a time to a particular context.
		/// </summary>
		public bool OnePerContext { get { return false; } }
	}

    /// <summary>
    /// Definition class for OccamsRazor
    /// </summary>
	public sealed class OccamsRazorDefinition : IDefinition, IPrinciplesGroup, IPrinciplesTag, IModerateRiskTag, IMediumEffortTag
	{
		/// <summary>
		/// Name of the primary group this definition is organized into
		/// </summary>
		public string Group { get { return "Principles";} }

		/// <summary>
		/// Name of the definition
		/// </summary>
		public string Name { get { return "Occams Razor"; } }

		/// <summary>
		/// Decription of the definition (ie the "definition" itself)
		/// </summary>
		public string Description { get { return "The path with the fewest assumptions should be selected even if other directions may eventually prove correct."; } }

		/// <summary>
		/// Default risk used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Risk DefaultRisk { get { return Risk.Moderate; } }

		/// <summary>
		/// Default effort used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Effort DefaultEffort { get { return Effort.Medium; } }

		/// <summary>
		/// Set of tags used to aid in describing the definition.  Also applied to the attribute as an interface for polymorphic routing.
		/// </summary>
		public Tag[] Tags { get { return new[]{ Tag.Principles }; } }

		/// <summary>
		/// Identifies if an attribute of this type can only be attached one at a time to a particular context.
		/// </summary>
		public bool OnePerContext { get { return false; } }
	}

    /// <summary>
    /// Definition class for OpenClosed
    /// </summary>
	public sealed class OpenClosedDefinition : IDefinition, IPrinciplesGroup, IPrinciplesTag, ISOLIDTag, IOCPTag, IModerateRiskTag, IMediumEffortTag
	{
		/// <summary>
		/// Name of the primary group this definition is organized into
		/// </summary>
		public string Group { get { return "Principles";} }

		/// <summary>
		/// Name of the definition
		/// </summary>
		public string Name { get { return "Open Closed"; } }

		/// <summary>
		/// Decription of the definition (ie the "definition" itself)
		/// </summary>
		public string Description { get { return "[The O in SOLID] Software entities should be open for extension, but closed for modification."; } }

		/// <summary>
		/// Default risk used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Risk DefaultRisk { get { return Risk.Moderate; } }

		/// <summary>
		/// Default effort used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Effort DefaultEffort { get { return Effort.Medium; } }

		/// <summary>
		/// Set of tags used to aid in describing the definition.  Also applied to the attribute as an interface for polymorphic routing.
		/// </summary>
		public Tag[] Tags { get { return new[]{ Tag.Principles, Tag.SOLID, Tag.OCP }; } }

		/// <summary>
		/// Identifies if an attribute of this type can only be attached one at a time to a particular context.
		/// </summary>
		public bool OnePerContext { get { return false; } }
	}

    /// <summary>
    /// Definition class for SeparationOfConcerns
    /// </summary>
	public sealed class SeparationOfConcernsDefinition : IDefinition, IPrinciplesGroup, IPrinciplesTag, ISoCTag, IModerateRiskTag, IMediumEffortTag
	{
		/// <summary>
		/// Name of the primary group this definition is organized into
		/// </summary>
		public string Group { get { return "Principles";} }

		/// <summary>
		/// Name of the definition
		/// </summary>
		public string Name { get { return "Separation Of Concerns"; } }

		/// <summary>
		/// Decription of the definition (ie the "definition" itself)
		/// </summary>
		public string Description { get { return "The design should divide areas of concern into their own distinct sections."; } }

		/// <summary>
		/// Default risk used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Risk DefaultRisk { get { return Risk.Moderate; } }

		/// <summary>
		/// Default effort used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Effort DefaultEffort { get { return Effort.Medium; } }

		/// <summary>
		/// Set of tags used to aid in describing the definition.  Also applied to the attribute as an interface for polymorphic routing.
		/// </summary>
		public Tag[] Tags { get { return new[]{ Tag.Principles, Tag.SoC }; } }

		/// <summary>
		/// Identifies if an attribute of this type can only be attached one at a time to a particular context.
		/// </summary>
		public bool OnePerContext { get { return false; } }
	}

    /// <summary>
    /// Definition class for SingleResponsibility
    /// </summary>
	public sealed class SingleResponsibilityDefinition : IDefinition, IPrinciplesGroup, IPrinciplesTag, ISOLIDTag, ISRPTag, IModerateRiskTag, IMediumEffortTag
	{
		/// <summary>
		/// Name of the primary group this definition is organized into
		/// </summary>
		public string Group { get { return "Principles";} }

		/// <summary>
		/// Name of the definition
		/// </summary>
		public string Name { get { return "Single Responsibility"; } }

		/// <summary>
		/// Decription of the definition (ie the "definition" itself)
		/// </summary>
		public string Description { get { return "[The S in SOLID] Each context of code should do one thing and thus have only one reason to change."; } }

		/// <summary>
		/// Default risk used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Risk DefaultRisk { get { return Risk.Moderate; } }

		/// <summary>
		/// Default effort used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Effort DefaultEffort { get { return Effort.Medium; } }

		/// <summary>
		/// Set of tags used to aid in describing the definition.  Also applied to the attribute as an interface for polymorphic routing.
		/// </summary>
		public Tag[] Tags { get { return new[]{ Tag.Principles, Tag.SOLID, Tag.SRP }; } }

		/// <summary>
		/// Identifies if an attribute of this type can only be attached one at a time to a particular context.
		/// </summary>
		public bool OnePerContext { get { return false; } }
	}

    /// <summary>
    /// Definition class for YouArentGonnaNeedIt
    /// </summary>
	public sealed class YouArentGonnaNeedItDefinition : IDefinition, IPrinciplesGroup, IPrinciplesTag, IYAGNITag, IModerateRiskTag, IMediumEffortTag
	{
		/// <summary>
		/// Name of the primary group this definition is organized into
		/// </summary>
		public string Group { get { return "Principles";} }

		/// <summary>
		/// Name of the definition
		/// </summary>
		public string Name { get { return "You Aren't Gonna Need It"; } }

		/// <summary>
		/// Decription of the definition (ie the "definition" itself)
		/// </summary>
		public string Description { get { return "Always implement things when you actually need them, never when you just foresee that you need them."; } }

		/// <summary>
		/// Default risk used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Risk DefaultRisk { get { return Risk.Moderate; } }

		/// <summary>
		/// Default effort used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Effort DefaultEffort { get { return Effort.Medium; } }

		/// <summary>
		/// Set of tags used to aid in describing the definition.  Also applied to the attribute as an interface for polymorphic routing.
		/// </summary>
		public Tag[] Tags { get { return new[]{ Tag.Principles, Tag.YAGNI }; } }

		/// <summary>
		/// Identifies if an attribute of this type can only be attached one at a time to a particular context.
		/// </summary>
		public bool OnePerContext { get { return false; } }
	}


}

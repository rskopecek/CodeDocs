using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs
{
    public static class Definitions
    {
        public static List<Definition> All()
        {
            return new List<Definition>
            {
                Bug, Hack, Refactor, Test, Naming, 
                Todo, Location, Purpose, Readability, ReferenceMaterial,
                Feature, MajorChange, MinorChange, MajorFix, MinorFix,
                Future
            };
        }

        public static IEnumerable<string> Tags(this IEnumerable<Definition> definitions)
        {
            return definitions.SelectMany(i => i.Tags).Distinct();
        }

        #region Details

        public static readonly Definition Bug = new Definition()
        {
            Name = "Bug",
            Description =
                "Used to acknowledge and identify code that has a live issue even though a resolution has not been identified or implemented.",
            DefaultRisk = Risk.Extreme,
            DefaultEffort = Effort.Unknown,
            Tags = new List<string> { "Degredation" }
        };

        public static readonly Definition Hack = new Definition()
        {
            Name = "Hack",
            Description = "Working feature.  Requires refactoring due to shortcuts needed to make it work.",
            DefaultRisk = Risk.Moderate,
            DefaultEffort = Effort.Unknown,
            Tags = new List<string> { "Degredation" }
        };

        public static readonly Definition Refactor = new Definition()
        {
            Name = "Refactor",
            Description = "Working feature that needs improvement.",
            DefaultRisk = Risk.Low,
            DefaultEffort = Effort.Unknown,
            Tags = new List<string> { "Degredation" }
        };

        public static readonly Definition Test = new Definition()
        {
            Name = "Test",
            Description = "Test scenario that appears to be missing.",
            DefaultRisk = Risk.Extreme,
            DefaultEffort = Effort.Small,
            Tags = new List<string> { "Degredation" }
        };

        public static readonly Definition Naming = new Definition()
        {
            Name = "Naming",
            Description =
                "Intent is clear.  However, naming could be cleaner.",
            DefaultRisk = Risk.Low,
            DefaultEffort = Effort.Small,
            Tags = new List<string> {"Meaning"}
        };

        public static readonly Definition Purpose = new Definition()
        {
            Name = "Purpose",
            Description = "Unsure of actual intent.",
            DefaultRisk = Risk.Moderate,
            DefaultEffort = Effort.Medium,
            Tags = new List<string> { "Meaning" }
        };

        public static readonly Definition Readability = new Definition()
        {
            Name = "Readability",
            Description = "Hard to read at first glance for one or more people.",
            DefaultRisk = Risk.Low,
            DefaultEffort = Effort.Small,
            Tags = new List<string> { "Meaning" }
        };

        public static readonly Definition Clarification = new Definition()
        {
            Name = "Clarification",
            Description = "Readable, but missing a 'good to know' for people trying to understand.",
            DefaultRisk = Risk.Low,
            DefaultEffort = Effort.VerySmall,
            Tags = new List<string> { "Meaning" }
        };

        public static readonly Definition Location = new Definition()
        {
            Name = "Location",
            Description = "Piece of code that appears to be in the wrong place.",
            DefaultRisk = Risk.Low,
            DefaultEffort = Effort.Unknown,
            Tags = new List<string> { "Meaning" }
        };

        public static readonly Definition ReferenceMaterial = new Definition()
        {
            Name = "ReferenceMaterial",
            Description = "Used to identify external resources (like StakeOverflow, blogs, etc) that would add value to the context this attribute is applied to.",
            DefaultRisk = Risk.None,
            DefaultEffort = Effort.None ,
            Tags = new List<string> { "Meaning" }
        };

        public static readonly Definition Todo = new Definition()
        {
            Name = "Todo",
            Description = "Uncompleted feature.",
            DefaultRisk = Risk.Extreme,
            DefaultEffort = Effort.Medium,
            Tags = new List<string> { "Work" }
        };

        public static readonly Definition Future = new Definition()
        {
            Name = "Future",
            Description = "A potential future scenario, in which this will need to be changed or these are some insights about the change.",
            DefaultRisk = Risk.Low,
            DefaultEffort = Effort.None,
            Tags = new List<string> { "Work", "Future" }
        };

        public static readonly Definition Feature = new Definition()
        {
            Name = "Feature",
            Description = "A distinctive function/attribute about what the application does",
            DefaultRisk = Risk.None,
            DefaultEffort = Effort.None,
            Tags = new List<string> { "Feature" }
        };

        public static readonly Definition MajorChange = new Definition()
        {
            Name = "MajorChange",
            Description = "Identification of a major change that is important to communicate and potentially worthy of moving the version # forward if any exist during deployment (major.minor.incr).",
            DefaultRisk = Risk.None,
            DefaultEffort = Effort.None,
            Tags = new List<string> { "Change", "Major" }
        };

        public static readonly Definition MinorChange = new Definition()
        {
            Name = "MinorChange",
            Description = "Identification of a minor change that is important to communicate and potentially worthy of moving the version # forward if any exist during deployment (major.minor.incr).",
            DefaultRisk = Risk.None,
            DefaultEffort = Effort.None,
            Tags = new List<string> { "Change", "Minor" }
        };

        public static readonly Definition MajorFix = new Definition()
        {
            Name = "MajorFix",
            Description = "Identification of a major fix that is important to communicate and potentially worthy of moving the [incr] version # forward if any exist during deployment (major.minor.incr).",
            DefaultRisk = Risk.None,
            DefaultEffort = Effort.None,
            Tags = new List<string> { "Change", "Major", "Fix" }
        };

        public static readonly Definition MinorFix = new Definition()
        {
            Name = "MinorFix",
            Description = "Identification of a minor fix that is important to communicate and potentially worthy of moving the [incr] version # forward if any exist during deployment (major.minor.incr).",
            DefaultRisk = Risk.None,
            DefaultEffort = Effort.None,
            Tags = new List<string> { "Change", "Minor", "Fix" }
        };

        #endregion

    }
}

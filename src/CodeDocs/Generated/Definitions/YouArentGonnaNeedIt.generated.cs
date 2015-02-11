// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by CodeDocs.Generator.
//     CodeDocs.Generator bases all generation on glossary.json.
//  
//     Please don't alter this file as it is only the output of a T4 template.
// </auto-generated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Definitions
{
	/// <summary>
	/// Definition class for YouArentGonnaNeedIt
	/// </summary>
	public sealed class YouArentGonnaNeedItDefinition : IDefinition, IPrinciplesTag, IYAGNITag
	{

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
		public Risk DefaultRisk { get { return Risk.Unknown; } }

		/// <summary>
		/// Default effort used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Effort DefaultEffort { get { return Effort.Unknown; } }

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
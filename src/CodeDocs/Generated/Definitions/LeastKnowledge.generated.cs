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
	/// Definition class for LeastKnowledge
	/// </summary>
	public sealed class LeastKnowledgeDefinition : IDefinition, IPrinciplesTag, ILoDTag
	{

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
		public Risk DefaultRisk { get { return Risk.Unknown; } }

		/// <summary>
		/// Default effort used when the attribute is applied and not overridden via use or IQualityEvaluator
		/// </summary>
		public Effort DefaultEffort { get { return Effort.Unknown; } }

		/// <summary>
		/// Set of tags used to aid in describing the definition.  Also applied to the attribute as an interface for polymorphic routing.
		/// </summary>
		public Tag[] Tags { get { return new[]{ Tag.Principles, Tag.LoD }; } }

		/// <summary>
		/// Identifies if an attribute of this type can only be attached one at a time to a particular context.
		/// </summary>
		public bool OnePerContext { get { return false; } }
	}
}
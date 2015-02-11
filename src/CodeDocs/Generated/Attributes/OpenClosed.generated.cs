// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by CodeDocs.Generator.
//     CodeDocs.Generator bases all generation on glossary.json.
//  
//     Please don't alter this file as it is only the output of a T4 template.
// </auto-generated>
// ------------------------------------------------------------------------------
using System;

namespace CodeDocs
{

    /// <summary>
    /// [The O in SOLID] Software entities should be open for extension, but closed for modification. 
    /// </summary>
	[AttributeUsage(Constants.Scope, AllowMultiple = true, Inherited = false)]
    public sealed class OpenClosedAttribute : CodeDocsAttribute, IPrinciplesTag, ISOLIDTag, IOCPTag
    {

		/// <summary>
		/// Access to the definition used to generate this attribute (provided by the CodeDocs.Glossary static object)
		/// </summary>
		public override IDefinition Definition { get { return Glossary.OpenClosed; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public OpenClosedAttribute(string details, params string[] tagsAndReferences) : base(details, null, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public OpenClosedAttribute(string details, Risk risk, params string[] tagsAndReferences) : base(details, risk, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public OpenClosedAttribute(string details, Effort effort, params string[] tagsAndReferences) : base(details, null, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public OpenClosedAttribute(string details, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public OpenClosedAttribute(string details, Risk risk, Effort effort, params string[] tagsAndReferences) : base(details, risk, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public OpenClosedAttribute(string details, Risk risk, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public OpenClosedAttribute(string details, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, effort, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public OpenClosedAttribute(string details, Risk risk, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, effort, yyyymmdd, tagsAndReferences){}

	}

}
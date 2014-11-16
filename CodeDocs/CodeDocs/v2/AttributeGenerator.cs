/*
 *
 *	System Generated via T4
 *
*/
using System;
using CodeDocs.Definitions.v2;

namespace CodeDocs.v2
{

    /// <summary>
    /// Used to acknowledge and identify code that has a live issue even though a resolution has not been identified or implemented. (Default risk = Extreme, Default effort = Unknown)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class BugAttribute : CodeDocsAttribute, IDegredation
    {

		public override Definition Definition { get { return Glossary.Bug; }}

		// Just Details

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
		public BugAttribute(string details) : base(details, null, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public BugAttribute(string details, int yyyymmdd) : base(details, null, null, "", null, yyyymmdd){}

		// Focus on risk

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
		public BugAttribute(string details, Risk risk) : base(details, risk, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public BugAttribute(string details, Risk risk, Effort effort) : base(details, risk, effort, "", null, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public BugAttribute(string details, Risk risk, int yyyymmdd) : base(details, risk, null, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public BugAttribute(string details, Risk risk, Effort effort, int yyyymmdd) : base(details, risk, effort, "", null, yyyymmdd){}

		// Focus on tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public BugAttribute(string details, string tags) : base(details, null, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public BugAttribute(string details, Risk risk, string tags) : base(details, risk, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public BugAttribute(string details, Risk risk, Effort effort, string tags) : base(details, risk, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public BugAttribute(string details, string tags, string[] urls) : base(details, null, null, tags, urls, null){}

		// Add in date for tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public BugAttribute(string details, string tags, int yyyymmdd) : base(details, null, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public BugAttribute(string details, Risk risk, string tags, int yyyymmdd) : base(details, risk, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public BugAttribute(string details, Risk risk, Effort effort, string tags, int yyyymmdd) : base(details, risk, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public BugAttribute(string details, string tags, string[] urls, int yyyymmdd) : base(details, null, null, tags, urls, yyyymmdd){}

		// Add in urls

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public BugAttribute(string details, string[] urls) : base(details, null, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public BugAttribute(string details, Risk risk, string[] urls) : base(details, risk, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public BugAttribute(string details, Risk risk, Effort effort, string[] urls) : base(details, risk, effort, "", urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public BugAttribute(string details, string[] urls, int yyyymmdd) : base(details, null, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public BugAttribute(string details, Risk risk, string[] urls, int yyyymmdd) : base(details, risk, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public BugAttribute(string details, Risk risk, Effort effort, string[] urls, int yyyymmdd) : base(details, risk, effort, "", urls, yyyymmdd){}

		// Focus on effort

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public BugAttribute(string details, Effort effort) : base(details, null, effort, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public BugAttribute(string details, Effort effort, string tags) : base(details, null, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public BugAttribute(string details, Effort effort, string[] urls) : base(details, null, effort, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public BugAttribute(string details, Effort effort, string tags, string[] urls) : base(details, null, effort, tags, urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public BugAttribute(string details, Effort effort, int yyyymmdd) : base(details, null, effort, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public BugAttribute(string details, Effort effort, string tags, int yyyymmdd) : base(details, null, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public BugAttribute(string details, Effort effort, string[] urls, int yyyymmdd) : base(details, null, effort, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public BugAttribute(string details, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, null, effort, tags, urls, yyyymmdd){}

		// Full tilt

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public BugAttribute(string details, Risk risk, Effort effort, string tags, string[] urls) : base(details, risk, effort, tags, urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public BugAttribute(string details, Risk risk, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, risk, effort, tags, urls, yyyymmdd){}

	}

    /// <summary>
    /// Identification of a major fix that is important to communicate and potentially worthy of moving the [incr] version # forward if any exist during deployment (major.minor.incr). (Default risk = None, Default effort = None)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class MajorFixAttribute : CodeDocsAttribute, IChange, IMajor, IFix
    {

		public override Definition Definition { get { return Glossary.MajorFix; }}

		// Just Details

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
		public MajorFixAttribute(string details) : base(details, null, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MajorFixAttribute(string details, int yyyymmdd) : base(details, null, null, "", null, yyyymmdd){}

		// Focus on risk

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
		public MajorFixAttribute(string details, Risk risk) : base(details, risk, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public MajorFixAttribute(string details, Risk risk, Effort effort) : base(details, risk, effort, "", null, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MajorFixAttribute(string details, Risk risk, int yyyymmdd) : base(details, risk, null, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MajorFixAttribute(string details, Risk risk, Effort effort, int yyyymmdd) : base(details, risk, effort, "", null, yyyymmdd){}

		// Focus on tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public MajorFixAttribute(string details, string tags) : base(details, null, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public MajorFixAttribute(string details, Risk risk, string tags) : base(details, risk, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public MajorFixAttribute(string details, Risk risk, Effort effort, string tags) : base(details, risk, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MajorFixAttribute(string details, string tags, string[] urls) : base(details, null, null, tags, urls, null){}

		// Add in date for tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MajorFixAttribute(string details, string tags, int yyyymmdd) : base(details, null, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MajorFixAttribute(string details, Risk risk, string tags, int yyyymmdd) : base(details, risk, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MajorFixAttribute(string details, Risk risk, Effort effort, string tags, int yyyymmdd) : base(details, risk, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MajorFixAttribute(string details, string tags, string[] urls, int yyyymmdd) : base(details, null, null, tags, urls, yyyymmdd){}

		// Add in urls

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MajorFixAttribute(string details, string[] urls) : base(details, null, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MajorFixAttribute(string details, Risk risk, string[] urls) : base(details, risk, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MajorFixAttribute(string details, Risk risk, Effort effort, string[] urls) : base(details, risk, effort, "", urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MajorFixAttribute(string details, string[] urls, int yyyymmdd) : base(details, null, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MajorFixAttribute(string details, Risk risk, string[] urls, int yyyymmdd) : base(details, risk, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MajorFixAttribute(string details, Risk risk, Effort effort, string[] urls, int yyyymmdd) : base(details, risk, effort, "", urls, yyyymmdd){}

		// Focus on effort

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public MajorFixAttribute(string details, Effort effort) : base(details, null, effort, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public MajorFixAttribute(string details, Effort effort, string tags) : base(details, null, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MajorFixAttribute(string details, Effort effort, string[] urls) : base(details, null, effort, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MajorFixAttribute(string details, Effort effort, string tags, string[] urls) : base(details, null, effort, tags, urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MajorFixAttribute(string details, Effort effort, int yyyymmdd) : base(details, null, effort, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MajorFixAttribute(string details, Effort effort, string tags, int yyyymmdd) : base(details, null, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MajorFixAttribute(string details, Effort effort, string[] urls, int yyyymmdd) : base(details, null, effort, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MajorFixAttribute(string details, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, null, effort, tags, urls, yyyymmdd){}

		// Full tilt

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MajorFixAttribute(string details, Risk risk, Effort effort, string tags, string[] urls) : base(details, risk, effort, tags, urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MajorFixAttribute(string details, Risk risk, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, risk, effort, tags, urls, yyyymmdd){}

	}

    /// <summary>
    /// Identification of a minor fix that is important to communicate and potentially worthy of moving the [incr] version # forward if any exist during deployment (major.minor.incr). (Default risk = None, Default effort = None)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class MinorFixAttribute : CodeDocsAttribute, IChange, IMinor, IFix
    {

		public override Definition Definition { get { return Glossary.MinorFix; }}

		// Just Details

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
		public MinorFixAttribute(string details) : base(details, null, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MinorFixAttribute(string details, int yyyymmdd) : base(details, null, null, "", null, yyyymmdd){}

		// Focus on risk

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
		public MinorFixAttribute(string details, Risk risk) : base(details, risk, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public MinorFixAttribute(string details, Risk risk, Effort effort) : base(details, risk, effort, "", null, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MinorFixAttribute(string details, Risk risk, int yyyymmdd) : base(details, risk, null, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MinorFixAttribute(string details, Risk risk, Effort effort, int yyyymmdd) : base(details, risk, effort, "", null, yyyymmdd){}

		// Focus on tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public MinorFixAttribute(string details, string tags) : base(details, null, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public MinorFixAttribute(string details, Risk risk, string tags) : base(details, risk, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public MinorFixAttribute(string details, Risk risk, Effort effort, string tags) : base(details, risk, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MinorFixAttribute(string details, string tags, string[] urls) : base(details, null, null, tags, urls, null){}

		// Add in date for tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MinorFixAttribute(string details, string tags, int yyyymmdd) : base(details, null, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MinorFixAttribute(string details, Risk risk, string tags, int yyyymmdd) : base(details, risk, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MinorFixAttribute(string details, Risk risk, Effort effort, string tags, int yyyymmdd) : base(details, risk, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MinorFixAttribute(string details, string tags, string[] urls, int yyyymmdd) : base(details, null, null, tags, urls, yyyymmdd){}

		// Add in urls

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MinorFixAttribute(string details, string[] urls) : base(details, null, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MinorFixAttribute(string details, Risk risk, string[] urls) : base(details, risk, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MinorFixAttribute(string details, Risk risk, Effort effort, string[] urls) : base(details, risk, effort, "", urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MinorFixAttribute(string details, string[] urls, int yyyymmdd) : base(details, null, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MinorFixAttribute(string details, Risk risk, string[] urls, int yyyymmdd) : base(details, risk, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MinorFixAttribute(string details, Risk risk, Effort effort, string[] urls, int yyyymmdd) : base(details, risk, effort, "", urls, yyyymmdd){}

		// Focus on effort

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public MinorFixAttribute(string details, Effort effort) : base(details, null, effort, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public MinorFixAttribute(string details, Effort effort, string tags) : base(details, null, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MinorFixAttribute(string details, Effort effort, string[] urls) : base(details, null, effort, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MinorFixAttribute(string details, Effort effort, string tags, string[] urls) : base(details, null, effort, tags, urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MinorFixAttribute(string details, Effort effort, int yyyymmdd) : base(details, null, effort, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MinorFixAttribute(string details, Effort effort, string tags, int yyyymmdd) : base(details, null, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MinorFixAttribute(string details, Effort effort, string[] urls, int yyyymmdd) : base(details, null, effort, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MinorFixAttribute(string details, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, null, effort, tags, urls, yyyymmdd){}

		// Full tilt

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MinorFixAttribute(string details, Risk risk, Effort effort, string tags, string[] urls) : base(details, risk, effort, tags, urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MinorFixAttribute(string details, Risk risk, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, risk, effort, tags, urls, yyyymmdd){}

	}

    /// <summary>
    /// A piece of code that is slower than desired and need refactored. (Default risk = Moderate, Default effort = Medium)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class SlowAttribute : CodeDocsAttribute, IPerformance, IDegredation
    {

		public override Definition Definition { get { return Glossary.Slow; }}

		// Just Details

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
		public SlowAttribute(string details) : base(details, null, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SlowAttribute(string details, int yyyymmdd) : base(details, null, null, "", null, yyyymmdd){}

		// Focus on risk

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
		public SlowAttribute(string details, Risk risk) : base(details, risk, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public SlowAttribute(string details, Risk risk, Effort effort) : base(details, risk, effort, "", null, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SlowAttribute(string details, Risk risk, int yyyymmdd) : base(details, risk, null, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SlowAttribute(string details, Risk risk, Effort effort, int yyyymmdd) : base(details, risk, effort, "", null, yyyymmdd){}

		// Focus on tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public SlowAttribute(string details, string tags) : base(details, null, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public SlowAttribute(string details, Risk risk, string tags) : base(details, risk, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public SlowAttribute(string details, Risk risk, Effort effort, string tags) : base(details, risk, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public SlowAttribute(string details, string tags, string[] urls) : base(details, null, null, tags, urls, null){}

		// Add in date for tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SlowAttribute(string details, string tags, int yyyymmdd) : base(details, null, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SlowAttribute(string details, Risk risk, string tags, int yyyymmdd) : base(details, risk, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SlowAttribute(string details, Risk risk, Effort effort, string tags, int yyyymmdd) : base(details, risk, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SlowAttribute(string details, string tags, string[] urls, int yyyymmdd) : base(details, null, null, tags, urls, yyyymmdd){}

		// Add in urls

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public SlowAttribute(string details, string[] urls) : base(details, null, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public SlowAttribute(string details, Risk risk, string[] urls) : base(details, risk, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public SlowAttribute(string details, Risk risk, Effort effort, string[] urls) : base(details, risk, effort, "", urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SlowAttribute(string details, string[] urls, int yyyymmdd) : base(details, null, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SlowAttribute(string details, Risk risk, string[] urls, int yyyymmdd) : base(details, risk, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SlowAttribute(string details, Risk risk, Effort effort, string[] urls, int yyyymmdd) : base(details, risk, effort, "", urls, yyyymmdd){}

		// Focus on effort

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public SlowAttribute(string details, Effort effort) : base(details, null, effort, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public SlowAttribute(string details, Effort effort, string tags) : base(details, null, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public SlowAttribute(string details, Effort effort, string[] urls) : base(details, null, effort, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public SlowAttribute(string details, Effort effort, string tags, string[] urls) : base(details, null, effort, tags, urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SlowAttribute(string details, Effort effort, int yyyymmdd) : base(details, null, effort, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SlowAttribute(string details, Effort effort, string tags, int yyyymmdd) : base(details, null, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SlowAttribute(string details, Effort effort, string[] urls, int yyyymmdd) : base(details, null, effort, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SlowAttribute(string details, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, null, effort, tags, urls, yyyymmdd){}

		// Full tilt

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public SlowAttribute(string details, Risk risk, Effort effort, string tags, string[] urls) : base(details, risk, effort, tags, urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SlowAttribute(string details, Risk risk, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, risk, effort, tags, urls, yyyymmdd){}

	}

    /// <summary>
    /// Uncompleted feature. (Default risk = Extreme, Default effort = Medium)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class TodoAttribute : CodeDocsAttribute, IWork
    {

		public override Definition Definition { get { return Glossary.Todo; }}

		// Just Details

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
		public TodoAttribute(string details) : base(details, null, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public TodoAttribute(string details, int yyyymmdd) : base(details, null, null, "", null, yyyymmdd){}

		// Focus on risk

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
		public TodoAttribute(string details, Risk risk) : base(details, risk, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public TodoAttribute(string details, Risk risk, Effort effort) : base(details, risk, effort, "", null, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public TodoAttribute(string details, Risk risk, int yyyymmdd) : base(details, risk, null, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public TodoAttribute(string details, Risk risk, Effort effort, int yyyymmdd) : base(details, risk, effort, "", null, yyyymmdd){}

		// Focus on tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public TodoAttribute(string details, string tags) : base(details, null, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public TodoAttribute(string details, Risk risk, string tags) : base(details, risk, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public TodoAttribute(string details, Risk risk, Effort effort, string tags) : base(details, risk, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public TodoAttribute(string details, string tags, string[] urls) : base(details, null, null, tags, urls, null){}

		// Add in date for tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public TodoAttribute(string details, string tags, int yyyymmdd) : base(details, null, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public TodoAttribute(string details, Risk risk, string tags, int yyyymmdd) : base(details, risk, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public TodoAttribute(string details, Risk risk, Effort effort, string tags, int yyyymmdd) : base(details, risk, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public TodoAttribute(string details, string tags, string[] urls, int yyyymmdd) : base(details, null, null, tags, urls, yyyymmdd){}

		// Add in urls

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public TodoAttribute(string details, string[] urls) : base(details, null, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public TodoAttribute(string details, Risk risk, string[] urls) : base(details, risk, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public TodoAttribute(string details, Risk risk, Effort effort, string[] urls) : base(details, risk, effort, "", urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public TodoAttribute(string details, string[] urls, int yyyymmdd) : base(details, null, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public TodoAttribute(string details, Risk risk, string[] urls, int yyyymmdd) : base(details, risk, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public TodoAttribute(string details, Risk risk, Effort effort, string[] urls, int yyyymmdd) : base(details, risk, effort, "", urls, yyyymmdd){}

		// Focus on effort

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public TodoAttribute(string details, Effort effort) : base(details, null, effort, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public TodoAttribute(string details, Effort effort, string tags) : base(details, null, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public TodoAttribute(string details, Effort effort, string[] urls) : base(details, null, effort, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public TodoAttribute(string details, Effort effort, string tags, string[] urls) : base(details, null, effort, tags, urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public TodoAttribute(string details, Effort effort, int yyyymmdd) : base(details, null, effort, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public TodoAttribute(string details, Effort effort, string tags, int yyyymmdd) : base(details, null, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public TodoAttribute(string details, Effort effort, string[] urls, int yyyymmdd) : base(details, null, effort, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public TodoAttribute(string details, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, null, effort, tags, urls, yyyymmdd){}

		// Full tilt

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public TodoAttribute(string details, Risk risk, Effort effort, string tags, string[] urls) : base(details, risk, effort, tags, urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public TodoAttribute(string details, Risk risk, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, risk, effort, tags, urls, yyyymmdd){}

	}

    /// <summary>
    /// A note about security in relation to the context, not necessarily a risk. (Default risk = None, Default effort = None)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class SecurityAttribute : CodeDocsAttribute, ISecurity
    {

		public override Definition Definition { get { return Glossary.Security; }}

		// Just Details

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
		public SecurityAttribute(string details) : base(details, null, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SecurityAttribute(string details, int yyyymmdd) : base(details, null, null, "", null, yyyymmdd){}

		// Focus on risk

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
		public SecurityAttribute(string details, Risk risk) : base(details, risk, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public SecurityAttribute(string details, Risk risk, Effort effort) : base(details, risk, effort, "", null, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SecurityAttribute(string details, Risk risk, int yyyymmdd) : base(details, risk, null, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SecurityAttribute(string details, Risk risk, Effort effort, int yyyymmdd) : base(details, risk, effort, "", null, yyyymmdd){}

		// Focus on tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public SecurityAttribute(string details, string tags) : base(details, null, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public SecurityAttribute(string details, Risk risk, string tags) : base(details, risk, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public SecurityAttribute(string details, Risk risk, Effort effort, string tags) : base(details, risk, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public SecurityAttribute(string details, string tags, string[] urls) : base(details, null, null, tags, urls, null){}

		// Add in date for tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SecurityAttribute(string details, string tags, int yyyymmdd) : base(details, null, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SecurityAttribute(string details, Risk risk, string tags, int yyyymmdd) : base(details, risk, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SecurityAttribute(string details, Risk risk, Effort effort, string tags, int yyyymmdd) : base(details, risk, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SecurityAttribute(string details, string tags, string[] urls, int yyyymmdd) : base(details, null, null, tags, urls, yyyymmdd){}

		// Add in urls

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public SecurityAttribute(string details, string[] urls) : base(details, null, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public SecurityAttribute(string details, Risk risk, string[] urls) : base(details, risk, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public SecurityAttribute(string details, Risk risk, Effort effort, string[] urls) : base(details, risk, effort, "", urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SecurityAttribute(string details, string[] urls, int yyyymmdd) : base(details, null, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SecurityAttribute(string details, Risk risk, string[] urls, int yyyymmdd) : base(details, risk, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SecurityAttribute(string details, Risk risk, Effort effort, string[] urls, int yyyymmdd) : base(details, risk, effort, "", urls, yyyymmdd){}

		// Focus on effort

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public SecurityAttribute(string details, Effort effort) : base(details, null, effort, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public SecurityAttribute(string details, Effort effort, string tags) : base(details, null, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public SecurityAttribute(string details, Effort effort, string[] urls) : base(details, null, effort, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public SecurityAttribute(string details, Effort effort, string tags, string[] urls) : base(details, null, effort, tags, urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SecurityAttribute(string details, Effort effort, int yyyymmdd) : base(details, null, effort, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SecurityAttribute(string details, Effort effort, string tags, int yyyymmdd) : base(details, null, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SecurityAttribute(string details, Effort effort, string[] urls, int yyyymmdd) : base(details, null, effort, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SecurityAttribute(string details, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, null, effort, tags, urls, yyyymmdd){}

		// Full tilt

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public SecurityAttribute(string details, Risk risk, Effort effort, string tags, string[] urls) : base(details, risk, effort, tags, urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SecurityAttribute(string details, Risk risk, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, risk, effort, tags, urls, yyyymmdd){}

	}

    /// <summary>
    /// An identified security issue. (Default risk = Extreme, Default effort = Unknown)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class InSecureAttribute : CodeDocsAttribute, ISecurity, IInSecure, IDegredation
    {

		public override Definition Definition { get { return Glossary.InSecure; }}

		// Just Details

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
		public InSecureAttribute(string details) : base(details, null, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public InSecureAttribute(string details, int yyyymmdd) : base(details, null, null, "", null, yyyymmdd){}

		// Focus on risk

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
		public InSecureAttribute(string details, Risk risk) : base(details, risk, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public InSecureAttribute(string details, Risk risk, Effort effort) : base(details, risk, effort, "", null, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public InSecureAttribute(string details, Risk risk, int yyyymmdd) : base(details, risk, null, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public InSecureAttribute(string details, Risk risk, Effort effort, int yyyymmdd) : base(details, risk, effort, "", null, yyyymmdd){}

		// Focus on tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public InSecureAttribute(string details, string tags) : base(details, null, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public InSecureAttribute(string details, Risk risk, string tags) : base(details, risk, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public InSecureAttribute(string details, Risk risk, Effort effort, string tags) : base(details, risk, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public InSecureAttribute(string details, string tags, string[] urls) : base(details, null, null, tags, urls, null){}

		// Add in date for tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public InSecureAttribute(string details, string tags, int yyyymmdd) : base(details, null, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public InSecureAttribute(string details, Risk risk, string tags, int yyyymmdd) : base(details, risk, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public InSecureAttribute(string details, Risk risk, Effort effort, string tags, int yyyymmdd) : base(details, risk, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public InSecureAttribute(string details, string tags, string[] urls, int yyyymmdd) : base(details, null, null, tags, urls, yyyymmdd){}

		// Add in urls

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public InSecureAttribute(string details, string[] urls) : base(details, null, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public InSecureAttribute(string details, Risk risk, string[] urls) : base(details, risk, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public InSecureAttribute(string details, Risk risk, Effort effort, string[] urls) : base(details, risk, effort, "", urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public InSecureAttribute(string details, string[] urls, int yyyymmdd) : base(details, null, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public InSecureAttribute(string details, Risk risk, string[] urls, int yyyymmdd) : base(details, risk, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public InSecureAttribute(string details, Risk risk, Effort effort, string[] urls, int yyyymmdd) : base(details, risk, effort, "", urls, yyyymmdd){}

		// Focus on effort

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public InSecureAttribute(string details, Effort effort) : base(details, null, effort, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public InSecureAttribute(string details, Effort effort, string tags) : base(details, null, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public InSecureAttribute(string details, Effort effort, string[] urls) : base(details, null, effort, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public InSecureAttribute(string details, Effort effort, string tags, string[] urls) : base(details, null, effort, tags, urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public InSecureAttribute(string details, Effort effort, int yyyymmdd) : base(details, null, effort, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public InSecureAttribute(string details, Effort effort, string tags, int yyyymmdd) : base(details, null, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public InSecureAttribute(string details, Effort effort, string[] urls, int yyyymmdd) : base(details, null, effort, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public InSecureAttribute(string details, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, null, effort, tags, urls, yyyymmdd){}

		// Full tilt

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public InSecureAttribute(string details, Risk risk, Effort effort, string tags, string[] urls) : base(details, risk, effort, tags, urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public InSecureAttribute(string details, Risk risk, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, risk, effort, tags, urls, yyyymmdd){}

	}

    /// <summary>
    /// A piece of code that is extremely tempermental, developers should be cautioned, and refactoring is required. (Default risk = Extreme, Default effort = Unknown)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class ToxicAttribute : CodeDocsAttribute, IToxic, IDegredation
    {

		public override Definition Definition { get { return Glossary.Toxic; }}

		// Just Details

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
		public ToxicAttribute(string details) : base(details, null, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ToxicAttribute(string details, int yyyymmdd) : base(details, null, null, "", null, yyyymmdd){}

		// Focus on risk

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
		public ToxicAttribute(string details, Risk risk) : base(details, risk, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public ToxicAttribute(string details, Risk risk, Effort effort) : base(details, risk, effort, "", null, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ToxicAttribute(string details, Risk risk, int yyyymmdd) : base(details, risk, null, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ToxicAttribute(string details, Risk risk, Effort effort, int yyyymmdd) : base(details, risk, effort, "", null, yyyymmdd){}

		// Focus on tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public ToxicAttribute(string details, string tags) : base(details, null, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public ToxicAttribute(string details, Risk risk, string tags) : base(details, risk, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public ToxicAttribute(string details, Risk risk, Effort effort, string tags) : base(details, risk, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ToxicAttribute(string details, string tags, string[] urls) : base(details, null, null, tags, urls, null){}

		// Add in date for tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ToxicAttribute(string details, string tags, int yyyymmdd) : base(details, null, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ToxicAttribute(string details, Risk risk, string tags, int yyyymmdd) : base(details, risk, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ToxicAttribute(string details, Risk risk, Effort effort, string tags, int yyyymmdd) : base(details, risk, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ToxicAttribute(string details, string tags, string[] urls, int yyyymmdd) : base(details, null, null, tags, urls, yyyymmdd){}

		// Add in urls

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ToxicAttribute(string details, string[] urls) : base(details, null, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ToxicAttribute(string details, Risk risk, string[] urls) : base(details, risk, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ToxicAttribute(string details, Risk risk, Effort effort, string[] urls) : base(details, risk, effort, "", urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ToxicAttribute(string details, string[] urls, int yyyymmdd) : base(details, null, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ToxicAttribute(string details, Risk risk, string[] urls, int yyyymmdd) : base(details, risk, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ToxicAttribute(string details, Risk risk, Effort effort, string[] urls, int yyyymmdd) : base(details, risk, effort, "", urls, yyyymmdd){}

		// Focus on effort

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public ToxicAttribute(string details, Effort effort) : base(details, null, effort, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public ToxicAttribute(string details, Effort effort, string tags) : base(details, null, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ToxicAttribute(string details, Effort effort, string[] urls) : base(details, null, effort, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ToxicAttribute(string details, Effort effort, string tags, string[] urls) : base(details, null, effort, tags, urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ToxicAttribute(string details, Effort effort, int yyyymmdd) : base(details, null, effort, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ToxicAttribute(string details, Effort effort, string tags, int yyyymmdd) : base(details, null, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ToxicAttribute(string details, Effort effort, string[] urls, int yyyymmdd) : base(details, null, effort, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ToxicAttribute(string details, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, null, effort, tags, urls, yyyymmdd){}

		// Full tilt

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ToxicAttribute(string details, Risk risk, Effort effort, string tags, string[] urls) : base(details, risk, effort, tags, urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ToxicAttribute(string details, Risk risk, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, risk, effort, tags, urls, yyyymmdd){}

	}

    /// <summary>
    /// A side-effect that may occur either by the behavior of the code or if a change is made to the code. (Default risk = Moderate, Default effort = Unknown)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class ConsequenceAttribute : CodeDocsAttribute, IConsequence
    {

		public override Definition Definition { get { return Glossary.Consequence; }}

		// Just Details

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
		public ConsequenceAttribute(string details) : base(details, null, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ConsequenceAttribute(string details, int yyyymmdd) : base(details, null, null, "", null, yyyymmdd){}

		// Focus on risk

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
		public ConsequenceAttribute(string details, Risk risk) : base(details, risk, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public ConsequenceAttribute(string details, Risk risk, Effort effort) : base(details, risk, effort, "", null, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ConsequenceAttribute(string details, Risk risk, int yyyymmdd) : base(details, risk, null, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ConsequenceAttribute(string details, Risk risk, Effort effort, int yyyymmdd) : base(details, risk, effort, "", null, yyyymmdd){}

		// Focus on tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public ConsequenceAttribute(string details, string tags) : base(details, null, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public ConsequenceAttribute(string details, Risk risk, string tags) : base(details, risk, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public ConsequenceAttribute(string details, Risk risk, Effort effort, string tags) : base(details, risk, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ConsequenceAttribute(string details, string tags, string[] urls) : base(details, null, null, tags, urls, null){}

		// Add in date for tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ConsequenceAttribute(string details, string tags, int yyyymmdd) : base(details, null, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ConsequenceAttribute(string details, Risk risk, string tags, int yyyymmdd) : base(details, risk, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ConsequenceAttribute(string details, Risk risk, Effort effort, string tags, int yyyymmdd) : base(details, risk, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ConsequenceAttribute(string details, string tags, string[] urls, int yyyymmdd) : base(details, null, null, tags, urls, yyyymmdd){}

		// Add in urls

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ConsequenceAttribute(string details, string[] urls) : base(details, null, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ConsequenceAttribute(string details, Risk risk, string[] urls) : base(details, risk, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ConsequenceAttribute(string details, Risk risk, Effort effort, string[] urls) : base(details, risk, effort, "", urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ConsequenceAttribute(string details, string[] urls, int yyyymmdd) : base(details, null, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ConsequenceAttribute(string details, Risk risk, string[] urls, int yyyymmdd) : base(details, risk, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ConsequenceAttribute(string details, Risk risk, Effort effort, string[] urls, int yyyymmdd) : base(details, risk, effort, "", urls, yyyymmdd){}

		// Focus on effort

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public ConsequenceAttribute(string details, Effort effort) : base(details, null, effort, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public ConsequenceAttribute(string details, Effort effort, string tags) : base(details, null, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ConsequenceAttribute(string details, Effort effort, string[] urls) : base(details, null, effort, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ConsequenceAttribute(string details, Effort effort, string tags, string[] urls) : base(details, null, effort, tags, urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ConsequenceAttribute(string details, Effort effort, int yyyymmdd) : base(details, null, effort, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ConsequenceAttribute(string details, Effort effort, string tags, int yyyymmdd) : base(details, null, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ConsequenceAttribute(string details, Effort effort, string[] urls, int yyyymmdd) : base(details, null, effort, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ConsequenceAttribute(string details, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, null, effort, tags, urls, yyyymmdd){}

		// Full tilt

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ConsequenceAttribute(string details, Risk risk, Effort effort, string tags, string[] urls) : base(details, risk, effort, tags, urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ConsequenceAttribute(string details, Risk risk, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, risk, effort, tags, urls, yyyymmdd){}

	}

    /// <summary>
    /// Typically code that is commented out or code that exists but is never used. (Default risk = Low, Default effort = VerySmall)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class DeadCodeAttribute : CodeDocsAttribute, IDeadCode
    {

		public override Definition Definition { get { return Glossary.DeadCode; }}

		// Just Details

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
		public DeadCodeAttribute(string details) : base(details, null, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DeadCodeAttribute(string details, int yyyymmdd) : base(details, null, null, "", null, yyyymmdd){}

		// Focus on risk

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
		public DeadCodeAttribute(string details, Risk risk) : base(details, risk, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public DeadCodeAttribute(string details, Risk risk, Effort effort) : base(details, risk, effort, "", null, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DeadCodeAttribute(string details, Risk risk, int yyyymmdd) : base(details, risk, null, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DeadCodeAttribute(string details, Risk risk, Effort effort, int yyyymmdd) : base(details, risk, effort, "", null, yyyymmdd){}

		// Focus on tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public DeadCodeAttribute(string details, string tags) : base(details, null, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public DeadCodeAttribute(string details, Risk risk, string tags) : base(details, risk, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public DeadCodeAttribute(string details, Risk risk, Effort effort, string tags) : base(details, risk, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public DeadCodeAttribute(string details, string tags, string[] urls) : base(details, null, null, tags, urls, null){}

		// Add in date for tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DeadCodeAttribute(string details, string tags, int yyyymmdd) : base(details, null, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DeadCodeAttribute(string details, Risk risk, string tags, int yyyymmdd) : base(details, risk, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DeadCodeAttribute(string details, Risk risk, Effort effort, string tags, int yyyymmdd) : base(details, risk, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DeadCodeAttribute(string details, string tags, string[] urls, int yyyymmdd) : base(details, null, null, tags, urls, yyyymmdd){}

		// Add in urls

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public DeadCodeAttribute(string details, string[] urls) : base(details, null, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public DeadCodeAttribute(string details, Risk risk, string[] urls) : base(details, risk, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public DeadCodeAttribute(string details, Risk risk, Effort effort, string[] urls) : base(details, risk, effort, "", urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DeadCodeAttribute(string details, string[] urls, int yyyymmdd) : base(details, null, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DeadCodeAttribute(string details, Risk risk, string[] urls, int yyyymmdd) : base(details, risk, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DeadCodeAttribute(string details, Risk risk, Effort effort, string[] urls, int yyyymmdd) : base(details, risk, effort, "", urls, yyyymmdd){}

		// Focus on effort

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public DeadCodeAttribute(string details, Effort effort) : base(details, null, effort, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public DeadCodeAttribute(string details, Effort effort, string tags) : base(details, null, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public DeadCodeAttribute(string details, Effort effort, string[] urls) : base(details, null, effort, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public DeadCodeAttribute(string details, Effort effort, string tags, string[] urls) : base(details, null, effort, tags, urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DeadCodeAttribute(string details, Effort effort, int yyyymmdd) : base(details, null, effort, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DeadCodeAttribute(string details, Effort effort, string tags, int yyyymmdd) : base(details, null, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DeadCodeAttribute(string details, Effort effort, string[] urls, int yyyymmdd) : base(details, null, effort, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DeadCodeAttribute(string details, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, null, effort, tags, urls, yyyymmdd){}

		// Full tilt

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public DeadCodeAttribute(string details, Risk risk, Effort effort, string tags, string[] urls) : base(details, risk, effort, tags, urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DeadCodeAttribute(string details, Risk risk, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, risk, effort, tags, urls, yyyymmdd){}

	}

    /// <summary>
    /// Test scenario that appears to be missing. (Default risk = Extreme, Default effort = Small)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class TestAttribute : CodeDocsAttribute, IDegredation
    {

		public override Definition Definition { get { return Glossary.Test; }}

		// Just Details

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
		public TestAttribute(string details) : base(details, null, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public TestAttribute(string details, int yyyymmdd) : base(details, null, null, "", null, yyyymmdd){}

		// Focus on risk

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
		public TestAttribute(string details, Risk risk) : base(details, risk, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public TestAttribute(string details, Risk risk, Effort effort) : base(details, risk, effort, "", null, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public TestAttribute(string details, Risk risk, int yyyymmdd) : base(details, risk, null, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public TestAttribute(string details, Risk risk, Effort effort, int yyyymmdd) : base(details, risk, effort, "", null, yyyymmdd){}

		// Focus on tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public TestAttribute(string details, string tags) : base(details, null, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public TestAttribute(string details, Risk risk, string tags) : base(details, risk, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public TestAttribute(string details, Risk risk, Effort effort, string tags) : base(details, risk, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public TestAttribute(string details, string tags, string[] urls) : base(details, null, null, tags, urls, null){}

		// Add in date for tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public TestAttribute(string details, string tags, int yyyymmdd) : base(details, null, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public TestAttribute(string details, Risk risk, string tags, int yyyymmdd) : base(details, risk, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public TestAttribute(string details, Risk risk, Effort effort, string tags, int yyyymmdd) : base(details, risk, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public TestAttribute(string details, string tags, string[] urls, int yyyymmdd) : base(details, null, null, tags, urls, yyyymmdd){}

		// Add in urls

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public TestAttribute(string details, string[] urls) : base(details, null, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public TestAttribute(string details, Risk risk, string[] urls) : base(details, risk, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public TestAttribute(string details, Risk risk, Effort effort, string[] urls) : base(details, risk, effort, "", urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public TestAttribute(string details, string[] urls, int yyyymmdd) : base(details, null, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public TestAttribute(string details, Risk risk, string[] urls, int yyyymmdd) : base(details, risk, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public TestAttribute(string details, Risk risk, Effort effort, string[] urls, int yyyymmdd) : base(details, risk, effort, "", urls, yyyymmdd){}

		// Focus on effort

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public TestAttribute(string details, Effort effort) : base(details, null, effort, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public TestAttribute(string details, Effort effort, string tags) : base(details, null, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public TestAttribute(string details, Effort effort, string[] urls) : base(details, null, effort, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public TestAttribute(string details, Effort effort, string tags, string[] urls) : base(details, null, effort, tags, urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public TestAttribute(string details, Effort effort, int yyyymmdd) : base(details, null, effort, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public TestAttribute(string details, Effort effort, string tags, int yyyymmdd) : base(details, null, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public TestAttribute(string details, Effort effort, string[] urls, int yyyymmdd) : base(details, null, effort, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public TestAttribute(string details, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, null, effort, tags, urls, yyyymmdd){}

		// Full tilt

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public TestAttribute(string details, Risk risk, Effort effort, string tags, string[] urls) : base(details, risk, effort, tags, urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public TestAttribute(string details, Risk risk, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, risk, effort, tags, urls, yyyymmdd){}

	}

    /// <summary>
    /// Used to identify external resources (like StakeOverflow, blogs, etc) that would add value to the context this attribute is applied to. (Default risk = None, Default effort = None)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class CiteAttribute : CodeDocsAttribute, IMeaning
    {

		public override Definition Definition { get { return Glossary.Cite; }}

		// Just Details

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
		public CiteAttribute(string details) : base(details, null, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public CiteAttribute(string details, int yyyymmdd) : base(details, null, null, "", null, yyyymmdd){}

		// Focus on risk

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
		public CiteAttribute(string details, Risk risk) : base(details, risk, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public CiteAttribute(string details, Risk risk, Effort effort) : base(details, risk, effort, "", null, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public CiteAttribute(string details, Risk risk, int yyyymmdd) : base(details, risk, null, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public CiteAttribute(string details, Risk risk, Effort effort, int yyyymmdd) : base(details, risk, effort, "", null, yyyymmdd){}

		// Focus on tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public CiteAttribute(string details, string tags) : base(details, null, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public CiteAttribute(string details, Risk risk, string tags) : base(details, risk, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public CiteAttribute(string details, Risk risk, Effort effort, string tags) : base(details, risk, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public CiteAttribute(string details, string tags, string[] urls) : base(details, null, null, tags, urls, null){}

		// Add in date for tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public CiteAttribute(string details, string tags, int yyyymmdd) : base(details, null, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public CiteAttribute(string details, Risk risk, string tags, int yyyymmdd) : base(details, risk, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public CiteAttribute(string details, Risk risk, Effort effort, string tags, int yyyymmdd) : base(details, risk, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public CiteAttribute(string details, string tags, string[] urls, int yyyymmdd) : base(details, null, null, tags, urls, yyyymmdd){}

		// Add in urls

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public CiteAttribute(string details, string[] urls) : base(details, null, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public CiteAttribute(string details, Risk risk, string[] urls) : base(details, risk, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public CiteAttribute(string details, Risk risk, Effort effort, string[] urls) : base(details, risk, effort, "", urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public CiteAttribute(string details, string[] urls, int yyyymmdd) : base(details, null, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public CiteAttribute(string details, Risk risk, string[] urls, int yyyymmdd) : base(details, risk, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public CiteAttribute(string details, Risk risk, Effort effort, string[] urls, int yyyymmdd) : base(details, risk, effort, "", urls, yyyymmdd){}

		// Focus on effort

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public CiteAttribute(string details, Effort effort) : base(details, null, effort, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public CiteAttribute(string details, Effort effort, string tags) : base(details, null, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public CiteAttribute(string details, Effort effort, string[] urls) : base(details, null, effort, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public CiteAttribute(string details, Effort effort, string tags, string[] urls) : base(details, null, effort, tags, urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public CiteAttribute(string details, Effort effort, int yyyymmdd) : base(details, null, effort, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public CiteAttribute(string details, Effort effort, string tags, int yyyymmdd) : base(details, null, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public CiteAttribute(string details, Effort effort, string[] urls, int yyyymmdd) : base(details, null, effort, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public CiteAttribute(string details, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, null, effort, tags, urls, yyyymmdd){}

		// Full tilt

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public CiteAttribute(string details, Risk risk, Effort effort, string tags, string[] urls) : base(details, risk, effort, tags, urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public CiteAttribute(string details, Risk risk, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, risk, effort, tags, urls, yyyymmdd){}

	}

    /// <summary>
    /// A distinctive function/attribute about what the application does. (Default risk = None, Default effort = None)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class FeatureAttribute : CodeDocsAttribute, IFeature
    {

		public override Definition Definition { get { return Glossary.Feature; }}

		// Just Details

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
		public FeatureAttribute(string details) : base(details, null, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public FeatureAttribute(string details, int yyyymmdd) : base(details, null, null, "", null, yyyymmdd){}

		// Focus on risk

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
		public FeatureAttribute(string details, Risk risk) : base(details, risk, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public FeatureAttribute(string details, Risk risk, Effort effort) : base(details, risk, effort, "", null, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public FeatureAttribute(string details, Risk risk, int yyyymmdd) : base(details, risk, null, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public FeatureAttribute(string details, Risk risk, Effort effort, int yyyymmdd) : base(details, risk, effort, "", null, yyyymmdd){}

		// Focus on tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public FeatureAttribute(string details, string tags) : base(details, null, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public FeatureAttribute(string details, Risk risk, string tags) : base(details, risk, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public FeatureAttribute(string details, Risk risk, Effort effort, string tags) : base(details, risk, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public FeatureAttribute(string details, string tags, string[] urls) : base(details, null, null, tags, urls, null){}

		// Add in date for tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public FeatureAttribute(string details, string tags, int yyyymmdd) : base(details, null, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public FeatureAttribute(string details, Risk risk, string tags, int yyyymmdd) : base(details, risk, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public FeatureAttribute(string details, Risk risk, Effort effort, string tags, int yyyymmdd) : base(details, risk, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public FeatureAttribute(string details, string tags, string[] urls, int yyyymmdd) : base(details, null, null, tags, urls, yyyymmdd){}

		// Add in urls

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public FeatureAttribute(string details, string[] urls) : base(details, null, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public FeatureAttribute(string details, Risk risk, string[] urls) : base(details, risk, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public FeatureAttribute(string details, Risk risk, Effort effort, string[] urls) : base(details, risk, effort, "", urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public FeatureAttribute(string details, string[] urls, int yyyymmdd) : base(details, null, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public FeatureAttribute(string details, Risk risk, string[] urls, int yyyymmdd) : base(details, risk, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public FeatureAttribute(string details, Risk risk, Effort effort, string[] urls, int yyyymmdd) : base(details, risk, effort, "", urls, yyyymmdd){}

		// Focus on effort

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public FeatureAttribute(string details, Effort effort) : base(details, null, effort, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public FeatureAttribute(string details, Effort effort, string tags) : base(details, null, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public FeatureAttribute(string details, Effort effort, string[] urls) : base(details, null, effort, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public FeatureAttribute(string details, Effort effort, string tags, string[] urls) : base(details, null, effort, tags, urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public FeatureAttribute(string details, Effort effort, int yyyymmdd) : base(details, null, effort, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public FeatureAttribute(string details, Effort effort, string tags, int yyyymmdd) : base(details, null, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public FeatureAttribute(string details, Effort effort, string[] urls, int yyyymmdd) : base(details, null, effort, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public FeatureAttribute(string details, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, null, effort, tags, urls, yyyymmdd){}

		// Full tilt

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public FeatureAttribute(string details, Risk risk, Effort effort, string tags, string[] urls) : base(details, risk, effort, tags, urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public FeatureAttribute(string details, Risk risk, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, risk, effort, tags, urls, yyyymmdd){}

	}

    /// <summary>
    /// Identification of a major change that is important to communicate and potentially worthy of moving the version # forward if any exist during deployment (major.minor.incr). (Default risk = None, Default effort = None)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class MajorChangeAttribute : CodeDocsAttribute, IChange, IMajor
    {

		public override Definition Definition { get { return Glossary.MajorChange; }}

		// Just Details

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
		public MajorChangeAttribute(string details) : base(details, null, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MajorChangeAttribute(string details, int yyyymmdd) : base(details, null, null, "", null, yyyymmdd){}

		// Focus on risk

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
		public MajorChangeAttribute(string details, Risk risk) : base(details, risk, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public MajorChangeAttribute(string details, Risk risk, Effort effort) : base(details, risk, effort, "", null, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MajorChangeAttribute(string details, Risk risk, int yyyymmdd) : base(details, risk, null, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MajorChangeAttribute(string details, Risk risk, Effort effort, int yyyymmdd) : base(details, risk, effort, "", null, yyyymmdd){}

		// Focus on tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public MajorChangeAttribute(string details, string tags) : base(details, null, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public MajorChangeAttribute(string details, Risk risk, string tags) : base(details, risk, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public MajorChangeAttribute(string details, Risk risk, Effort effort, string tags) : base(details, risk, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MajorChangeAttribute(string details, string tags, string[] urls) : base(details, null, null, tags, urls, null){}

		// Add in date for tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MajorChangeAttribute(string details, string tags, int yyyymmdd) : base(details, null, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MajorChangeAttribute(string details, Risk risk, string tags, int yyyymmdd) : base(details, risk, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MajorChangeAttribute(string details, Risk risk, Effort effort, string tags, int yyyymmdd) : base(details, risk, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MajorChangeAttribute(string details, string tags, string[] urls, int yyyymmdd) : base(details, null, null, tags, urls, yyyymmdd){}

		// Add in urls

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MajorChangeAttribute(string details, string[] urls) : base(details, null, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MajorChangeAttribute(string details, Risk risk, string[] urls) : base(details, risk, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MajorChangeAttribute(string details, Risk risk, Effort effort, string[] urls) : base(details, risk, effort, "", urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MajorChangeAttribute(string details, string[] urls, int yyyymmdd) : base(details, null, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MajorChangeAttribute(string details, Risk risk, string[] urls, int yyyymmdd) : base(details, risk, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MajorChangeAttribute(string details, Risk risk, Effort effort, string[] urls, int yyyymmdd) : base(details, risk, effort, "", urls, yyyymmdd){}

		// Focus on effort

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public MajorChangeAttribute(string details, Effort effort) : base(details, null, effort, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public MajorChangeAttribute(string details, Effort effort, string tags) : base(details, null, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MajorChangeAttribute(string details, Effort effort, string[] urls) : base(details, null, effort, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MajorChangeAttribute(string details, Effort effort, string tags, string[] urls) : base(details, null, effort, tags, urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MajorChangeAttribute(string details, Effort effort, int yyyymmdd) : base(details, null, effort, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MajorChangeAttribute(string details, Effort effort, string tags, int yyyymmdd) : base(details, null, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MajorChangeAttribute(string details, Effort effort, string[] urls, int yyyymmdd) : base(details, null, effort, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MajorChangeAttribute(string details, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, null, effort, tags, urls, yyyymmdd){}

		// Full tilt

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MajorChangeAttribute(string details, Risk risk, Effort effort, string tags, string[] urls) : base(details, risk, effort, tags, urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MajorChangeAttribute(string details, Risk risk, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, risk, effort, tags, urls, yyyymmdd){}

	}

    /// <summary>
    /// Identification of a minor change that is important to communicate and potentially worthy of moving the version # forward if any exist during deployment (major.minor.incr). (Default risk = None, Default effort = None)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class MinorChangeAttribute : CodeDocsAttribute, IChange, IMinor
    {

		public override Definition Definition { get { return Glossary.MinorChange; }}

		// Just Details

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
		public MinorChangeAttribute(string details) : base(details, null, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MinorChangeAttribute(string details, int yyyymmdd) : base(details, null, null, "", null, yyyymmdd){}

		// Focus on risk

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
		public MinorChangeAttribute(string details, Risk risk) : base(details, risk, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public MinorChangeAttribute(string details, Risk risk, Effort effort) : base(details, risk, effort, "", null, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MinorChangeAttribute(string details, Risk risk, int yyyymmdd) : base(details, risk, null, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MinorChangeAttribute(string details, Risk risk, Effort effort, int yyyymmdd) : base(details, risk, effort, "", null, yyyymmdd){}

		// Focus on tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public MinorChangeAttribute(string details, string tags) : base(details, null, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public MinorChangeAttribute(string details, Risk risk, string tags) : base(details, risk, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public MinorChangeAttribute(string details, Risk risk, Effort effort, string tags) : base(details, risk, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MinorChangeAttribute(string details, string tags, string[] urls) : base(details, null, null, tags, urls, null){}

		// Add in date for tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MinorChangeAttribute(string details, string tags, int yyyymmdd) : base(details, null, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MinorChangeAttribute(string details, Risk risk, string tags, int yyyymmdd) : base(details, risk, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MinorChangeAttribute(string details, Risk risk, Effort effort, string tags, int yyyymmdd) : base(details, risk, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MinorChangeAttribute(string details, string tags, string[] urls, int yyyymmdd) : base(details, null, null, tags, urls, yyyymmdd){}

		// Add in urls

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MinorChangeAttribute(string details, string[] urls) : base(details, null, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MinorChangeAttribute(string details, Risk risk, string[] urls) : base(details, risk, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MinorChangeAttribute(string details, Risk risk, Effort effort, string[] urls) : base(details, risk, effort, "", urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MinorChangeAttribute(string details, string[] urls, int yyyymmdd) : base(details, null, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MinorChangeAttribute(string details, Risk risk, string[] urls, int yyyymmdd) : base(details, risk, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MinorChangeAttribute(string details, Risk risk, Effort effort, string[] urls, int yyyymmdd) : base(details, risk, effort, "", urls, yyyymmdd){}

		// Focus on effort

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public MinorChangeAttribute(string details, Effort effort) : base(details, null, effort, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public MinorChangeAttribute(string details, Effort effort, string tags) : base(details, null, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MinorChangeAttribute(string details, Effort effort, string[] urls) : base(details, null, effort, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MinorChangeAttribute(string details, Effort effort, string tags, string[] urls) : base(details, null, effort, tags, urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MinorChangeAttribute(string details, Effort effort, int yyyymmdd) : base(details, null, effort, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MinorChangeAttribute(string details, Effort effort, string tags, int yyyymmdd) : base(details, null, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MinorChangeAttribute(string details, Effort effort, string[] urls, int yyyymmdd) : base(details, null, effort, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MinorChangeAttribute(string details, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, null, effort, tags, urls, yyyymmdd){}

		// Full tilt

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MinorChangeAttribute(string details, Risk risk, Effort effort, string tags, string[] urls) : base(details, risk, effort, tags, urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public MinorChangeAttribute(string details, Risk risk, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, risk, effort, tags, urls, yyyymmdd){}

	}

    /// <summary>
    /// Intent is clear.  However, naming could be cleaner. (Default risk = Low, Default effort = Small)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class NamingAttribute : CodeDocsAttribute, IMeaning
    {

		public override Definition Definition { get { return Glossary.Naming; }}

		// Just Details

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
		public NamingAttribute(string details) : base(details, null, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public NamingAttribute(string details, int yyyymmdd) : base(details, null, null, "", null, yyyymmdd){}

		// Focus on risk

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
		public NamingAttribute(string details, Risk risk) : base(details, risk, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public NamingAttribute(string details, Risk risk, Effort effort) : base(details, risk, effort, "", null, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public NamingAttribute(string details, Risk risk, int yyyymmdd) : base(details, risk, null, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public NamingAttribute(string details, Risk risk, Effort effort, int yyyymmdd) : base(details, risk, effort, "", null, yyyymmdd){}

		// Focus on tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public NamingAttribute(string details, string tags) : base(details, null, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public NamingAttribute(string details, Risk risk, string tags) : base(details, risk, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public NamingAttribute(string details, Risk risk, Effort effort, string tags) : base(details, risk, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public NamingAttribute(string details, string tags, string[] urls) : base(details, null, null, tags, urls, null){}

		// Add in date for tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public NamingAttribute(string details, string tags, int yyyymmdd) : base(details, null, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public NamingAttribute(string details, Risk risk, string tags, int yyyymmdd) : base(details, risk, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public NamingAttribute(string details, Risk risk, Effort effort, string tags, int yyyymmdd) : base(details, risk, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public NamingAttribute(string details, string tags, string[] urls, int yyyymmdd) : base(details, null, null, tags, urls, yyyymmdd){}

		// Add in urls

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public NamingAttribute(string details, string[] urls) : base(details, null, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public NamingAttribute(string details, Risk risk, string[] urls) : base(details, risk, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public NamingAttribute(string details, Risk risk, Effort effort, string[] urls) : base(details, risk, effort, "", urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public NamingAttribute(string details, string[] urls, int yyyymmdd) : base(details, null, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public NamingAttribute(string details, Risk risk, string[] urls, int yyyymmdd) : base(details, risk, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public NamingAttribute(string details, Risk risk, Effort effort, string[] urls, int yyyymmdd) : base(details, risk, effort, "", urls, yyyymmdd){}

		// Focus on effort

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public NamingAttribute(string details, Effort effort) : base(details, null, effort, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public NamingAttribute(string details, Effort effort, string tags) : base(details, null, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public NamingAttribute(string details, Effort effort, string[] urls) : base(details, null, effort, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public NamingAttribute(string details, Effort effort, string tags, string[] urls) : base(details, null, effort, tags, urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public NamingAttribute(string details, Effort effort, int yyyymmdd) : base(details, null, effort, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public NamingAttribute(string details, Effort effort, string tags, int yyyymmdd) : base(details, null, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public NamingAttribute(string details, Effort effort, string[] urls, int yyyymmdd) : base(details, null, effort, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public NamingAttribute(string details, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, null, effort, tags, urls, yyyymmdd){}

		// Full tilt

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public NamingAttribute(string details, Risk risk, Effort effort, string tags, string[] urls) : base(details, risk, effort, tags, urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public NamingAttribute(string details, Risk risk, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, risk, effort, tags, urls, yyyymmdd){}

	}

    /// <summary>
    /// Hard to read at first glance for one or more people. (Default risk = Low, Default effort = Small)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class ReadabilityAttribute : CodeDocsAttribute, IMeaning
    {

		public override Definition Definition { get { return Glossary.Readability; }}

		// Just Details

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
		public ReadabilityAttribute(string details) : base(details, null, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ReadabilityAttribute(string details, int yyyymmdd) : base(details, null, null, "", null, yyyymmdd){}

		// Focus on risk

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
		public ReadabilityAttribute(string details, Risk risk) : base(details, risk, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public ReadabilityAttribute(string details, Risk risk, Effort effort) : base(details, risk, effort, "", null, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ReadabilityAttribute(string details, Risk risk, int yyyymmdd) : base(details, risk, null, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ReadabilityAttribute(string details, Risk risk, Effort effort, int yyyymmdd) : base(details, risk, effort, "", null, yyyymmdd){}

		// Focus on tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public ReadabilityAttribute(string details, string tags) : base(details, null, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public ReadabilityAttribute(string details, Risk risk, string tags) : base(details, risk, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public ReadabilityAttribute(string details, Risk risk, Effort effort, string tags) : base(details, risk, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ReadabilityAttribute(string details, string tags, string[] urls) : base(details, null, null, tags, urls, null){}

		// Add in date for tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ReadabilityAttribute(string details, string tags, int yyyymmdd) : base(details, null, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ReadabilityAttribute(string details, Risk risk, string tags, int yyyymmdd) : base(details, risk, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ReadabilityAttribute(string details, Risk risk, Effort effort, string tags, int yyyymmdd) : base(details, risk, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ReadabilityAttribute(string details, string tags, string[] urls, int yyyymmdd) : base(details, null, null, tags, urls, yyyymmdd){}

		// Add in urls

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ReadabilityAttribute(string details, string[] urls) : base(details, null, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ReadabilityAttribute(string details, Risk risk, string[] urls) : base(details, risk, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ReadabilityAttribute(string details, Risk risk, Effort effort, string[] urls) : base(details, risk, effort, "", urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ReadabilityAttribute(string details, string[] urls, int yyyymmdd) : base(details, null, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ReadabilityAttribute(string details, Risk risk, string[] urls, int yyyymmdd) : base(details, risk, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ReadabilityAttribute(string details, Risk risk, Effort effort, string[] urls, int yyyymmdd) : base(details, risk, effort, "", urls, yyyymmdd){}

		// Focus on effort

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public ReadabilityAttribute(string details, Effort effort) : base(details, null, effort, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public ReadabilityAttribute(string details, Effort effort, string tags) : base(details, null, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ReadabilityAttribute(string details, Effort effort, string[] urls) : base(details, null, effort, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ReadabilityAttribute(string details, Effort effort, string tags, string[] urls) : base(details, null, effort, tags, urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ReadabilityAttribute(string details, Effort effort, int yyyymmdd) : base(details, null, effort, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ReadabilityAttribute(string details, Effort effort, string tags, int yyyymmdd) : base(details, null, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ReadabilityAttribute(string details, Effort effort, string[] urls, int yyyymmdd) : base(details, null, effort, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ReadabilityAttribute(string details, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, null, effort, tags, urls, yyyymmdd){}

		// Full tilt

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ReadabilityAttribute(string details, Risk risk, Effort effort, string tags, string[] urls) : base(details, risk, effort, tags, urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ReadabilityAttribute(string details, Risk risk, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, risk, effort, tags, urls, yyyymmdd){}

	}

    /// <summary>
    /// Piece of code that appears to be in the wrong place. (Default risk = Low, Default effort = Unknown)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class LocationAttribute : CodeDocsAttribute, IMeaning
    {

		public override Definition Definition { get { return Glossary.Location; }}

		// Just Details

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
		public LocationAttribute(string details) : base(details, null, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LocationAttribute(string details, int yyyymmdd) : base(details, null, null, "", null, yyyymmdd){}

		// Focus on risk

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
		public LocationAttribute(string details, Risk risk) : base(details, risk, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public LocationAttribute(string details, Risk risk, Effort effort) : base(details, risk, effort, "", null, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LocationAttribute(string details, Risk risk, int yyyymmdd) : base(details, risk, null, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LocationAttribute(string details, Risk risk, Effort effort, int yyyymmdd) : base(details, risk, effort, "", null, yyyymmdd){}

		// Focus on tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public LocationAttribute(string details, string tags) : base(details, null, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public LocationAttribute(string details, Risk risk, string tags) : base(details, risk, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public LocationAttribute(string details, Risk risk, Effort effort, string tags) : base(details, risk, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public LocationAttribute(string details, string tags, string[] urls) : base(details, null, null, tags, urls, null){}

		// Add in date for tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LocationAttribute(string details, string tags, int yyyymmdd) : base(details, null, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LocationAttribute(string details, Risk risk, string tags, int yyyymmdd) : base(details, risk, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LocationAttribute(string details, Risk risk, Effort effort, string tags, int yyyymmdd) : base(details, risk, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LocationAttribute(string details, string tags, string[] urls, int yyyymmdd) : base(details, null, null, tags, urls, yyyymmdd){}

		// Add in urls

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public LocationAttribute(string details, string[] urls) : base(details, null, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public LocationAttribute(string details, Risk risk, string[] urls) : base(details, risk, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public LocationAttribute(string details, Risk risk, Effort effort, string[] urls) : base(details, risk, effort, "", urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LocationAttribute(string details, string[] urls, int yyyymmdd) : base(details, null, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LocationAttribute(string details, Risk risk, string[] urls, int yyyymmdd) : base(details, risk, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LocationAttribute(string details, Risk risk, Effort effort, string[] urls, int yyyymmdd) : base(details, risk, effort, "", urls, yyyymmdd){}

		// Focus on effort

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public LocationAttribute(string details, Effort effort) : base(details, null, effort, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public LocationAttribute(string details, Effort effort, string tags) : base(details, null, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public LocationAttribute(string details, Effort effort, string[] urls) : base(details, null, effort, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public LocationAttribute(string details, Effort effort, string tags, string[] urls) : base(details, null, effort, tags, urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LocationAttribute(string details, Effort effort, int yyyymmdd) : base(details, null, effort, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LocationAttribute(string details, Effort effort, string tags, int yyyymmdd) : base(details, null, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LocationAttribute(string details, Effort effort, string[] urls, int yyyymmdd) : base(details, null, effort, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LocationAttribute(string details, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, null, effort, tags, urls, yyyymmdd){}

		// Full tilt

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public LocationAttribute(string details, Risk risk, Effort effort, string tags, string[] urls) : base(details, risk, effort, tags, urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LocationAttribute(string details, Risk risk, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, risk, effort, tags, urls, yyyymmdd){}

	}

    /// <summary>
    /// A piece of code that needs refactored to adhere to code/design standards. (Default risk = Low, Default effort = VerySmall)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class StandardsAttribute : CodeDocsAttribute, IStandards
    {

		public override Definition Definition { get { return Glossary.Standards; }}

		// Just Details

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
		public StandardsAttribute(string details) : base(details, null, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public StandardsAttribute(string details, int yyyymmdd) : base(details, null, null, "", null, yyyymmdd){}

		// Focus on risk

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
		public StandardsAttribute(string details, Risk risk) : base(details, risk, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public StandardsAttribute(string details, Risk risk, Effort effort) : base(details, risk, effort, "", null, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public StandardsAttribute(string details, Risk risk, int yyyymmdd) : base(details, risk, null, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public StandardsAttribute(string details, Risk risk, Effort effort, int yyyymmdd) : base(details, risk, effort, "", null, yyyymmdd){}

		// Focus on tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public StandardsAttribute(string details, string tags) : base(details, null, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public StandardsAttribute(string details, Risk risk, string tags) : base(details, risk, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public StandardsAttribute(string details, Risk risk, Effort effort, string tags) : base(details, risk, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public StandardsAttribute(string details, string tags, string[] urls) : base(details, null, null, tags, urls, null){}

		// Add in date for tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public StandardsAttribute(string details, string tags, int yyyymmdd) : base(details, null, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public StandardsAttribute(string details, Risk risk, string tags, int yyyymmdd) : base(details, risk, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public StandardsAttribute(string details, Risk risk, Effort effort, string tags, int yyyymmdd) : base(details, risk, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public StandardsAttribute(string details, string tags, string[] urls, int yyyymmdd) : base(details, null, null, tags, urls, yyyymmdd){}

		// Add in urls

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public StandardsAttribute(string details, string[] urls) : base(details, null, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public StandardsAttribute(string details, Risk risk, string[] urls) : base(details, risk, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public StandardsAttribute(string details, Risk risk, Effort effort, string[] urls) : base(details, risk, effort, "", urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public StandardsAttribute(string details, string[] urls, int yyyymmdd) : base(details, null, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public StandardsAttribute(string details, Risk risk, string[] urls, int yyyymmdd) : base(details, risk, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public StandardsAttribute(string details, Risk risk, Effort effort, string[] urls, int yyyymmdd) : base(details, risk, effort, "", urls, yyyymmdd){}

		// Focus on effort

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public StandardsAttribute(string details, Effort effort) : base(details, null, effort, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public StandardsAttribute(string details, Effort effort, string tags) : base(details, null, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public StandardsAttribute(string details, Effort effort, string[] urls) : base(details, null, effort, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public StandardsAttribute(string details, Effort effort, string tags, string[] urls) : base(details, null, effort, tags, urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public StandardsAttribute(string details, Effort effort, int yyyymmdd) : base(details, null, effort, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public StandardsAttribute(string details, Effort effort, string tags, int yyyymmdd) : base(details, null, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public StandardsAttribute(string details, Effort effort, string[] urls, int yyyymmdd) : base(details, null, effort, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public StandardsAttribute(string details, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, null, effort, tags, urls, yyyymmdd){}

		// Full tilt

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public StandardsAttribute(string details, Risk risk, Effort effort, string tags, string[] urls) : base(details, risk, effort, tags, urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public StandardsAttribute(string details, Risk risk, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, risk, effort, tags, urls, yyyymmdd){}

	}

    /// <summary>
    /// Working feature.  Requires refactoring due to shortcuts needed to make it work. (Default risk = Moderate, Default effort = Unknown)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class HackAttribute : CodeDocsAttribute, IDegredation
    {

		public override Definition Definition { get { return Glossary.Hack; }}

		// Just Details

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
		public HackAttribute(string details) : base(details, null, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public HackAttribute(string details, int yyyymmdd) : base(details, null, null, "", null, yyyymmdd){}

		// Focus on risk

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
		public HackAttribute(string details, Risk risk) : base(details, risk, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public HackAttribute(string details, Risk risk, Effort effort) : base(details, risk, effort, "", null, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public HackAttribute(string details, Risk risk, int yyyymmdd) : base(details, risk, null, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public HackAttribute(string details, Risk risk, Effort effort, int yyyymmdd) : base(details, risk, effort, "", null, yyyymmdd){}

		// Focus on tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public HackAttribute(string details, string tags) : base(details, null, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public HackAttribute(string details, Risk risk, string tags) : base(details, risk, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public HackAttribute(string details, Risk risk, Effort effort, string tags) : base(details, risk, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public HackAttribute(string details, string tags, string[] urls) : base(details, null, null, tags, urls, null){}

		// Add in date for tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public HackAttribute(string details, string tags, int yyyymmdd) : base(details, null, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public HackAttribute(string details, Risk risk, string tags, int yyyymmdd) : base(details, risk, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public HackAttribute(string details, Risk risk, Effort effort, string tags, int yyyymmdd) : base(details, risk, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public HackAttribute(string details, string tags, string[] urls, int yyyymmdd) : base(details, null, null, tags, urls, yyyymmdd){}

		// Add in urls

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public HackAttribute(string details, string[] urls) : base(details, null, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public HackAttribute(string details, Risk risk, string[] urls) : base(details, risk, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public HackAttribute(string details, Risk risk, Effort effort, string[] urls) : base(details, risk, effort, "", urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public HackAttribute(string details, string[] urls, int yyyymmdd) : base(details, null, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public HackAttribute(string details, Risk risk, string[] urls, int yyyymmdd) : base(details, risk, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public HackAttribute(string details, Risk risk, Effort effort, string[] urls, int yyyymmdd) : base(details, risk, effort, "", urls, yyyymmdd){}

		// Focus on effort

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public HackAttribute(string details, Effort effort) : base(details, null, effort, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public HackAttribute(string details, Effort effort, string tags) : base(details, null, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public HackAttribute(string details, Effort effort, string[] urls) : base(details, null, effort, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public HackAttribute(string details, Effort effort, string tags, string[] urls) : base(details, null, effort, tags, urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public HackAttribute(string details, Effort effort, int yyyymmdd) : base(details, null, effort, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public HackAttribute(string details, Effort effort, string tags, int yyyymmdd) : base(details, null, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public HackAttribute(string details, Effort effort, string[] urls, int yyyymmdd) : base(details, null, effort, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public HackAttribute(string details, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, null, effort, tags, urls, yyyymmdd){}

		// Full tilt

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public HackAttribute(string details, Risk risk, Effort effort, string tags, string[] urls) : base(details, risk, effort, tags, urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public HackAttribute(string details, Risk risk, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, risk, effort, tags, urls, yyyymmdd){}

	}

    /// <summary>
    /// Working feature that needs improvement. (Default risk = Low, Default effort = Unknown)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class RefactorAttribute : CodeDocsAttribute, IDegredation
    {

		public override Definition Definition { get { return Glossary.Refactor; }}

		// Just Details

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
		public RefactorAttribute(string details) : base(details, null, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public RefactorAttribute(string details, int yyyymmdd) : base(details, null, null, "", null, yyyymmdd){}

		// Focus on risk

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
		public RefactorAttribute(string details, Risk risk) : base(details, risk, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public RefactorAttribute(string details, Risk risk, Effort effort) : base(details, risk, effort, "", null, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public RefactorAttribute(string details, Risk risk, int yyyymmdd) : base(details, risk, null, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public RefactorAttribute(string details, Risk risk, Effort effort, int yyyymmdd) : base(details, risk, effort, "", null, yyyymmdd){}

		// Focus on tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public RefactorAttribute(string details, string tags) : base(details, null, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public RefactorAttribute(string details, Risk risk, string tags) : base(details, risk, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public RefactorAttribute(string details, Risk risk, Effort effort, string tags) : base(details, risk, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public RefactorAttribute(string details, string tags, string[] urls) : base(details, null, null, tags, urls, null){}

		// Add in date for tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public RefactorAttribute(string details, string tags, int yyyymmdd) : base(details, null, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public RefactorAttribute(string details, Risk risk, string tags, int yyyymmdd) : base(details, risk, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public RefactorAttribute(string details, Risk risk, Effort effort, string tags, int yyyymmdd) : base(details, risk, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public RefactorAttribute(string details, string tags, string[] urls, int yyyymmdd) : base(details, null, null, tags, urls, yyyymmdd){}

		// Add in urls

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public RefactorAttribute(string details, string[] urls) : base(details, null, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public RefactorAttribute(string details, Risk risk, string[] urls) : base(details, risk, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public RefactorAttribute(string details, Risk risk, Effort effort, string[] urls) : base(details, risk, effort, "", urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public RefactorAttribute(string details, string[] urls, int yyyymmdd) : base(details, null, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public RefactorAttribute(string details, Risk risk, string[] urls, int yyyymmdd) : base(details, risk, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public RefactorAttribute(string details, Risk risk, Effort effort, string[] urls, int yyyymmdd) : base(details, risk, effort, "", urls, yyyymmdd){}

		// Focus on effort

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public RefactorAttribute(string details, Effort effort) : base(details, null, effort, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public RefactorAttribute(string details, Effort effort, string tags) : base(details, null, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public RefactorAttribute(string details, Effort effort, string[] urls) : base(details, null, effort, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public RefactorAttribute(string details, Effort effort, string tags, string[] urls) : base(details, null, effort, tags, urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public RefactorAttribute(string details, Effort effort, int yyyymmdd) : base(details, null, effort, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public RefactorAttribute(string details, Effort effort, string tags, int yyyymmdd) : base(details, null, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public RefactorAttribute(string details, Effort effort, string[] urls, int yyyymmdd) : base(details, null, effort, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public RefactorAttribute(string details, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, null, effort, tags, urls, yyyymmdd){}

		// Full tilt

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public RefactorAttribute(string details, Risk risk, Effort effort, string tags, string[] urls) : base(details, risk, effort, tags, urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public RefactorAttribute(string details, Risk risk, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, risk, effort, tags, urls, yyyymmdd){}

	}

    /// <summary>
    /// Readable, but missing a 'good to know' for people trying to understand. (Default risk = Low, Default effort = VerySmall)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class ClarificationAttribute : CodeDocsAttribute, IMeaning
    {

		public override Definition Definition { get { return Glossary.Clarification; }}

		// Just Details

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
		public ClarificationAttribute(string details) : base(details, null, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ClarificationAttribute(string details, int yyyymmdd) : base(details, null, null, "", null, yyyymmdd){}

		// Focus on risk

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
		public ClarificationAttribute(string details, Risk risk) : base(details, risk, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public ClarificationAttribute(string details, Risk risk, Effort effort) : base(details, risk, effort, "", null, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ClarificationAttribute(string details, Risk risk, int yyyymmdd) : base(details, risk, null, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ClarificationAttribute(string details, Risk risk, Effort effort, int yyyymmdd) : base(details, risk, effort, "", null, yyyymmdd){}

		// Focus on tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public ClarificationAttribute(string details, string tags) : base(details, null, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public ClarificationAttribute(string details, Risk risk, string tags) : base(details, risk, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public ClarificationAttribute(string details, Risk risk, Effort effort, string tags) : base(details, risk, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ClarificationAttribute(string details, string tags, string[] urls) : base(details, null, null, tags, urls, null){}

		// Add in date for tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ClarificationAttribute(string details, string tags, int yyyymmdd) : base(details, null, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ClarificationAttribute(string details, Risk risk, string tags, int yyyymmdd) : base(details, risk, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ClarificationAttribute(string details, Risk risk, Effort effort, string tags, int yyyymmdd) : base(details, risk, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ClarificationAttribute(string details, string tags, string[] urls, int yyyymmdd) : base(details, null, null, tags, urls, yyyymmdd){}

		// Add in urls

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ClarificationAttribute(string details, string[] urls) : base(details, null, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ClarificationAttribute(string details, Risk risk, string[] urls) : base(details, risk, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ClarificationAttribute(string details, Risk risk, Effort effort, string[] urls) : base(details, risk, effort, "", urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ClarificationAttribute(string details, string[] urls, int yyyymmdd) : base(details, null, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ClarificationAttribute(string details, Risk risk, string[] urls, int yyyymmdd) : base(details, risk, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ClarificationAttribute(string details, Risk risk, Effort effort, string[] urls, int yyyymmdd) : base(details, risk, effort, "", urls, yyyymmdd){}

		// Focus on effort

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public ClarificationAttribute(string details, Effort effort) : base(details, null, effort, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public ClarificationAttribute(string details, Effort effort, string tags) : base(details, null, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ClarificationAttribute(string details, Effort effort, string[] urls) : base(details, null, effort, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ClarificationAttribute(string details, Effort effort, string tags, string[] urls) : base(details, null, effort, tags, urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ClarificationAttribute(string details, Effort effort, int yyyymmdd) : base(details, null, effort, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ClarificationAttribute(string details, Effort effort, string tags, int yyyymmdd) : base(details, null, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ClarificationAttribute(string details, Effort effort, string[] urls, int yyyymmdd) : base(details, null, effort, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ClarificationAttribute(string details, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, null, effort, tags, urls, yyyymmdd){}

		// Full tilt

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ClarificationAttribute(string details, Risk risk, Effort effort, string tags, string[] urls) : base(details, risk, effort, tags, urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public ClarificationAttribute(string details, Risk risk, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, risk, effort, tags, urls, yyyymmdd){}

	}

    /// <summary>
    /// Unsure of actual intent. (Default risk = Moderate, Default effort = Medium)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class PurposeAttribute : CodeDocsAttribute, IMeaning
    {

		public override Definition Definition { get { return Glossary.Purpose; }}

		// Just Details

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
		public PurposeAttribute(string details) : base(details, null, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public PurposeAttribute(string details, int yyyymmdd) : base(details, null, null, "", null, yyyymmdd){}

		// Focus on risk

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
		public PurposeAttribute(string details, Risk risk) : base(details, risk, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public PurposeAttribute(string details, Risk risk, Effort effort) : base(details, risk, effort, "", null, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public PurposeAttribute(string details, Risk risk, int yyyymmdd) : base(details, risk, null, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public PurposeAttribute(string details, Risk risk, Effort effort, int yyyymmdd) : base(details, risk, effort, "", null, yyyymmdd){}

		// Focus on tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public PurposeAttribute(string details, string tags) : base(details, null, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public PurposeAttribute(string details, Risk risk, string tags) : base(details, risk, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public PurposeAttribute(string details, Risk risk, Effort effort, string tags) : base(details, risk, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public PurposeAttribute(string details, string tags, string[] urls) : base(details, null, null, tags, urls, null){}

		// Add in date for tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public PurposeAttribute(string details, string tags, int yyyymmdd) : base(details, null, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public PurposeAttribute(string details, Risk risk, string tags, int yyyymmdd) : base(details, risk, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public PurposeAttribute(string details, Risk risk, Effort effort, string tags, int yyyymmdd) : base(details, risk, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public PurposeAttribute(string details, string tags, string[] urls, int yyyymmdd) : base(details, null, null, tags, urls, yyyymmdd){}

		// Add in urls

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public PurposeAttribute(string details, string[] urls) : base(details, null, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public PurposeAttribute(string details, Risk risk, string[] urls) : base(details, risk, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public PurposeAttribute(string details, Risk risk, Effort effort, string[] urls) : base(details, risk, effort, "", urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public PurposeAttribute(string details, string[] urls, int yyyymmdd) : base(details, null, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public PurposeAttribute(string details, Risk risk, string[] urls, int yyyymmdd) : base(details, risk, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public PurposeAttribute(string details, Risk risk, Effort effort, string[] urls, int yyyymmdd) : base(details, risk, effort, "", urls, yyyymmdd){}

		// Focus on effort

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public PurposeAttribute(string details, Effort effort) : base(details, null, effort, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public PurposeAttribute(string details, Effort effort, string tags) : base(details, null, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public PurposeAttribute(string details, Effort effort, string[] urls) : base(details, null, effort, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public PurposeAttribute(string details, Effort effort, string tags, string[] urls) : base(details, null, effort, tags, urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public PurposeAttribute(string details, Effort effort, int yyyymmdd) : base(details, null, effort, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public PurposeAttribute(string details, Effort effort, string tags, int yyyymmdd) : base(details, null, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public PurposeAttribute(string details, Effort effort, string[] urls, int yyyymmdd) : base(details, null, effort, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public PurposeAttribute(string details, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, null, effort, tags, urls, yyyymmdd){}

		// Full tilt

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public PurposeAttribute(string details, Risk risk, Effort effort, string tags, string[] urls) : base(details, risk, effort, tags, urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public PurposeAttribute(string details, Risk risk, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, risk, effort, tags, urls, yyyymmdd){}

	}

    /// <summary>
    /// A potential future scenario, in which this will need to be changed or these are some insights about the change. (Default risk = Low, Default effort = None)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class FutureAttribute : CodeDocsAttribute, IWork, IFuture
    {

		public override Definition Definition { get { return Glossary.Future; }}

		// Just Details

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
		public FutureAttribute(string details) : base(details, null, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public FutureAttribute(string details, int yyyymmdd) : base(details, null, null, "", null, yyyymmdd){}

		// Focus on risk

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
		public FutureAttribute(string details, Risk risk) : base(details, risk, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public FutureAttribute(string details, Risk risk, Effort effort) : base(details, risk, effort, "", null, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public FutureAttribute(string details, Risk risk, int yyyymmdd) : base(details, risk, null, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public FutureAttribute(string details, Risk risk, Effort effort, int yyyymmdd) : base(details, risk, effort, "", null, yyyymmdd){}

		// Focus on tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public FutureAttribute(string details, string tags) : base(details, null, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public FutureAttribute(string details, Risk risk, string tags) : base(details, risk, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public FutureAttribute(string details, Risk risk, Effort effort, string tags) : base(details, risk, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public FutureAttribute(string details, string tags, string[] urls) : base(details, null, null, tags, urls, null){}

		// Add in date for tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public FutureAttribute(string details, string tags, int yyyymmdd) : base(details, null, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public FutureAttribute(string details, Risk risk, string tags, int yyyymmdd) : base(details, risk, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public FutureAttribute(string details, Risk risk, Effort effort, string tags, int yyyymmdd) : base(details, risk, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public FutureAttribute(string details, string tags, string[] urls, int yyyymmdd) : base(details, null, null, tags, urls, yyyymmdd){}

		// Add in urls

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public FutureAttribute(string details, string[] urls) : base(details, null, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public FutureAttribute(string details, Risk risk, string[] urls) : base(details, risk, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public FutureAttribute(string details, Risk risk, Effort effort, string[] urls) : base(details, risk, effort, "", urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public FutureAttribute(string details, string[] urls, int yyyymmdd) : base(details, null, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public FutureAttribute(string details, Risk risk, string[] urls, int yyyymmdd) : base(details, risk, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public FutureAttribute(string details, Risk risk, Effort effort, string[] urls, int yyyymmdd) : base(details, risk, effort, "", urls, yyyymmdd){}

		// Focus on effort

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public FutureAttribute(string details, Effort effort) : base(details, null, effort, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public FutureAttribute(string details, Effort effort, string tags) : base(details, null, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public FutureAttribute(string details, Effort effort, string[] urls) : base(details, null, effort, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public FutureAttribute(string details, Effort effort, string tags, string[] urls) : base(details, null, effort, tags, urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public FutureAttribute(string details, Effort effort, int yyyymmdd) : base(details, null, effort, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public FutureAttribute(string details, Effort effort, string tags, int yyyymmdd) : base(details, null, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public FutureAttribute(string details, Effort effort, string[] urls, int yyyymmdd) : base(details, null, effort, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public FutureAttribute(string details, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, null, effort, tags, urls, yyyymmdd){}

		// Full tilt

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public FutureAttribute(string details, Risk risk, Effort effort, string tags, string[] urls) : base(details, risk, effort, tags, urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public FutureAttribute(string details, Risk risk, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, risk, effort, tags, urls, yyyymmdd){}

	}

    /// <summary>
    /// [The S in SOLID] Each context of code should do one thing and thus have only one reason to change. (Default risk = Moderate, Default effort = Medium)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class SingleResponsibilityAttribute : CodeDocsAttribute, IPrinciples, ISOLID
    {

		public override Definition Definition { get { return Glossary.SingleResponsibility; }}

		// Just Details

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
		public SingleResponsibilityAttribute(string details) : base(details, null, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SingleResponsibilityAttribute(string details, int yyyymmdd) : base(details, null, null, "", null, yyyymmdd){}

		// Focus on risk

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
		public SingleResponsibilityAttribute(string details, Risk risk) : base(details, risk, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public SingleResponsibilityAttribute(string details, Risk risk, Effort effort) : base(details, risk, effort, "", null, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SingleResponsibilityAttribute(string details, Risk risk, int yyyymmdd) : base(details, risk, null, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SingleResponsibilityAttribute(string details, Risk risk, Effort effort, int yyyymmdd) : base(details, risk, effort, "", null, yyyymmdd){}

		// Focus on tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public SingleResponsibilityAttribute(string details, string tags) : base(details, null, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public SingleResponsibilityAttribute(string details, Risk risk, string tags) : base(details, risk, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public SingleResponsibilityAttribute(string details, Risk risk, Effort effort, string tags) : base(details, risk, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public SingleResponsibilityAttribute(string details, string tags, string[] urls) : base(details, null, null, tags, urls, null){}

		// Add in date for tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SingleResponsibilityAttribute(string details, string tags, int yyyymmdd) : base(details, null, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SingleResponsibilityAttribute(string details, Risk risk, string tags, int yyyymmdd) : base(details, risk, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SingleResponsibilityAttribute(string details, Risk risk, Effort effort, string tags, int yyyymmdd) : base(details, risk, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SingleResponsibilityAttribute(string details, string tags, string[] urls, int yyyymmdd) : base(details, null, null, tags, urls, yyyymmdd){}

		// Add in urls

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public SingleResponsibilityAttribute(string details, string[] urls) : base(details, null, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public SingleResponsibilityAttribute(string details, Risk risk, string[] urls) : base(details, risk, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public SingleResponsibilityAttribute(string details, Risk risk, Effort effort, string[] urls) : base(details, risk, effort, "", urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SingleResponsibilityAttribute(string details, string[] urls, int yyyymmdd) : base(details, null, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SingleResponsibilityAttribute(string details, Risk risk, string[] urls, int yyyymmdd) : base(details, risk, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SingleResponsibilityAttribute(string details, Risk risk, Effort effort, string[] urls, int yyyymmdd) : base(details, risk, effort, "", urls, yyyymmdd){}

		// Focus on effort

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public SingleResponsibilityAttribute(string details, Effort effort) : base(details, null, effort, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public SingleResponsibilityAttribute(string details, Effort effort, string tags) : base(details, null, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public SingleResponsibilityAttribute(string details, Effort effort, string[] urls) : base(details, null, effort, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public SingleResponsibilityAttribute(string details, Effort effort, string tags, string[] urls) : base(details, null, effort, tags, urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SingleResponsibilityAttribute(string details, Effort effort, int yyyymmdd) : base(details, null, effort, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SingleResponsibilityAttribute(string details, Effort effort, string tags, int yyyymmdd) : base(details, null, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SingleResponsibilityAttribute(string details, Effort effort, string[] urls, int yyyymmdd) : base(details, null, effort, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SingleResponsibilityAttribute(string details, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, null, effort, tags, urls, yyyymmdd){}

		// Full tilt

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public SingleResponsibilityAttribute(string details, Risk risk, Effort effort, string tags, string[] urls) : base(details, risk, effort, tags, urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SingleResponsibilityAttribute(string details, Risk risk, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, risk, effort, tags, urls, yyyymmdd){}

	}

    /// <summary>
    /// [The O in SOLID] Software entities should be open for extension, but closed for modification. (Default risk = Moderate, Default effort = Medium)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class OpenClosedAttribute : CodeDocsAttribute, IPrinciples, ISOLID
    {

		public override Definition Definition { get { return Glossary.OpenClosed; }}

		// Just Details

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
		public OpenClosedAttribute(string details) : base(details, null, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public OpenClosedAttribute(string details, int yyyymmdd) : base(details, null, null, "", null, yyyymmdd){}

		// Focus on risk

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
		public OpenClosedAttribute(string details, Risk risk) : base(details, risk, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public OpenClosedAttribute(string details, Risk risk, Effort effort) : base(details, risk, effort, "", null, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public OpenClosedAttribute(string details, Risk risk, int yyyymmdd) : base(details, risk, null, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public OpenClosedAttribute(string details, Risk risk, Effort effort, int yyyymmdd) : base(details, risk, effort, "", null, yyyymmdd){}

		// Focus on tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public OpenClosedAttribute(string details, string tags) : base(details, null, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public OpenClosedAttribute(string details, Risk risk, string tags) : base(details, risk, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public OpenClosedAttribute(string details, Risk risk, Effort effort, string tags) : base(details, risk, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public OpenClosedAttribute(string details, string tags, string[] urls) : base(details, null, null, tags, urls, null){}

		// Add in date for tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public OpenClosedAttribute(string details, string tags, int yyyymmdd) : base(details, null, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public OpenClosedAttribute(string details, Risk risk, string tags, int yyyymmdd) : base(details, risk, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public OpenClosedAttribute(string details, Risk risk, Effort effort, string tags, int yyyymmdd) : base(details, risk, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public OpenClosedAttribute(string details, string tags, string[] urls, int yyyymmdd) : base(details, null, null, tags, urls, yyyymmdd){}

		// Add in urls

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public OpenClosedAttribute(string details, string[] urls) : base(details, null, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public OpenClosedAttribute(string details, Risk risk, string[] urls) : base(details, risk, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public OpenClosedAttribute(string details, Risk risk, Effort effort, string[] urls) : base(details, risk, effort, "", urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public OpenClosedAttribute(string details, string[] urls, int yyyymmdd) : base(details, null, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public OpenClosedAttribute(string details, Risk risk, string[] urls, int yyyymmdd) : base(details, risk, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public OpenClosedAttribute(string details, Risk risk, Effort effort, string[] urls, int yyyymmdd) : base(details, risk, effort, "", urls, yyyymmdd){}

		// Focus on effort

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public OpenClosedAttribute(string details, Effort effort) : base(details, null, effort, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public OpenClosedAttribute(string details, Effort effort, string tags) : base(details, null, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public OpenClosedAttribute(string details, Effort effort, string[] urls) : base(details, null, effort, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public OpenClosedAttribute(string details, Effort effort, string tags, string[] urls) : base(details, null, effort, tags, urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public OpenClosedAttribute(string details, Effort effort, int yyyymmdd) : base(details, null, effort, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public OpenClosedAttribute(string details, Effort effort, string tags, int yyyymmdd) : base(details, null, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public OpenClosedAttribute(string details, Effort effort, string[] urls, int yyyymmdd) : base(details, null, effort, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public OpenClosedAttribute(string details, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, null, effort, tags, urls, yyyymmdd){}

		// Full tilt

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public OpenClosedAttribute(string details, Risk risk, Effort effort, string tags, string[] urls) : base(details, risk, effort, tags, urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public OpenClosedAttribute(string details, Risk risk, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, risk, effort, tags, urls, yyyymmdd){}

	}

    /// <summary>
    /// [The L in SOLID] Objects in a program should be replaceable with instances of their subtypes without altering the correctness of that program. (Default risk = Moderate, Default effort = Medium)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class LiskovSubstitutionAttribute : CodeDocsAttribute, IPrinciples, ISOLID
    {

		public override Definition Definition { get { return Glossary.LiskovSubstitution; }}

		// Just Details

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
		public LiskovSubstitutionAttribute(string details) : base(details, null, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LiskovSubstitutionAttribute(string details, int yyyymmdd) : base(details, null, null, "", null, yyyymmdd){}

		// Focus on risk

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
		public LiskovSubstitutionAttribute(string details, Risk risk) : base(details, risk, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public LiskovSubstitutionAttribute(string details, Risk risk, Effort effort) : base(details, risk, effort, "", null, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LiskovSubstitutionAttribute(string details, Risk risk, int yyyymmdd) : base(details, risk, null, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LiskovSubstitutionAttribute(string details, Risk risk, Effort effort, int yyyymmdd) : base(details, risk, effort, "", null, yyyymmdd){}

		// Focus on tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public LiskovSubstitutionAttribute(string details, string tags) : base(details, null, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public LiskovSubstitutionAttribute(string details, Risk risk, string tags) : base(details, risk, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public LiskovSubstitutionAttribute(string details, Risk risk, Effort effort, string tags) : base(details, risk, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public LiskovSubstitutionAttribute(string details, string tags, string[] urls) : base(details, null, null, tags, urls, null){}

		// Add in date for tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LiskovSubstitutionAttribute(string details, string tags, int yyyymmdd) : base(details, null, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LiskovSubstitutionAttribute(string details, Risk risk, string tags, int yyyymmdd) : base(details, risk, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LiskovSubstitutionAttribute(string details, Risk risk, Effort effort, string tags, int yyyymmdd) : base(details, risk, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LiskovSubstitutionAttribute(string details, string tags, string[] urls, int yyyymmdd) : base(details, null, null, tags, urls, yyyymmdd){}

		// Add in urls

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public LiskovSubstitutionAttribute(string details, string[] urls) : base(details, null, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public LiskovSubstitutionAttribute(string details, Risk risk, string[] urls) : base(details, risk, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public LiskovSubstitutionAttribute(string details, Risk risk, Effort effort, string[] urls) : base(details, risk, effort, "", urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LiskovSubstitutionAttribute(string details, string[] urls, int yyyymmdd) : base(details, null, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LiskovSubstitutionAttribute(string details, Risk risk, string[] urls, int yyyymmdd) : base(details, risk, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LiskovSubstitutionAttribute(string details, Risk risk, Effort effort, string[] urls, int yyyymmdd) : base(details, risk, effort, "", urls, yyyymmdd){}

		// Focus on effort

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public LiskovSubstitutionAttribute(string details, Effort effort) : base(details, null, effort, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public LiskovSubstitutionAttribute(string details, Effort effort, string tags) : base(details, null, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public LiskovSubstitutionAttribute(string details, Effort effort, string[] urls) : base(details, null, effort, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public LiskovSubstitutionAttribute(string details, Effort effort, string tags, string[] urls) : base(details, null, effort, tags, urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LiskovSubstitutionAttribute(string details, Effort effort, int yyyymmdd) : base(details, null, effort, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LiskovSubstitutionAttribute(string details, Effort effort, string tags, int yyyymmdd) : base(details, null, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LiskovSubstitutionAttribute(string details, Effort effort, string[] urls, int yyyymmdd) : base(details, null, effort, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LiskovSubstitutionAttribute(string details, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, null, effort, tags, urls, yyyymmdd){}

		// Full tilt

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public LiskovSubstitutionAttribute(string details, Risk risk, Effort effort, string tags, string[] urls) : base(details, risk, effort, tags, urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LiskovSubstitutionAttribute(string details, Risk risk, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, risk, effort, tags, urls, yyyymmdd){}

	}

    /// <summary>
    /// [The I in SOLID] Many client-specific interfaces are better than one general-purpose interface. (Default risk = Moderate, Default effort = Medium)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class InterfaceSegregationAttribute : CodeDocsAttribute, IPrinciples, ISOLID
    {

		public override Definition Definition { get { return Glossary.InterfaceSegregation; }}

		// Just Details

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
		public InterfaceSegregationAttribute(string details) : base(details, null, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public InterfaceSegregationAttribute(string details, int yyyymmdd) : base(details, null, null, "", null, yyyymmdd){}

		// Focus on risk

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
		public InterfaceSegregationAttribute(string details, Risk risk) : base(details, risk, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public InterfaceSegregationAttribute(string details, Risk risk, Effort effort) : base(details, risk, effort, "", null, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public InterfaceSegregationAttribute(string details, Risk risk, int yyyymmdd) : base(details, risk, null, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public InterfaceSegregationAttribute(string details, Risk risk, Effort effort, int yyyymmdd) : base(details, risk, effort, "", null, yyyymmdd){}

		// Focus on tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public InterfaceSegregationAttribute(string details, string tags) : base(details, null, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public InterfaceSegregationAttribute(string details, Risk risk, string tags) : base(details, risk, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public InterfaceSegregationAttribute(string details, Risk risk, Effort effort, string tags) : base(details, risk, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public InterfaceSegregationAttribute(string details, string tags, string[] urls) : base(details, null, null, tags, urls, null){}

		// Add in date for tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public InterfaceSegregationAttribute(string details, string tags, int yyyymmdd) : base(details, null, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public InterfaceSegregationAttribute(string details, Risk risk, string tags, int yyyymmdd) : base(details, risk, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public InterfaceSegregationAttribute(string details, Risk risk, Effort effort, string tags, int yyyymmdd) : base(details, risk, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public InterfaceSegregationAttribute(string details, string tags, string[] urls, int yyyymmdd) : base(details, null, null, tags, urls, yyyymmdd){}

		// Add in urls

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public InterfaceSegregationAttribute(string details, string[] urls) : base(details, null, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public InterfaceSegregationAttribute(string details, Risk risk, string[] urls) : base(details, risk, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public InterfaceSegregationAttribute(string details, Risk risk, Effort effort, string[] urls) : base(details, risk, effort, "", urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public InterfaceSegregationAttribute(string details, string[] urls, int yyyymmdd) : base(details, null, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public InterfaceSegregationAttribute(string details, Risk risk, string[] urls, int yyyymmdd) : base(details, risk, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public InterfaceSegregationAttribute(string details, Risk risk, Effort effort, string[] urls, int yyyymmdd) : base(details, risk, effort, "", urls, yyyymmdd){}

		// Focus on effort

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public InterfaceSegregationAttribute(string details, Effort effort) : base(details, null, effort, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public InterfaceSegregationAttribute(string details, Effort effort, string tags) : base(details, null, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public InterfaceSegregationAttribute(string details, Effort effort, string[] urls) : base(details, null, effort, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public InterfaceSegregationAttribute(string details, Effort effort, string tags, string[] urls) : base(details, null, effort, tags, urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public InterfaceSegregationAttribute(string details, Effort effort, int yyyymmdd) : base(details, null, effort, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public InterfaceSegregationAttribute(string details, Effort effort, string tags, int yyyymmdd) : base(details, null, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public InterfaceSegregationAttribute(string details, Effort effort, string[] urls, int yyyymmdd) : base(details, null, effort, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public InterfaceSegregationAttribute(string details, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, null, effort, tags, urls, yyyymmdd){}

		// Full tilt

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public InterfaceSegregationAttribute(string details, Risk risk, Effort effort, string tags, string[] urls) : base(details, risk, effort, tags, urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public InterfaceSegregationAttribute(string details, Risk risk, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, risk, effort, tags, urls, yyyymmdd){}

	}

    /// <summary>
    /// [The D in SOLID] Depend upon Abstractions. Do not depend upon concretions. (Default risk = Moderate, Default effort = Medium)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class DependancyInversionAttribute : CodeDocsAttribute, IPrinciples
    {

		public override Definition Definition { get { return Glossary.DependancyInversion; }}

		// Just Details

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
		public DependancyInversionAttribute(string details) : base(details, null, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DependancyInversionAttribute(string details, int yyyymmdd) : base(details, null, null, "", null, yyyymmdd){}

		// Focus on risk

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
		public DependancyInversionAttribute(string details, Risk risk) : base(details, risk, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public DependancyInversionAttribute(string details, Risk risk, Effort effort) : base(details, risk, effort, "", null, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DependancyInversionAttribute(string details, Risk risk, int yyyymmdd) : base(details, risk, null, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DependancyInversionAttribute(string details, Risk risk, Effort effort, int yyyymmdd) : base(details, risk, effort, "", null, yyyymmdd){}

		// Focus on tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public DependancyInversionAttribute(string details, string tags) : base(details, null, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public DependancyInversionAttribute(string details, Risk risk, string tags) : base(details, risk, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public DependancyInversionAttribute(string details, Risk risk, Effort effort, string tags) : base(details, risk, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public DependancyInversionAttribute(string details, string tags, string[] urls) : base(details, null, null, tags, urls, null){}

		// Add in date for tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DependancyInversionAttribute(string details, string tags, int yyyymmdd) : base(details, null, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DependancyInversionAttribute(string details, Risk risk, string tags, int yyyymmdd) : base(details, risk, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DependancyInversionAttribute(string details, Risk risk, Effort effort, string tags, int yyyymmdd) : base(details, risk, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DependancyInversionAttribute(string details, string tags, string[] urls, int yyyymmdd) : base(details, null, null, tags, urls, yyyymmdd){}

		// Add in urls

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public DependancyInversionAttribute(string details, string[] urls) : base(details, null, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public DependancyInversionAttribute(string details, Risk risk, string[] urls) : base(details, risk, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public DependancyInversionAttribute(string details, Risk risk, Effort effort, string[] urls) : base(details, risk, effort, "", urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DependancyInversionAttribute(string details, string[] urls, int yyyymmdd) : base(details, null, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DependancyInversionAttribute(string details, Risk risk, string[] urls, int yyyymmdd) : base(details, risk, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DependancyInversionAttribute(string details, Risk risk, Effort effort, string[] urls, int yyyymmdd) : base(details, risk, effort, "", urls, yyyymmdd){}

		// Focus on effort

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public DependancyInversionAttribute(string details, Effort effort) : base(details, null, effort, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public DependancyInversionAttribute(string details, Effort effort, string tags) : base(details, null, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public DependancyInversionAttribute(string details, Effort effort, string[] urls) : base(details, null, effort, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public DependancyInversionAttribute(string details, Effort effort, string tags, string[] urls) : base(details, null, effort, tags, urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DependancyInversionAttribute(string details, Effort effort, int yyyymmdd) : base(details, null, effort, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DependancyInversionAttribute(string details, Effort effort, string tags, int yyyymmdd) : base(details, null, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DependancyInversionAttribute(string details, Effort effort, string[] urls, int yyyymmdd) : base(details, null, effort, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DependancyInversionAttribute(string details, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, null, effort, tags, urls, yyyymmdd){}

		// Full tilt

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public DependancyInversionAttribute(string details, Risk risk, Effort effort, string tags, string[] urls) : base(details, risk, effort, tags, urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DependancyInversionAttribute(string details, Risk risk, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, risk, effort, tags, urls, yyyymmdd){}

	}

    /// <summary>
    /// (DRY) Every piece of knowledge must have a single, unambiguous, authoritative representation within a system. (Default risk = Moderate, Default effort = Medium)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class DontRepeatYourselfAttribute : CodeDocsAttribute, IPrinciples
    {

		public override Definition Definition { get { return Glossary.DontRepeatYourself; }}

		// Just Details

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
		public DontRepeatYourselfAttribute(string details) : base(details, null, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DontRepeatYourselfAttribute(string details, int yyyymmdd) : base(details, null, null, "", null, yyyymmdd){}

		// Focus on risk

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
		public DontRepeatYourselfAttribute(string details, Risk risk) : base(details, risk, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public DontRepeatYourselfAttribute(string details, Risk risk, Effort effort) : base(details, risk, effort, "", null, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DontRepeatYourselfAttribute(string details, Risk risk, int yyyymmdd) : base(details, risk, null, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DontRepeatYourselfAttribute(string details, Risk risk, Effort effort, int yyyymmdd) : base(details, risk, effort, "", null, yyyymmdd){}

		// Focus on tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public DontRepeatYourselfAttribute(string details, string tags) : base(details, null, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public DontRepeatYourselfAttribute(string details, Risk risk, string tags) : base(details, risk, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public DontRepeatYourselfAttribute(string details, Risk risk, Effort effort, string tags) : base(details, risk, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public DontRepeatYourselfAttribute(string details, string tags, string[] urls) : base(details, null, null, tags, urls, null){}

		// Add in date for tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DontRepeatYourselfAttribute(string details, string tags, int yyyymmdd) : base(details, null, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DontRepeatYourselfAttribute(string details, Risk risk, string tags, int yyyymmdd) : base(details, risk, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DontRepeatYourselfAttribute(string details, Risk risk, Effort effort, string tags, int yyyymmdd) : base(details, risk, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DontRepeatYourselfAttribute(string details, string tags, string[] urls, int yyyymmdd) : base(details, null, null, tags, urls, yyyymmdd){}

		// Add in urls

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public DontRepeatYourselfAttribute(string details, string[] urls) : base(details, null, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public DontRepeatYourselfAttribute(string details, Risk risk, string[] urls) : base(details, risk, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public DontRepeatYourselfAttribute(string details, Risk risk, Effort effort, string[] urls) : base(details, risk, effort, "", urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DontRepeatYourselfAttribute(string details, string[] urls, int yyyymmdd) : base(details, null, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DontRepeatYourselfAttribute(string details, Risk risk, string[] urls, int yyyymmdd) : base(details, risk, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DontRepeatYourselfAttribute(string details, Risk risk, Effort effort, string[] urls, int yyyymmdd) : base(details, risk, effort, "", urls, yyyymmdd){}

		// Focus on effort

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public DontRepeatYourselfAttribute(string details, Effort effort) : base(details, null, effort, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public DontRepeatYourselfAttribute(string details, Effort effort, string tags) : base(details, null, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public DontRepeatYourselfAttribute(string details, Effort effort, string[] urls) : base(details, null, effort, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public DontRepeatYourselfAttribute(string details, Effort effort, string tags, string[] urls) : base(details, null, effort, tags, urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DontRepeatYourselfAttribute(string details, Effort effort, int yyyymmdd) : base(details, null, effort, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DontRepeatYourselfAttribute(string details, Effort effort, string tags, int yyyymmdd) : base(details, null, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DontRepeatYourselfAttribute(string details, Effort effort, string[] urls, int yyyymmdd) : base(details, null, effort, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DontRepeatYourselfAttribute(string details, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, null, effort, tags, urls, yyyymmdd){}

		// Full tilt

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public DontRepeatYourselfAttribute(string details, Risk risk, Effort effort, string tags, string[] urls) : base(details, risk, effort, tags, urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public DontRepeatYourselfAttribute(string details, Risk risk, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, risk, effort, tags, urls, yyyymmdd){}

	}

    /// <summary>
    /// [Law of Demeter] A component or object shold not know about internal details of other components or objects. (Default risk = Moderate, Default effort = Medium)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class LeastKnowledgeAttribute : CodeDocsAttribute, IPrinciples
    {

		public override Definition Definition { get { return Glossary.LeastKnowledge; }}

		// Just Details

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
		public LeastKnowledgeAttribute(string details) : base(details, null, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LeastKnowledgeAttribute(string details, int yyyymmdd) : base(details, null, null, "", null, yyyymmdd){}

		// Focus on risk

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
		public LeastKnowledgeAttribute(string details, Risk risk) : base(details, risk, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public LeastKnowledgeAttribute(string details, Risk risk, Effort effort) : base(details, risk, effort, "", null, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LeastKnowledgeAttribute(string details, Risk risk, int yyyymmdd) : base(details, risk, null, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LeastKnowledgeAttribute(string details, Risk risk, Effort effort, int yyyymmdd) : base(details, risk, effort, "", null, yyyymmdd){}

		// Focus on tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public LeastKnowledgeAttribute(string details, string tags) : base(details, null, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public LeastKnowledgeAttribute(string details, Risk risk, string tags) : base(details, risk, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public LeastKnowledgeAttribute(string details, Risk risk, Effort effort, string tags) : base(details, risk, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public LeastKnowledgeAttribute(string details, string tags, string[] urls) : base(details, null, null, tags, urls, null){}

		// Add in date for tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LeastKnowledgeAttribute(string details, string tags, int yyyymmdd) : base(details, null, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LeastKnowledgeAttribute(string details, Risk risk, string tags, int yyyymmdd) : base(details, risk, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LeastKnowledgeAttribute(string details, Risk risk, Effort effort, string tags, int yyyymmdd) : base(details, risk, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LeastKnowledgeAttribute(string details, string tags, string[] urls, int yyyymmdd) : base(details, null, null, tags, urls, yyyymmdd){}

		// Add in urls

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public LeastKnowledgeAttribute(string details, string[] urls) : base(details, null, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public LeastKnowledgeAttribute(string details, Risk risk, string[] urls) : base(details, risk, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public LeastKnowledgeAttribute(string details, Risk risk, Effort effort, string[] urls) : base(details, risk, effort, "", urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LeastKnowledgeAttribute(string details, string[] urls, int yyyymmdd) : base(details, null, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LeastKnowledgeAttribute(string details, Risk risk, string[] urls, int yyyymmdd) : base(details, risk, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LeastKnowledgeAttribute(string details, Risk risk, Effort effort, string[] urls, int yyyymmdd) : base(details, risk, effort, "", urls, yyyymmdd){}

		// Focus on effort

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public LeastKnowledgeAttribute(string details, Effort effort) : base(details, null, effort, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public LeastKnowledgeAttribute(string details, Effort effort, string tags) : base(details, null, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public LeastKnowledgeAttribute(string details, Effort effort, string[] urls) : base(details, null, effort, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public LeastKnowledgeAttribute(string details, Effort effort, string tags, string[] urls) : base(details, null, effort, tags, urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LeastKnowledgeAttribute(string details, Effort effort, int yyyymmdd) : base(details, null, effort, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LeastKnowledgeAttribute(string details, Effort effort, string tags, int yyyymmdd) : base(details, null, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LeastKnowledgeAttribute(string details, Effort effort, string[] urls, int yyyymmdd) : base(details, null, effort, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LeastKnowledgeAttribute(string details, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, null, effort, tags, urls, yyyymmdd){}

		// Full tilt

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public LeastKnowledgeAttribute(string details, Risk risk, Effort effort, string tags, string[] urls) : base(details, risk, effort, tags, urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public LeastKnowledgeAttribute(string details, Risk risk, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, risk, effort, tags, urls, yyyymmdd){}

	}

    /// <summary>
    /// The path with the fewest assumptions should be selected even if other directions may eventually prove correct. (Default risk = Moderate, Default effort = Medium)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class OccamsRazorAttribute : CodeDocsAttribute, IPrinciples
    {

		public override Definition Definition { get { return Glossary.OccamsRazor; }}

		// Just Details

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
		public OccamsRazorAttribute(string details) : base(details, null, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public OccamsRazorAttribute(string details, int yyyymmdd) : base(details, null, null, "", null, yyyymmdd){}

		// Focus on risk

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
		public OccamsRazorAttribute(string details, Risk risk) : base(details, risk, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public OccamsRazorAttribute(string details, Risk risk, Effort effort) : base(details, risk, effort, "", null, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public OccamsRazorAttribute(string details, Risk risk, int yyyymmdd) : base(details, risk, null, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public OccamsRazorAttribute(string details, Risk risk, Effort effort, int yyyymmdd) : base(details, risk, effort, "", null, yyyymmdd){}

		// Focus on tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public OccamsRazorAttribute(string details, string tags) : base(details, null, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public OccamsRazorAttribute(string details, Risk risk, string tags) : base(details, risk, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public OccamsRazorAttribute(string details, Risk risk, Effort effort, string tags) : base(details, risk, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public OccamsRazorAttribute(string details, string tags, string[] urls) : base(details, null, null, tags, urls, null){}

		// Add in date for tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public OccamsRazorAttribute(string details, string tags, int yyyymmdd) : base(details, null, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public OccamsRazorAttribute(string details, Risk risk, string tags, int yyyymmdd) : base(details, risk, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public OccamsRazorAttribute(string details, Risk risk, Effort effort, string tags, int yyyymmdd) : base(details, risk, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public OccamsRazorAttribute(string details, string tags, string[] urls, int yyyymmdd) : base(details, null, null, tags, urls, yyyymmdd){}

		// Add in urls

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public OccamsRazorAttribute(string details, string[] urls) : base(details, null, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public OccamsRazorAttribute(string details, Risk risk, string[] urls) : base(details, risk, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public OccamsRazorAttribute(string details, Risk risk, Effort effort, string[] urls) : base(details, risk, effort, "", urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public OccamsRazorAttribute(string details, string[] urls, int yyyymmdd) : base(details, null, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public OccamsRazorAttribute(string details, Risk risk, string[] urls, int yyyymmdd) : base(details, risk, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public OccamsRazorAttribute(string details, Risk risk, Effort effort, string[] urls, int yyyymmdd) : base(details, risk, effort, "", urls, yyyymmdd){}

		// Focus on effort

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public OccamsRazorAttribute(string details, Effort effort) : base(details, null, effort, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public OccamsRazorAttribute(string details, Effort effort, string tags) : base(details, null, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public OccamsRazorAttribute(string details, Effort effort, string[] urls) : base(details, null, effort, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public OccamsRazorAttribute(string details, Effort effort, string tags, string[] urls) : base(details, null, effort, tags, urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public OccamsRazorAttribute(string details, Effort effort, int yyyymmdd) : base(details, null, effort, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public OccamsRazorAttribute(string details, Effort effort, string tags, int yyyymmdd) : base(details, null, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public OccamsRazorAttribute(string details, Effort effort, string[] urls, int yyyymmdd) : base(details, null, effort, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public OccamsRazorAttribute(string details, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, null, effort, tags, urls, yyyymmdd){}

		// Full tilt

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public OccamsRazorAttribute(string details, Risk risk, Effort effort, string tags, string[] urls) : base(details, risk, effort, tags, urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public OccamsRazorAttribute(string details, Risk risk, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, risk, effort, tags, urls, yyyymmdd){}

	}

    /// <summary>
    /// The design should divide areas of concern into their own distinct sections. (Default risk = Moderate, Default effort = Medium)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class SeparationOfConcernsAttribute : CodeDocsAttribute, IPrinciples
    {

		public override Definition Definition { get { return Glossary.SeparationOfConcerns; }}

		// Just Details

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
		public SeparationOfConcernsAttribute(string details) : base(details, null, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SeparationOfConcernsAttribute(string details, int yyyymmdd) : base(details, null, null, "", null, yyyymmdd){}

		// Focus on risk

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
		public SeparationOfConcernsAttribute(string details, Risk risk) : base(details, risk, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public SeparationOfConcernsAttribute(string details, Risk risk, Effort effort) : base(details, risk, effort, "", null, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SeparationOfConcernsAttribute(string details, Risk risk, int yyyymmdd) : base(details, risk, null, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SeparationOfConcernsAttribute(string details, Risk risk, Effort effort, int yyyymmdd) : base(details, risk, effort, "", null, yyyymmdd){}

		// Focus on tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public SeparationOfConcernsAttribute(string details, string tags) : base(details, null, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public SeparationOfConcernsAttribute(string details, Risk risk, string tags) : base(details, risk, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public SeparationOfConcernsAttribute(string details, Risk risk, Effort effort, string tags) : base(details, risk, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public SeparationOfConcernsAttribute(string details, string tags, string[] urls) : base(details, null, null, tags, urls, null){}

		// Add in date for tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SeparationOfConcernsAttribute(string details, string tags, int yyyymmdd) : base(details, null, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SeparationOfConcernsAttribute(string details, Risk risk, string tags, int yyyymmdd) : base(details, risk, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SeparationOfConcernsAttribute(string details, Risk risk, Effort effort, string tags, int yyyymmdd) : base(details, risk, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SeparationOfConcernsAttribute(string details, string tags, string[] urls, int yyyymmdd) : base(details, null, null, tags, urls, yyyymmdd){}

		// Add in urls

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public SeparationOfConcernsAttribute(string details, string[] urls) : base(details, null, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public SeparationOfConcernsAttribute(string details, Risk risk, string[] urls) : base(details, risk, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public SeparationOfConcernsAttribute(string details, Risk risk, Effort effort, string[] urls) : base(details, risk, effort, "", urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SeparationOfConcernsAttribute(string details, string[] urls, int yyyymmdd) : base(details, null, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SeparationOfConcernsAttribute(string details, Risk risk, string[] urls, int yyyymmdd) : base(details, risk, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SeparationOfConcernsAttribute(string details, Risk risk, Effort effort, string[] urls, int yyyymmdd) : base(details, risk, effort, "", urls, yyyymmdd){}

		// Focus on effort

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public SeparationOfConcernsAttribute(string details, Effort effort) : base(details, null, effort, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public SeparationOfConcernsAttribute(string details, Effort effort, string tags) : base(details, null, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public SeparationOfConcernsAttribute(string details, Effort effort, string[] urls) : base(details, null, effort, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public SeparationOfConcernsAttribute(string details, Effort effort, string tags, string[] urls) : base(details, null, effort, tags, urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SeparationOfConcernsAttribute(string details, Effort effort, int yyyymmdd) : base(details, null, effort, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SeparationOfConcernsAttribute(string details, Effort effort, string tags, int yyyymmdd) : base(details, null, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SeparationOfConcernsAttribute(string details, Effort effort, string[] urls, int yyyymmdd) : base(details, null, effort, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SeparationOfConcernsAttribute(string details, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, null, effort, tags, urls, yyyymmdd){}

		// Full tilt

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public SeparationOfConcernsAttribute(string details, Risk risk, Effort effort, string tags, string[] urls) : base(details, risk, effort, tags, urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public SeparationOfConcernsAttribute(string details, Risk risk, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, risk, effort, tags, urls, yyyymmdd){}

	}

    /// <summary>
    /// Always implement things when you actually need them, never when you just foresee that you need them. (Default risk = Moderate, Default effort = Medium)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class YouArentGonnaNeedItAttribute : CodeDocsAttribute, IPrinciples
    {

		public override Definition Definition { get { return Glossary.YouArentGonnaNeedIt; }}

		// Just Details

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
		public YouArentGonnaNeedItAttribute(string details) : base(details, null, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public YouArentGonnaNeedItAttribute(string details, int yyyymmdd) : base(details, null, null, "", null, yyyymmdd){}

		// Focus on risk

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
		public YouArentGonnaNeedItAttribute(string details, Risk risk) : base(details, risk, null, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public YouArentGonnaNeedItAttribute(string details, Risk risk, Effort effort) : base(details, risk, effort, "", null, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public YouArentGonnaNeedItAttribute(string details, Risk risk, int yyyymmdd) : base(details, risk, null, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public YouArentGonnaNeedItAttribute(string details, Risk risk, Effort effort, int yyyymmdd) : base(details, risk, effort, "", null, yyyymmdd){}

		// Focus on tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public YouArentGonnaNeedItAttribute(string details, string tags) : base(details, null, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public YouArentGonnaNeedItAttribute(string details, Risk risk, string tags) : base(details, risk, null, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public YouArentGonnaNeedItAttribute(string details, Risk risk, Effort effort, string tags) : base(details, risk, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public YouArentGonnaNeedItAttribute(string details, string tags, string[] urls) : base(details, null, null, tags, urls, null){}

		// Add in date for tags

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public YouArentGonnaNeedItAttribute(string details, string tags, int yyyymmdd) : base(details, null, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public YouArentGonnaNeedItAttribute(string details, Risk risk, string tags, int yyyymmdd) : base(details, risk, null, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public YouArentGonnaNeedItAttribute(string details, Risk risk, Effort effort, string tags, int yyyymmdd) : base(details, risk, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public YouArentGonnaNeedItAttribute(string details, string tags, string[] urls, int yyyymmdd) : base(details, null, null, tags, urls, yyyymmdd){}

		// Add in urls

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public YouArentGonnaNeedItAttribute(string details, string[] urls) : base(details, null, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public YouArentGonnaNeedItAttribute(string details, Risk risk, string[] urls) : base(details, risk, null, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public YouArentGonnaNeedItAttribute(string details, Risk risk, Effort effort, string[] urls) : base(details, risk, effort, "", urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public YouArentGonnaNeedItAttribute(string details, string[] urls, int yyyymmdd) : base(details, null, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public YouArentGonnaNeedItAttribute(string details, Risk risk, string[] urls, int yyyymmdd) : base(details, risk, null, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public YouArentGonnaNeedItAttribute(string details, Risk risk, Effort effort, string[] urls, int yyyymmdd) : base(details, risk, effort, "", urls, yyyymmdd){}

		// Focus on effort

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
		public YouArentGonnaNeedItAttribute(string details, Effort effort) : base(details, null, effort, "", null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public YouArentGonnaNeedItAttribute(string details, Effort effort, string tags) : base(details, null, effort, tags, null, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public YouArentGonnaNeedItAttribute(string details, Effort effort, string[] urls) : base(details, null, effort, "", urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public YouArentGonnaNeedItAttribute(string details, Effort effort, string tags, string[] urls) : base(details, null, effort, tags, urls, null){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public YouArentGonnaNeedItAttribute(string details, Effort effort, int yyyymmdd) : base(details, null, effort, "", null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public YouArentGonnaNeedItAttribute(string details, Effort effort, string tags, int yyyymmdd) : base(details, null, effort, tags, null, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public YouArentGonnaNeedItAttribute(string details, Effort effort, string[] urls, int yyyymmdd) : base(details, null, effort, "", urls, yyyymmdd){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public YouArentGonnaNeedItAttribute(string details, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, null, effort, tags, urls, yyyymmdd){}

		// Full tilt

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public YouArentGonnaNeedItAttribute(string details, Risk risk, Effort effort, string tags, string[] urls) : base(details, risk, effort, tags, urls, null){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
		public YouArentGonnaNeedItAttribute(string details, Risk risk, Effort effort, string tags, string[] urls, int yyyymmdd) : base(details, risk, effort, tags, urls, yyyymmdd){}

	}
}
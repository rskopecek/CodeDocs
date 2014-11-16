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
    /// Used to acknowledge and identify code that has a live issue even though a resolution has not been identified or implemented. (Defaults: Risk.Extreme, Effort.Unknown)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class BugAttribute : CodeDocsAttribute, IDegredation
    {

		public override Definition Definition { get { return Glossary.Bug; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public BugAttribute(string details, params string[] tagsAndReferences) : base(details, null, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public BugAttribute(string details, Risk risk, params string[] tagsAndReferences) : base(details, risk, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public BugAttribute(string details, Effort effort, params string[] tagsAndReferences) : base(details, null, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public BugAttribute(string details, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public BugAttribute(string details, Risk risk, Effort effort, params string[] tagsAndReferences) : base(details, risk, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public BugAttribute(string details, Risk risk, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public BugAttribute(string details, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, effort, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public BugAttribute(string details, Risk risk, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, effort, yyyymmdd, tagsAndReferences){}

	}

    /// <summary>
    /// Identification of a major fix that is important to communicate and potentially worthy of moving the [incr] version # forward if any exist during deployment (major.minor.incr). (Defaults: Risk.None, Effort.None)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class MajorFixAttribute : CodeDocsAttribute, IChange, IMajor, IFix
    {

		public override Definition Definition { get { return Glossary.MajorFix; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public MajorFixAttribute(string details, params string[] tagsAndReferences) : base(details, null, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public MajorFixAttribute(string details, Risk risk, params string[] tagsAndReferences) : base(details, risk, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public MajorFixAttribute(string details, Effort effort, params string[] tagsAndReferences) : base(details, null, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public MajorFixAttribute(string details, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public MajorFixAttribute(string details, Risk risk, Effort effort, params string[] tagsAndReferences) : base(details, risk, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public MajorFixAttribute(string details, Risk risk, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public MajorFixAttribute(string details, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, effort, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public MajorFixAttribute(string details, Risk risk, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, effort, yyyymmdd, tagsAndReferences){}

	}

    /// <summary>
    /// Identification of a minor fix that is important to communicate and potentially worthy of moving the [incr] version # forward if any exist during deployment (major.minor.incr). (Defaults: Risk.None, Effort.None)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class MinorFixAttribute : CodeDocsAttribute, IChange, IMinor, IFix
    {

		public override Definition Definition { get { return Glossary.MinorFix; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public MinorFixAttribute(string details, params string[] tagsAndReferences) : base(details, null, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public MinorFixAttribute(string details, Risk risk, params string[] tagsAndReferences) : base(details, risk, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public MinorFixAttribute(string details, Effort effort, params string[] tagsAndReferences) : base(details, null, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public MinorFixAttribute(string details, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public MinorFixAttribute(string details, Risk risk, Effort effort, params string[] tagsAndReferences) : base(details, risk, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public MinorFixAttribute(string details, Risk risk, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public MinorFixAttribute(string details, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, effort, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public MinorFixAttribute(string details, Risk risk, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, effort, yyyymmdd, tagsAndReferences){}

	}

    /// <summary>
    /// A piece of code that is slower than desired and need refactored. (Defaults: Risk.Moderate, Effort.Medium)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class SlowAttribute : CodeDocsAttribute, IPerformance, IDegredation
    {

		public override Definition Definition { get { return Glossary.Slow; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public SlowAttribute(string details, params string[] tagsAndReferences) : base(details, null, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public SlowAttribute(string details, Risk risk, params string[] tagsAndReferences) : base(details, risk, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public SlowAttribute(string details, Effort effort, params string[] tagsAndReferences) : base(details, null, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public SlowAttribute(string details, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public SlowAttribute(string details, Risk risk, Effort effort, params string[] tagsAndReferences) : base(details, risk, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public SlowAttribute(string details, Risk risk, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public SlowAttribute(string details, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, effort, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public SlowAttribute(string details, Risk risk, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, effort, yyyymmdd, tagsAndReferences){}

	}

    /// <summary>
    /// Uncompleted feature. (Defaults: Risk.Extreme, Effort.Medium)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class TodoAttribute : CodeDocsAttribute, IWork
    {

		public override Definition Definition { get { return Glossary.Todo; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public TodoAttribute(string details, params string[] tagsAndReferences) : base(details, null, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public TodoAttribute(string details, Risk risk, params string[] tagsAndReferences) : base(details, risk, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public TodoAttribute(string details, Effort effort, params string[] tagsAndReferences) : base(details, null, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public TodoAttribute(string details, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public TodoAttribute(string details, Risk risk, Effort effort, params string[] tagsAndReferences) : base(details, risk, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public TodoAttribute(string details, Risk risk, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public TodoAttribute(string details, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, effort, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public TodoAttribute(string details, Risk risk, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, effort, yyyymmdd, tagsAndReferences){}

	}

    /// <summary>
    /// A note about security in relation to the context, not necessarily a risk. (Defaults: Risk.None, Effort.None)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class SecurityAttribute : CodeDocsAttribute, ISecurity
    {

		public override Definition Definition { get { return Glossary.Security; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public SecurityAttribute(string details, params string[] tagsAndReferences) : base(details, null, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public SecurityAttribute(string details, Risk risk, params string[] tagsAndReferences) : base(details, risk, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public SecurityAttribute(string details, Effort effort, params string[] tagsAndReferences) : base(details, null, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public SecurityAttribute(string details, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public SecurityAttribute(string details, Risk risk, Effort effort, params string[] tagsAndReferences) : base(details, risk, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public SecurityAttribute(string details, Risk risk, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public SecurityAttribute(string details, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, effort, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public SecurityAttribute(string details, Risk risk, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, effort, yyyymmdd, tagsAndReferences){}

	}

    /// <summary>
    /// An identified security issue. (Defaults: Risk.Extreme, Effort.Unknown)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class InSecureAttribute : CodeDocsAttribute, ISecurity, IInSecure, IDegredation
    {

		public override Definition Definition { get { return Glossary.InSecure; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public InSecureAttribute(string details, params string[] tagsAndReferences) : base(details, null, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public InSecureAttribute(string details, Risk risk, params string[] tagsAndReferences) : base(details, risk, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public InSecureAttribute(string details, Effort effort, params string[] tagsAndReferences) : base(details, null, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public InSecureAttribute(string details, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public InSecureAttribute(string details, Risk risk, Effort effort, params string[] tagsAndReferences) : base(details, risk, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public InSecureAttribute(string details, Risk risk, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public InSecureAttribute(string details, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, effort, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public InSecureAttribute(string details, Risk risk, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, effort, yyyymmdd, tagsAndReferences){}

	}

    /// <summary>
    /// A piece of code that is extremely tempermental, developers should be cautioned, and refactoring is required. (Defaults: Risk.Extreme, Effort.Unknown)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class ToxicAttribute : CodeDocsAttribute, IToxic, IDegredation
    {

		public override Definition Definition { get { return Glossary.Toxic; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ToxicAttribute(string details, params string[] tagsAndReferences) : base(details, null, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ToxicAttribute(string details, Risk risk, params string[] tagsAndReferences) : base(details, risk, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ToxicAttribute(string details, Effort effort, params string[] tagsAndReferences) : base(details, null, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ToxicAttribute(string details, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ToxicAttribute(string details, Risk risk, Effort effort, params string[] tagsAndReferences) : base(details, risk, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ToxicAttribute(string details, Risk risk, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ToxicAttribute(string details, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, effort, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ToxicAttribute(string details, Risk risk, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, effort, yyyymmdd, tagsAndReferences){}

	}

    /// <summary>
    /// A side-effect that may occur either by the behavior of the code or if a change is made to the code. (Defaults: Risk.Moderate, Effort.Unknown)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class ConsequenceAttribute : CodeDocsAttribute, IConsequence
    {

		public override Definition Definition { get { return Glossary.Consequence; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ConsequenceAttribute(string details, params string[] tagsAndReferences) : base(details, null, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ConsequenceAttribute(string details, Risk risk, params string[] tagsAndReferences) : base(details, risk, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ConsequenceAttribute(string details, Effort effort, params string[] tagsAndReferences) : base(details, null, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ConsequenceAttribute(string details, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ConsequenceAttribute(string details, Risk risk, Effort effort, params string[] tagsAndReferences) : base(details, risk, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ConsequenceAttribute(string details, Risk risk, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ConsequenceAttribute(string details, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, effort, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ConsequenceAttribute(string details, Risk risk, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, effort, yyyymmdd, tagsAndReferences){}

	}

    /// <summary>
    /// Typically code that is commented out or code that exists but is never used. (Defaults: Risk.Low, Effort.VerySmall)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class DeadCodeAttribute : CodeDocsAttribute, IDeadCode
    {

		public override Definition Definition { get { return Glossary.DeadCode; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public DeadCodeAttribute(string details, params string[] tagsAndReferences) : base(details, null, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public DeadCodeAttribute(string details, Risk risk, params string[] tagsAndReferences) : base(details, risk, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public DeadCodeAttribute(string details, Effort effort, params string[] tagsAndReferences) : base(details, null, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public DeadCodeAttribute(string details, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public DeadCodeAttribute(string details, Risk risk, Effort effort, params string[] tagsAndReferences) : base(details, risk, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public DeadCodeAttribute(string details, Risk risk, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public DeadCodeAttribute(string details, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, effort, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public DeadCodeAttribute(string details, Risk risk, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, effort, yyyymmdd, tagsAndReferences){}

	}

    /// <summary>
    /// Test scenario that appears to be missing. (Defaults: Risk.Extreme, Effort.Small)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class TestAttribute : CodeDocsAttribute, IDegredation
    {

		public override Definition Definition { get { return Glossary.Test; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public TestAttribute(string details, params string[] tagsAndReferences) : base(details, null, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public TestAttribute(string details, Risk risk, params string[] tagsAndReferences) : base(details, risk, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public TestAttribute(string details, Effort effort, params string[] tagsAndReferences) : base(details, null, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public TestAttribute(string details, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public TestAttribute(string details, Risk risk, Effort effort, params string[] tagsAndReferences) : base(details, risk, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public TestAttribute(string details, Risk risk, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public TestAttribute(string details, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, effort, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public TestAttribute(string details, Risk risk, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, effort, yyyymmdd, tagsAndReferences){}

	}

    /// <summary>
    /// Used to identify external resources (like StakeOverflow, blogs, etc) that would add value to the context this attribute is applied to. (Defaults: Risk.None, Effort.None)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class CiteAttribute : CodeDocsAttribute, IMeaning
    {

		public override Definition Definition { get { return Glossary.Cite; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public CiteAttribute(string details, params string[] tagsAndReferences) : base(details, null, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public CiteAttribute(string details, Risk risk, params string[] tagsAndReferences) : base(details, risk, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public CiteAttribute(string details, Effort effort, params string[] tagsAndReferences) : base(details, null, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public CiteAttribute(string details, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public CiteAttribute(string details, Risk risk, Effort effort, params string[] tagsAndReferences) : base(details, risk, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public CiteAttribute(string details, Risk risk, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public CiteAttribute(string details, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, effort, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public CiteAttribute(string details, Risk risk, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, effort, yyyymmdd, tagsAndReferences){}

	}

    /// <summary>
    /// A distinctive function/attribute about what the application does. (Defaults: Risk.None, Effort.None)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class FeatureAttribute : CodeDocsAttribute, IFeature
    {

		public override Definition Definition { get { return Glossary.Feature; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public FeatureAttribute(string details, params string[] tagsAndReferences) : base(details, null, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public FeatureAttribute(string details, Risk risk, params string[] tagsAndReferences) : base(details, risk, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public FeatureAttribute(string details, Effort effort, params string[] tagsAndReferences) : base(details, null, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public FeatureAttribute(string details, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public FeatureAttribute(string details, Risk risk, Effort effort, params string[] tagsAndReferences) : base(details, risk, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public FeatureAttribute(string details, Risk risk, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public FeatureAttribute(string details, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, effort, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public FeatureAttribute(string details, Risk risk, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, effort, yyyymmdd, tagsAndReferences){}

	}

    /// <summary>
    /// Identification of a major change that is important to communicate and potentially worthy of moving the version # forward if any exist during deployment (major.minor.incr). (Defaults: Risk.None, Effort.None)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class MajorChangeAttribute : CodeDocsAttribute, IChange, IMajor
    {

		public override Definition Definition { get { return Glossary.MajorChange; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public MajorChangeAttribute(string details, params string[] tagsAndReferences) : base(details, null, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public MajorChangeAttribute(string details, Risk risk, params string[] tagsAndReferences) : base(details, risk, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public MajorChangeAttribute(string details, Effort effort, params string[] tagsAndReferences) : base(details, null, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public MajorChangeAttribute(string details, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public MajorChangeAttribute(string details, Risk risk, Effort effort, params string[] tagsAndReferences) : base(details, risk, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public MajorChangeAttribute(string details, Risk risk, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public MajorChangeAttribute(string details, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, effort, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public MajorChangeAttribute(string details, Risk risk, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, effort, yyyymmdd, tagsAndReferences){}

	}

    /// <summary>
    /// Identification of a minor change that is important to communicate and potentially worthy of moving the version # forward if any exist during deployment (major.minor.incr). (Defaults: Risk.None, Effort.None)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class MinorChangeAttribute : CodeDocsAttribute, IChange, IMinor
    {

		public override Definition Definition { get { return Glossary.MinorChange; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public MinorChangeAttribute(string details, params string[] tagsAndReferences) : base(details, null, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public MinorChangeAttribute(string details, Risk risk, params string[] tagsAndReferences) : base(details, risk, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public MinorChangeAttribute(string details, Effort effort, params string[] tagsAndReferences) : base(details, null, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public MinorChangeAttribute(string details, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public MinorChangeAttribute(string details, Risk risk, Effort effort, params string[] tagsAndReferences) : base(details, risk, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public MinorChangeAttribute(string details, Risk risk, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public MinorChangeAttribute(string details, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, effort, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public MinorChangeAttribute(string details, Risk risk, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, effort, yyyymmdd, tagsAndReferences){}

	}

    /// <summary>
    /// Intent is clear.  However, naming could be cleaner. (Defaults: Risk.Low, Effort.Small)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class NamingAttribute : CodeDocsAttribute, IMeaning
    {

		public override Definition Definition { get { return Glossary.Naming; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public NamingAttribute(string details, params string[] tagsAndReferences) : base(details, null, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public NamingAttribute(string details, Risk risk, params string[] tagsAndReferences) : base(details, risk, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public NamingAttribute(string details, Effort effort, params string[] tagsAndReferences) : base(details, null, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public NamingAttribute(string details, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public NamingAttribute(string details, Risk risk, Effort effort, params string[] tagsAndReferences) : base(details, risk, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public NamingAttribute(string details, Risk risk, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public NamingAttribute(string details, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, effort, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public NamingAttribute(string details, Risk risk, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, effort, yyyymmdd, tagsAndReferences){}

	}

    /// <summary>
    /// Hard to read at first glance for one or more people. (Defaults: Risk.Low, Effort.Small)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class ReadabilityAttribute : CodeDocsAttribute, IMeaning
    {

		public override Definition Definition { get { return Glossary.Readability; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ReadabilityAttribute(string details, params string[] tagsAndReferences) : base(details, null, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ReadabilityAttribute(string details, Risk risk, params string[] tagsAndReferences) : base(details, risk, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ReadabilityAttribute(string details, Effort effort, params string[] tagsAndReferences) : base(details, null, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ReadabilityAttribute(string details, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ReadabilityAttribute(string details, Risk risk, Effort effort, params string[] tagsAndReferences) : base(details, risk, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ReadabilityAttribute(string details, Risk risk, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ReadabilityAttribute(string details, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, effort, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ReadabilityAttribute(string details, Risk risk, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, effort, yyyymmdd, tagsAndReferences){}

	}

    /// <summary>
    /// Piece of code that appears to be in the wrong place. (Defaults: Risk.Low, Effort.Unknown)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class LocationAttribute : CodeDocsAttribute, IMeaning
    {

		public override Definition Definition { get { return Glossary.Location; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public LocationAttribute(string details, params string[] tagsAndReferences) : base(details, null, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public LocationAttribute(string details, Risk risk, params string[] tagsAndReferences) : base(details, risk, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public LocationAttribute(string details, Effort effort, params string[] tagsAndReferences) : base(details, null, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public LocationAttribute(string details, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public LocationAttribute(string details, Risk risk, Effort effort, params string[] tagsAndReferences) : base(details, risk, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public LocationAttribute(string details, Risk risk, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public LocationAttribute(string details, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, effort, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public LocationAttribute(string details, Risk risk, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, effort, yyyymmdd, tagsAndReferences){}

	}

    /// <summary>
    /// A piece of code that needs refactored to adhere to code/design standards. (Defaults: Risk.Low, Effort.VerySmall)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class StandardsAttribute : CodeDocsAttribute, IStandards
    {

		public override Definition Definition { get { return Glossary.Standards; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public StandardsAttribute(string details, params string[] tagsAndReferences) : base(details, null, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public StandardsAttribute(string details, Risk risk, params string[] tagsAndReferences) : base(details, risk, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public StandardsAttribute(string details, Effort effort, params string[] tagsAndReferences) : base(details, null, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public StandardsAttribute(string details, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public StandardsAttribute(string details, Risk risk, Effort effort, params string[] tagsAndReferences) : base(details, risk, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public StandardsAttribute(string details, Risk risk, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public StandardsAttribute(string details, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, effort, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public StandardsAttribute(string details, Risk risk, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, effort, yyyymmdd, tagsAndReferences){}

	}

    /// <summary>
    /// Working feature.  Requires refactoring due to shortcuts needed to make it work. (Defaults: Risk.Moderate, Effort.Unknown)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class HackAttribute : CodeDocsAttribute, IDegredation
    {

		public override Definition Definition { get { return Glossary.Hack; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public HackAttribute(string details, params string[] tagsAndReferences) : base(details, null, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public HackAttribute(string details, Risk risk, params string[] tagsAndReferences) : base(details, risk, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public HackAttribute(string details, Effort effort, params string[] tagsAndReferences) : base(details, null, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public HackAttribute(string details, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public HackAttribute(string details, Risk risk, Effort effort, params string[] tagsAndReferences) : base(details, risk, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public HackAttribute(string details, Risk risk, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public HackAttribute(string details, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, effort, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public HackAttribute(string details, Risk risk, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, effort, yyyymmdd, tagsAndReferences){}

	}

    /// <summary>
    /// Working feature that needs improvement. (Defaults: Risk.Low, Effort.Unknown)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class RefactorAttribute : CodeDocsAttribute, IDegredation
    {

		public override Definition Definition { get { return Glossary.Refactor; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public RefactorAttribute(string details, params string[] tagsAndReferences) : base(details, null, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public RefactorAttribute(string details, Risk risk, params string[] tagsAndReferences) : base(details, risk, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public RefactorAttribute(string details, Effort effort, params string[] tagsAndReferences) : base(details, null, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public RefactorAttribute(string details, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public RefactorAttribute(string details, Risk risk, Effort effort, params string[] tagsAndReferences) : base(details, risk, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public RefactorAttribute(string details, Risk risk, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public RefactorAttribute(string details, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, effort, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public RefactorAttribute(string details, Risk risk, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, effort, yyyymmdd, tagsAndReferences){}

	}

    /// <summary>
    /// Readable, but missing a 'good to know' for people trying to understand. (Defaults: Risk.Low, Effort.VerySmall)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class ClarificationAttribute : CodeDocsAttribute, IMeaning
    {

		public override Definition Definition { get { return Glossary.Clarification; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ClarificationAttribute(string details, params string[] tagsAndReferences) : base(details, null, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ClarificationAttribute(string details, Risk risk, params string[] tagsAndReferences) : base(details, risk, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ClarificationAttribute(string details, Effort effort, params string[] tagsAndReferences) : base(details, null, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ClarificationAttribute(string details, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ClarificationAttribute(string details, Risk risk, Effort effort, params string[] tagsAndReferences) : base(details, risk, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ClarificationAttribute(string details, Risk risk, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ClarificationAttribute(string details, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, effort, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ClarificationAttribute(string details, Risk risk, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, effort, yyyymmdd, tagsAndReferences){}

	}

    /// <summary>
    /// Unsure of actual intent. (Defaults: Risk.Moderate, Effort.Medium)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class PurposeAttribute : CodeDocsAttribute, IMeaning
    {

		public override Definition Definition { get { return Glossary.Purpose; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public PurposeAttribute(string details, params string[] tagsAndReferences) : base(details, null, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public PurposeAttribute(string details, Risk risk, params string[] tagsAndReferences) : base(details, risk, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public PurposeAttribute(string details, Effort effort, params string[] tagsAndReferences) : base(details, null, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public PurposeAttribute(string details, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public PurposeAttribute(string details, Risk risk, Effort effort, params string[] tagsAndReferences) : base(details, risk, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public PurposeAttribute(string details, Risk risk, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public PurposeAttribute(string details, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, effort, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public PurposeAttribute(string details, Risk risk, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, effort, yyyymmdd, tagsAndReferences){}

	}

    /// <summary>
    /// A potential future scenario, in which this will need to be changed or these are some insights about the change. (Defaults: Risk.Low, Effort.None)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class FutureAttribute : CodeDocsAttribute, IWork, IFuture
    {

		public override Definition Definition { get { return Glossary.Future; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public FutureAttribute(string details, params string[] tagsAndReferences) : base(details, null, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public FutureAttribute(string details, Risk risk, params string[] tagsAndReferences) : base(details, risk, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public FutureAttribute(string details, Effort effort, params string[] tagsAndReferences) : base(details, null, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public FutureAttribute(string details, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public FutureAttribute(string details, Risk risk, Effort effort, params string[] tagsAndReferences) : base(details, risk, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public FutureAttribute(string details, Risk risk, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public FutureAttribute(string details, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, effort, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public FutureAttribute(string details, Risk risk, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, effort, yyyymmdd, tagsAndReferences){}

	}

    /// <summary>
    /// [The S in SOLID] Each context of code should do one thing and thus have only one reason to change. (Defaults: Risk.Moderate, Effort.Medium)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class SingleResponsibilityAttribute : CodeDocsAttribute, IPrinciples, ISOLID
    {

		public override Definition Definition { get { return Glossary.SingleResponsibility; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public SingleResponsibilityAttribute(string details, params string[] tagsAndReferences) : base(details, null, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public SingleResponsibilityAttribute(string details, Risk risk, params string[] tagsAndReferences) : base(details, risk, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public SingleResponsibilityAttribute(string details, Effort effort, params string[] tagsAndReferences) : base(details, null, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public SingleResponsibilityAttribute(string details, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public SingleResponsibilityAttribute(string details, Risk risk, Effort effort, params string[] tagsAndReferences) : base(details, risk, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public SingleResponsibilityAttribute(string details, Risk risk, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public SingleResponsibilityAttribute(string details, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, effort, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public SingleResponsibilityAttribute(string details, Risk risk, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, effort, yyyymmdd, tagsAndReferences){}

	}

    /// <summary>
    /// [The O in SOLID] Software entities should be open for extension, but closed for modification. (Defaults: Risk.Moderate, Effort.Medium)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class OpenClosedAttribute : CodeDocsAttribute, IPrinciples, ISOLID
    {

		public override Definition Definition { get { return Glossary.OpenClosed; }}

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

    /// <summary>
    /// [The L in SOLID] Objects in a program should be replaceable with instances of their subtypes without altering the correctness of that program. (Defaults: Risk.Moderate, Effort.Medium)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class LiskovSubstitutionAttribute : CodeDocsAttribute, IPrinciples, ISOLID
    {

		public override Definition Definition { get { return Glossary.LiskovSubstitution; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public LiskovSubstitutionAttribute(string details, params string[] tagsAndReferences) : base(details, null, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public LiskovSubstitutionAttribute(string details, Risk risk, params string[] tagsAndReferences) : base(details, risk, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public LiskovSubstitutionAttribute(string details, Effort effort, params string[] tagsAndReferences) : base(details, null, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public LiskovSubstitutionAttribute(string details, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public LiskovSubstitutionAttribute(string details, Risk risk, Effort effort, params string[] tagsAndReferences) : base(details, risk, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public LiskovSubstitutionAttribute(string details, Risk risk, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public LiskovSubstitutionAttribute(string details, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, effort, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public LiskovSubstitutionAttribute(string details, Risk risk, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, effort, yyyymmdd, tagsAndReferences){}

	}

    /// <summary>
    /// [The I in SOLID] Many client-specific interfaces are better than one general-purpose interface. (Defaults: Risk.Moderate, Effort.Medium)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class InterfaceSegregationAttribute : CodeDocsAttribute, IPrinciples, ISOLID
    {

		public override Definition Definition { get { return Glossary.InterfaceSegregation; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public InterfaceSegregationAttribute(string details, params string[] tagsAndReferences) : base(details, null, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public InterfaceSegregationAttribute(string details, Risk risk, params string[] tagsAndReferences) : base(details, risk, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public InterfaceSegregationAttribute(string details, Effort effort, params string[] tagsAndReferences) : base(details, null, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public InterfaceSegregationAttribute(string details, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public InterfaceSegregationAttribute(string details, Risk risk, Effort effort, params string[] tagsAndReferences) : base(details, risk, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public InterfaceSegregationAttribute(string details, Risk risk, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public InterfaceSegregationAttribute(string details, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, effort, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public InterfaceSegregationAttribute(string details, Risk risk, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, effort, yyyymmdd, tagsAndReferences){}

	}

    /// <summary>
    /// [The D in SOLID] Depend upon Abstractions. Do not depend upon concretions. (Defaults: Risk.Moderate, Effort.Medium)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class DependancyInversionAttribute : CodeDocsAttribute, IPrinciples
    {

		public override Definition Definition { get { return Glossary.DependancyInversion; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public DependancyInversionAttribute(string details, params string[] tagsAndReferences) : base(details, null, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public DependancyInversionAttribute(string details, Risk risk, params string[] tagsAndReferences) : base(details, risk, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public DependancyInversionAttribute(string details, Effort effort, params string[] tagsAndReferences) : base(details, null, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public DependancyInversionAttribute(string details, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public DependancyInversionAttribute(string details, Risk risk, Effort effort, params string[] tagsAndReferences) : base(details, risk, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public DependancyInversionAttribute(string details, Risk risk, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public DependancyInversionAttribute(string details, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, effort, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public DependancyInversionAttribute(string details, Risk risk, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, effort, yyyymmdd, tagsAndReferences){}

	}

    /// <summary>
    /// (DRY) Every piece of knowledge must have a single, unambiguous, authoritative representation within a system. (Defaults: Risk.Moderate, Effort.Medium)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class DontRepeatYourselfAttribute : CodeDocsAttribute, IPrinciples
    {

		public override Definition Definition { get { return Glossary.DontRepeatYourself; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public DontRepeatYourselfAttribute(string details, params string[] tagsAndReferences) : base(details, null, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public DontRepeatYourselfAttribute(string details, Risk risk, params string[] tagsAndReferences) : base(details, risk, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public DontRepeatYourselfAttribute(string details, Effort effort, params string[] tagsAndReferences) : base(details, null, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public DontRepeatYourselfAttribute(string details, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public DontRepeatYourselfAttribute(string details, Risk risk, Effort effort, params string[] tagsAndReferences) : base(details, risk, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public DontRepeatYourselfAttribute(string details, Risk risk, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public DontRepeatYourselfAttribute(string details, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, effort, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public DontRepeatYourselfAttribute(string details, Risk risk, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, effort, yyyymmdd, tagsAndReferences){}

	}

    /// <summary>
    /// [Law of Demeter] A component or object shold not know about internal details of other components or objects. (Defaults: Risk.Moderate, Effort.Medium)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class LeastKnowledgeAttribute : CodeDocsAttribute, IPrinciples
    {

		public override Definition Definition { get { return Glossary.LeastKnowledge; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public LeastKnowledgeAttribute(string details, params string[] tagsAndReferences) : base(details, null, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public LeastKnowledgeAttribute(string details, Risk risk, params string[] tagsAndReferences) : base(details, risk, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public LeastKnowledgeAttribute(string details, Effort effort, params string[] tagsAndReferences) : base(details, null, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public LeastKnowledgeAttribute(string details, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public LeastKnowledgeAttribute(string details, Risk risk, Effort effort, params string[] tagsAndReferences) : base(details, risk, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public LeastKnowledgeAttribute(string details, Risk risk, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public LeastKnowledgeAttribute(string details, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, effort, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public LeastKnowledgeAttribute(string details, Risk risk, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, effort, yyyymmdd, tagsAndReferences){}

	}

    /// <summary>
    /// The path with the fewest assumptions should be selected even if other directions may eventually prove correct. (Defaults: Risk.Moderate, Effort.Medium)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class OccamsRazorAttribute : CodeDocsAttribute, IPrinciples
    {

		public override Definition Definition { get { return Glossary.OccamsRazor; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public OccamsRazorAttribute(string details, params string[] tagsAndReferences) : base(details, null, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public OccamsRazorAttribute(string details, Risk risk, params string[] tagsAndReferences) : base(details, risk, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public OccamsRazorAttribute(string details, Effort effort, params string[] tagsAndReferences) : base(details, null, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public OccamsRazorAttribute(string details, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public OccamsRazorAttribute(string details, Risk risk, Effort effort, params string[] tagsAndReferences) : base(details, risk, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public OccamsRazorAttribute(string details, Risk risk, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public OccamsRazorAttribute(string details, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, effort, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public OccamsRazorAttribute(string details, Risk risk, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, effort, yyyymmdd, tagsAndReferences){}

	}

    /// <summary>
    /// The design should divide areas of concern into their own distinct sections. (Defaults: Risk.Moderate, Effort.Medium)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class SeparationOfConcernsAttribute : CodeDocsAttribute, IPrinciples
    {

		public override Definition Definition { get { return Glossary.SeparationOfConcerns; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public SeparationOfConcernsAttribute(string details, params string[] tagsAndReferences) : base(details, null, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public SeparationOfConcernsAttribute(string details, Risk risk, params string[] tagsAndReferences) : base(details, risk, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public SeparationOfConcernsAttribute(string details, Effort effort, params string[] tagsAndReferences) : base(details, null, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public SeparationOfConcernsAttribute(string details, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public SeparationOfConcernsAttribute(string details, Risk risk, Effort effort, params string[] tagsAndReferences) : base(details, risk, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public SeparationOfConcernsAttribute(string details, Risk risk, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public SeparationOfConcernsAttribute(string details, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, effort, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public SeparationOfConcernsAttribute(string details, Risk risk, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, effort, yyyymmdd, tagsAndReferences){}

	}

    /// <summary>
    /// Always implement things when you actually need them, never when you just foresee that you need them. (Defaults: Risk.Moderate, Effort.Medium)
    /// </summary>
	[AttributeUsage(Constants.AttributeScope, AllowMultiple = true, Inherited = false)]
    public class YouArentGonnaNeedItAttribute : CodeDocsAttribute, IPrinciples
    {

		public override Definition Definition { get { return Glossary.YouArentGonnaNeedIt; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public YouArentGonnaNeedItAttribute(string details, params string[] tagsAndReferences) : base(details, null, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public YouArentGonnaNeedItAttribute(string details, Risk risk, params string[] tagsAndReferences) : base(details, risk, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public YouArentGonnaNeedItAttribute(string details, Effort effort, params string[] tagsAndReferences) : base(details, null, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public YouArentGonnaNeedItAttribute(string details, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public YouArentGonnaNeedItAttribute(string details, Risk risk, Effort effort, params string[] tagsAndReferences) : base(details, risk, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public YouArentGonnaNeedItAttribute(string details, Risk risk, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public YouArentGonnaNeedItAttribute(string details, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, effort, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public YouArentGonnaNeedItAttribute(string details, Risk risk, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, effort, yyyymmdd, tagsAndReferences){}

	}
}
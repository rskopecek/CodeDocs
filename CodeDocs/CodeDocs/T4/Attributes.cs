
using System;

namespace CodeDocs
{

	// Functional


    /// <summary>
    /// Used to acknowledge and identify code that has a live issue even though a resolution has not been identified or implemented. (Defaults: Risk.Extreme, Effort.Unknown)
    /// </summary>
	[AttributeUsage(Constants.Scope, AllowMultiple = true, Inherited = false)]
    public sealed class BugAttribute : CodeDocsAttribute, IFunctionalGroup, IDegredationTag, IExtremeRiskTag, IUnknownEffortTag
    {

		/// <summary>
		/// Access to the definition used to generate this attribute (provided by the CodeDocs.Glossary static object)
		/// </summary>
		public override IDefinition Definition { get { return Glossary.Bug; }}

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
	[AttributeUsage(Constants.Scope, AllowMultiple = true, Inherited = false)]
    public sealed class MajorFixAttribute : CodeDocsAttribute, IFunctionalGroup, IChangeTag, IMajorTag, IFixTag, INoneRiskTag, INoneEffortTag
    {

		/// <summary>
		/// Access to the definition used to generate this attribute (provided by the CodeDocs.Glossary static object)
		/// </summary>
		public override IDefinition Definition { get { return Glossary.MajorFix; }}

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
	[AttributeUsage(Constants.Scope, AllowMultiple = true, Inherited = false)]
    public sealed class MinorFixAttribute : CodeDocsAttribute, IFunctionalGroup, IChangeTag, IMinorTag, IFixTag, INoneRiskTag, INoneEffortTag
    {

		/// <summary>
		/// Access to the definition used to generate this attribute (provided by the CodeDocs.Glossary static object)
		/// </summary>
		public override IDefinition Definition { get { return Glossary.MinorFix; }}

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
	[AttributeUsage(Constants.Scope, AllowMultiple = false, Inherited = false)]
    public sealed class SlowAttribute : CodeDocsAttribute, IFunctionalGroup, IPerformanceTag, IDegredationTag, IModerateRiskTag, IMediumEffortTag, IOnePerContextTag
    {

		/// <summary>
		/// Access to the definition used to generate this attribute (provided by the CodeDocs.Glossary static object)
		/// </summary>
		public override IDefinition Definition { get { return Glossary.Slow; }}

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
	[AttributeUsage(Constants.Scope, AllowMultiple = true, Inherited = false)]
    public sealed class TodoAttribute : CodeDocsAttribute, IFunctionalGroup, IWorkTag, IDegredationTag, IExtremeRiskTag, IMediumEffortTag
    {

		/// <summary>
		/// Access to the definition used to generate this attribute (provided by the CodeDocs.Glossary static object)
		/// </summary>
		public override IDefinition Definition { get { return Glossary.Todo; }}

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

	// Safety


    /// <summary>
    /// A side-effect that may occur either by the behavior of the code or if a change is made to the code. (Defaults: Risk.Moderate, Effort.Unknown)
    /// </summary>
	[AttributeUsage(Constants.Scope, AllowMultiple = true, Inherited = false)]
    public sealed class ConsequenceAttribute : CodeDocsAttribute, ISafetyGroup, IConsequenceTag, IModerateRiskTag, IUnknownEffortTag
    {

		/// <summary>
		/// Access to the definition used to generate this attribute (provided by the CodeDocs.Glossary static object)
		/// </summary>
		public override IDefinition Definition { get { return Glossary.Consequence; }}

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
	[AttributeUsage(Constants.Scope, AllowMultiple = false, Inherited = false)]
    public sealed class DeadCodeAttribute : CodeDocsAttribute, ISafetyGroup, IDeadCodeTag, IConsequenceTag, ILowRiskTag, IVerySmallEffortTag, IOnePerContextTag
    {

		/// <summary>
		/// Access to the definition used to generate this attribute (provided by the CodeDocs.Glossary static object)
		/// </summary>
		public override IDefinition Definition { get { return Glossary.DeadCode; }}

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
    /// A note about security in relation to the context, not necessarily a risk. (Defaults: Risk.None, Effort.None)
    /// </summary>
	[AttributeUsage(Constants.Scope, AllowMultiple = true, Inherited = false)]
    public sealed class SecurityAttribute : CodeDocsAttribute, ISafetyGroup, ISecurityTag, INoneRiskTag, INoneEffortTag
    {

		/// <summary>
		/// Access to the definition used to generate this attribute (provided by the CodeDocs.Glossary static object)
		/// </summary>
		public override IDefinition Definition { get { return Glossary.Security; }}

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
	[AttributeUsage(Constants.Scope, AllowMultiple = true, Inherited = false)]
    public sealed class InsecureAttribute : CodeDocsAttribute, ISafetyGroup, ISecurityTag, IInSecureTag, IDegredationTag, IExtremeRiskTag, IUnknownEffortTag
    {

		/// <summary>
		/// Access to the definition used to generate this attribute (provided by the CodeDocs.Glossary static object)
		/// </summary>
		public override IDefinition Definition { get { return Glossary.Insecure; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public InsecureAttribute(string details, params string[] tagsAndReferences) : base(details, null, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public InsecureAttribute(string details, Risk risk, params string[] tagsAndReferences) : base(details, risk, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public InsecureAttribute(string details, Effort effort, params string[] tagsAndReferences) : base(details, null, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public InsecureAttribute(string details, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public InsecureAttribute(string details, Risk risk, Effort effort, params string[] tagsAndReferences) : base(details, risk, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public InsecureAttribute(string details, Risk risk, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public InsecureAttribute(string details, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, effort, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public InsecureAttribute(string details, Risk risk, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, effort, yyyymmdd, tagsAndReferences){}

	}

    /// <summary>
    /// Test scenario that appears to be missing (Defaults: Risk.Extreme, Effort.Small)
    /// </summary>
	[AttributeUsage(Constants.Scope, AllowMultiple = true, Inherited = false)]
    public sealed class TestAttribute : CodeDocsAttribute, ISafetyGroup, IDegredationTag, IExtremeRiskTag, ISmallEffortTag
    {

		/// <summary>
		/// Access to the definition used to generate this attribute (provided by the CodeDocs.Glossary static object)
		/// </summary>
		public override IDefinition Definition { get { return Glossary.Test; }}

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
    /// A piece of code that is extremely tempermental, developers should be cautioned, and refactoring is required. (Defaults: Risk.Extreme, Effort.Unknown)
    /// </summary>
	[AttributeUsage(Constants.Scope, AllowMultiple = false, Inherited = false)]
    public sealed class ToxicAttribute : CodeDocsAttribute, ISafetyGroup, IToxicTag, IDegredationTag, IExtremeRiskTag, IUnknownEffortTag, IOnePerContextTag
    {

		/// <summary>
		/// Access to the definition used to generate this attribute (provided by the CodeDocs.Glossary static object)
		/// </summary>
		public override IDefinition Definition { get { return Glossary.Toxic; }}

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

	// Belonging


    /// <summary>
    /// Used to identify external resources (like StakeOverflow, blogs, etc) that would add value to the context this attribute is applied to. (Defaults: Risk.None, Effort.None)
    /// </summary>
	[AttributeUsage(Constants.Scope, AllowMultiple = true, Inherited = false)]
    public sealed class CiteAttribute : CodeDocsAttribute, IBelongingGroup, IMeaningTag, INoneRiskTag, INoneEffortTag
    {

		/// <summary>
		/// Access to the definition used to generate this attribute (provided by the CodeDocs.Glossary static object)
		/// </summary>
		public override IDefinition Definition { get { return Glossary.Cite; }}

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
	[AttributeUsage(Constants.Scope, AllowMultiple = true, Inherited = false)]
    public sealed class FeatureAttribute : CodeDocsAttribute, IBelongingGroup, IFeatureTag, INoneRiskTag, INoneEffortTag
    {

		/// <summary>
		/// Access to the definition used to generate this attribute (provided by the CodeDocs.Glossary static object)
		/// </summary>
		public override IDefinition Definition { get { return Glossary.Feature; }}

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
    /// Piece of code that appears to be in the wrong place. (Defaults: Risk.Low, Effort.Unknown)
    /// </summary>
	[AttributeUsage(Constants.Scope, AllowMultiple = false, Inherited = false)]
    public sealed class LocationAttribute : CodeDocsAttribute, IBelongingGroup, IMeaningTag, ILowRiskTag, IUnknownEffortTag, IOnePerContextTag
    {

		/// <summary>
		/// Access to the definition used to generate this attribute (provided by the CodeDocs.Glossary static object)
		/// </summary>
		public override IDefinition Definition { get { return Glossary.Location; }}

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
    /// Identification of a major change that is important to communicate and potentially worthy of moving the version # forward if any exist during deployment (major.minor.incr). (Defaults: Risk.None, Effort.None)
    /// </summary>
	[AttributeUsage(Constants.Scope, AllowMultiple = true, Inherited = false)]
    public sealed class MajorChangeAttribute : CodeDocsAttribute, IBelongingGroup, IChangeTag, IMajorTag, INoneRiskTag, INoneEffortTag
    {

		/// <summary>
		/// Access to the definition used to generate this attribute (provided by the CodeDocs.Glossary static object)
		/// </summary>
		public override IDefinition Definition { get { return Glossary.MajorChange; }}

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
	[AttributeUsage(Constants.Scope, AllowMultiple = true, Inherited = false)]
    public sealed class MinorChangeAttribute : CodeDocsAttribute, IBelongingGroup, IChangeTag, IMinorTag, INoneRiskTag, INoneEffortTag
    {

		/// <summary>
		/// Access to the definition used to generate this attribute (provided by the CodeDocs.Glossary static object)
		/// </summary>
		public override IDefinition Definition { get { return Glossary.MinorChange; }}

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
	[AttributeUsage(Constants.Scope, AllowMultiple = false, Inherited = false)]
    public sealed class NamingAttribute : CodeDocsAttribute, IBelongingGroup, IMeaningTag, ILowRiskTag, ISmallEffortTag, IOnePerContextTag
    {

		/// <summary>
		/// Access to the definition used to generate this attribute (provided by the CodeDocs.Glossary static object)
		/// </summary>
		public override IDefinition Definition { get { return Glossary.Naming; }}

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
	[AttributeUsage(Constants.Scope, AllowMultiple = false, Inherited = false)]
    public sealed class ReadabilityAttribute : CodeDocsAttribute, IBelongingGroup, IMeaningTag, ILowRiskTag, ISmallEffortTag, IOnePerContextTag
    {

		/// <summary>
		/// Access to the definition used to generate this attribute (provided by the CodeDocs.Glossary static object)
		/// </summary>
		public override IDefinition Definition { get { return Glossary.Readability; }}

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
    /// Used to tag that an area of code has been reviewed by one or more people. (Defaults: Risk.None, Effort.None)
    /// </summary>
	[AttributeUsage(Constants.Scope, AllowMultiple = true, Inherited = false)]
    public sealed class ReviewedAttribute : CodeDocsAttribute, IBelongingGroup, IReviewTag, INoneRiskTag, INoneEffortTag
    {

		/// <summary>
		/// Access to the definition used to generate this attribute (provided by the CodeDocs.Glossary static object)
		/// </summary>
		public override IDefinition Definition { get { return Glossary.Reviewed; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ReviewedAttribute(string details, params string[] tagsAndReferences) : base(details, null, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ReviewedAttribute(string details, Risk risk, params string[] tagsAndReferences) : base(details, risk, null, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ReviewedAttribute(string details, Effort effort, params string[] tagsAndReferences) : base(details, null, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ReviewedAttribute(string details, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ReviewedAttribute(string details, Risk risk, Effort effort, params string[] tagsAndReferences) : base(details, risk, effort, null, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ReviewedAttribute(string details, Risk risk, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, null, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ReviewedAttribute(string details, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, null, effort, yyyymmdd, tagsAndReferences){}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="yyyymmdd">The date in 4 digit year, 2 digit month, 2 digit day in integer format (due to .net attribute limitations).</param>
        /// <param name="tagsAndReferences">Tags and Uri references.</param>
		public ReviewedAttribute(string details, Risk risk, Effort effort, int yyyymmdd, params string[] tagsAndReferences) : base(details, risk, effort, yyyymmdd, tagsAndReferences){}

	}

    /// <summary>
    /// A piece of code that needs refactored to adhere to code/design standards. (Defaults: Risk.Low, Effort.VerySmall)
    /// </summary>
	[AttributeUsage(Constants.Scope, AllowMultiple = false, Inherited = false)]
    public sealed class StandardsAttribute : CodeDocsAttribute, IBelongingGroup, IStandardsTag, ILowRiskTag, IVerySmallEffortTag, IOnePerContextTag
    {

		/// <summary>
		/// Access to the definition used to generate this attribute (provided by the CodeDocs.Glossary static object)
		/// </summary>
		public override IDefinition Definition { get { return Glossary.Standards; }}

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

	// Confidence


    /// <summary>
    /// Readable, but missing a 'good to know' for people trying to understand. (Defaults: Risk.Low, Effort.VerySmall)
    /// </summary>
	[AttributeUsage(Constants.Scope, AllowMultiple = true, Inherited = false)]
    public sealed class ClarificationAttribute : CodeDocsAttribute, IConfidenceGroup, IMeaningTag, ILowRiskTag, IVerySmallEffortTag
    {

		/// <summary>
		/// Access to the definition used to generate this attribute (provided by the CodeDocs.Glossary static object)
		/// </summary>
		public override IDefinition Definition { get { return Glossary.Clarification; }}

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
    /// A potential future scenario, in which this will need to be changed or these are some insights about the change. (Defaults: Risk.Low, Effort.None)
    /// </summary>
	[AttributeUsage(Constants.Scope, AllowMultiple = true, Inherited = false)]
    public sealed class FutureAttribute : CodeDocsAttribute, IConfidenceGroup, IWorkTag, IFutureTag, IYAGNITag, ILowRiskTag, INoneEffortTag
    {

		/// <summary>
		/// Access to the definition used to generate this attribute (provided by the CodeDocs.Glossary static object)
		/// </summary>
		public override IDefinition Definition { get { return Glossary.Future; }}

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
    /// Working feature.  Requires refactoring due to shortcuts needed to make it work. (Defaults: Risk.Moderate, Effort.Unknown)
    /// </summary>
	[AttributeUsage(Constants.Scope, AllowMultiple = true, Inherited = false)]
    public sealed class HackAttribute : CodeDocsAttribute, IConfidenceGroup, IDegredationTag, IModerateRiskTag, IUnknownEffortTag
    {

		/// <summary>
		/// Access to the definition used to generate this attribute (provided by the CodeDocs.Glossary static object)
		/// </summary>
		public override IDefinition Definition { get { return Glossary.Hack; }}

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
    /// Unsure of actual intent.  Might be doing too many things. (Defaults: Risk.Moderate, Effort.Medium)
    /// </summary>
	[AttributeUsage(Constants.Scope, AllowMultiple = false, Inherited = false)]
    public sealed class PurposeAttribute : CodeDocsAttribute, IConfidenceGroup, IMeaningTag, ISRPTag, IModerateRiskTag, IMediumEffortTag, IOnePerContextTag
    {

		/// <summary>
		/// Access to the definition used to generate this attribute (provided by the CodeDocs.Glossary static object)
		/// </summary>
		public override IDefinition Definition { get { return Glossary.Purpose; }}

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
    /// Working feature that needs improvement (Defaults: Risk.Low, Effort.Unknown)
    /// </summary>
	[AttributeUsage(Constants.Scope, AllowMultiple = false, Inherited = false)]
    public sealed class RefactorAttribute : CodeDocsAttribute, IConfidenceGroup, IDegredationTag, ILowRiskTag, IUnknownEffortTag, IOnePerContextTag
    {

		/// <summary>
		/// Access to the definition used to generate this attribute (provided by the CodeDocs.Glossary static object)
		/// </summary>
		public override IDefinition Definition { get { return Glossary.Refactor; }}

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

	// Principles


    /// <summary>
    /// [The D in SOLID] Depend upon Abstractions. Do not depend upon concretions. (Defaults: Risk.Moderate, Effort.Medium)
    /// </summary>
	[AttributeUsage(Constants.Scope, AllowMultiple = true, Inherited = false)]
    public sealed class DependancyInversionAttribute : CodeDocsAttribute, IPrinciplesGroup, IPrinciplesTag, ISOLIDTag, IDIPTag, IModerateRiskTag, IMediumEffortTag
    {

		/// <summary>
		/// Access to the definition used to generate this attribute (provided by the CodeDocs.Glossary static object)
		/// </summary>
		public override IDefinition Definition { get { return Glossary.DependancyInversion; }}

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
	[AttributeUsage(Constants.Scope, AllowMultiple = true, Inherited = false)]
    public sealed class DontRepeatYourselfAttribute : CodeDocsAttribute, IPrinciplesGroup, IPrinciplesTag, ISOLIDTag, IDRYTag, IModerateRiskTag, IMediumEffortTag
    {

		/// <summary>
		/// Access to the definition used to generate this attribute (provided by the CodeDocs.Glossary static object)
		/// </summary>
		public override IDefinition Definition { get { return Glossary.DontRepeatYourself; }}

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
    /// [The I in SOLID] Many client-specific interfaces are better than one general-purpose interface. (Defaults: Risk.Moderate, Effort.Medium)
    /// </summary>
	[AttributeUsage(Constants.Scope, AllowMultiple = true, Inherited = false)]
    public sealed class InterfaceSegregationAttribute : CodeDocsAttribute, IPrinciplesGroup, IPrinciplesTag, ISOLIDTag, IISPTag, IModerateRiskTag, IMediumEffortTag
    {

		/// <summary>
		/// Access to the definition used to generate this attribute (provided by the CodeDocs.Glossary static object)
		/// </summary>
		public override IDefinition Definition { get { return Glossary.InterfaceSegregation; }}

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
    /// [Law of Demeter] A component or object shold not know about internal details of other components or objects. (Defaults: Risk.Moderate, Effort.Medium)
    /// </summary>
	[AttributeUsage(Constants.Scope, AllowMultiple = true, Inherited = false)]
    public sealed class LeastKnowledgeAttribute : CodeDocsAttribute, IPrinciplesGroup, IPrinciplesTag, ILoDTag, IModerateRiskTag, IMediumEffortTag
    {

		/// <summary>
		/// Access to the definition used to generate this attribute (provided by the CodeDocs.Glossary static object)
		/// </summary>
		public override IDefinition Definition { get { return Glossary.LeastKnowledge; }}

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
    /// [The L in SOLID] Objects in a program should be replaceable with instances of their subtypes without altering the correctness of that program. (Defaults: Risk.Moderate, Effort.Medium)
    /// </summary>
	[AttributeUsage(Constants.Scope, AllowMultiple = true, Inherited = false)]
    public sealed class LiskovSubstitutionAttribute : CodeDocsAttribute, IPrinciplesGroup, IPrinciplesTag, ISOLIDTag, ILSPTag, IModerateRiskTag, IMediumEffortTag
    {

		/// <summary>
		/// Access to the definition used to generate this attribute (provided by the CodeDocs.Glossary static object)
		/// </summary>
		public override IDefinition Definition { get { return Glossary.LiskovSubstitution; }}

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
    /// The path with the fewest assumptions should be selected even if other directions may eventually prove correct. (Defaults: Risk.Moderate, Effort.Medium)
    /// </summary>
	[AttributeUsage(Constants.Scope, AllowMultiple = true, Inherited = false)]
    public sealed class OccamsRazorAttribute : CodeDocsAttribute, IPrinciplesGroup, IPrinciplesTag, IModerateRiskTag, IMediumEffortTag
    {

		/// <summary>
		/// Access to the definition used to generate this attribute (provided by the CodeDocs.Glossary static object)
		/// </summary>
		public override IDefinition Definition { get { return Glossary.OccamsRazor; }}

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
    /// [The O in SOLID] Software entities should be open for extension, but closed for modification. (Defaults: Risk.Moderate, Effort.Medium)
    /// </summary>
	[AttributeUsage(Constants.Scope, AllowMultiple = true, Inherited = false)]
    public sealed class OpenClosedAttribute : CodeDocsAttribute, IPrinciplesGroup, IPrinciplesTag, ISOLIDTag, IOCPTag, IModerateRiskTag, IMediumEffortTag
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

    /// <summary>
    /// The design should divide areas of concern into their own distinct sections. (Defaults: Risk.Moderate, Effort.Medium)
    /// </summary>
	[AttributeUsage(Constants.Scope, AllowMultiple = true, Inherited = false)]
    public sealed class SeparationOfConcernsAttribute : CodeDocsAttribute, IPrinciplesGroup, IPrinciplesTag, ISoCTag, IModerateRiskTag, IMediumEffortTag
    {

		/// <summary>
		/// Access to the definition used to generate this attribute (provided by the CodeDocs.Glossary static object)
		/// </summary>
		public override IDefinition Definition { get { return Glossary.SeparationOfConcerns; }}

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
    /// [The S in SOLID] Each context of code should do one thing and thus have only one reason to change. (Defaults: Risk.Moderate, Effort.Medium)
    /// </summary>
	[AttributeUsage(Constants.Scope, AllowMultiple = true, Inherited = false)]
    public sealed class SingleResponsibilityAttribute : CodeDocsAttribute, IPrinciplesGroup, IPrinciplesTag, ISOLIDTag, ISRPTag, IModerateRiskTag, IMediumEffortTag
    {

		/// <summary>
		/// Access to the definition used to generate this attribute (provided by the CodeDocs.Glossary static object)
		/// </summary>
		public override IDefinition Definition { get { return Glossary.SingleResponsibility; }}

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
    /// Always implement things when you actually need them, never when you just foresee that you need them. (Defaults: Risk.Moderate, Effort.Medium)
    /// </summary>
	[AttributeUsage(Constants.Scope, AllowMultiple = true, Inherited = false)]
    public sealed class YouArentGonnaNeedItAttribute : CodeDocsAttribute, IPrinciplesGroup, IPrinciplesTag, IYAGNITag, IModerateRiskTag, IMediumEffortTag
    {

		/// <summary>
		/// Access to the definition used to generate this attribute (provided by the CodeDocs.Glossary static object)
		/// </summary>
		public override IDefinition Definition { get { return Glossary.YouArentGonnaNeedIt; }}

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
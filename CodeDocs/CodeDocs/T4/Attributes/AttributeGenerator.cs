/*
 *
 *	System Generated via T4
 *
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs
{

    /// <summary>
    /// Used to acknowledge and identify code that has a live issue even though a resolution has not been identified or implemented. (Default risk = Extreme)
    /// </summary>
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
    public partial class BugAttribute : CodeBasedAttribute, IDegredation
    {

		public override Definition Definition {get { return Definitions.Bug; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public BugAttribute(string details, Risk risk = Risk.Extreme, Effort effort = Effort.Unknown, string tags = "", string[] urls = null) : base(details, risk, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public BugAttribute(string details, Risk risk = Risk.Extreme, string tags = "") : base(details, risk, Effort.Unknown, tags, null){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public BugAttribute(string details, Risk risk = Risk.Extreme, string tags = "", string[] urls = null) : base(details, risk, Effort.Unknown, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public BugAttribute(string details, Risk risk = Risk.Extreme, string[] urls = null) : base(details, risk, Effort.Unknown, "", urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public BugAttribute(string details, string tags = "", Risk risk = Risk.Extreme, Effort effort = Effort.Unknown, string[] urls = null) : base(details, risk, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public BugAttribute(string details, string tags = "", string[] urls = null) : base(details, Risk.Extreme, Effort.Unknown, tags, urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public BugAttribute(string details, Effort effort = Effort.Unknown, string tags = "", string[] urls = null) : base(details, Risk.Extreme, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public BugAttribute(string details, Effort effort = Effort.Unknown, string[] urls = null) : base(details, Risk.Extreme, effort, "", urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public BugAttribute(string details, string[] urls = null) : base(details, Risk.Extreme, Effort.Unknown, "", urls){}
    
	}

    /// <summary>
    /// Working feature.  Requires refactoring due to shortcuts needed to make it work. (Default risk = Moderate)
    /// </summary>
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
    public partial class HackAttribute : CodeBasedAttribute, IDegredation
    {

		public override Definition Definition {get { return Definitions.Hack; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public HackAttribute(string details, Risk risk = Risk.Moderate, Effort effort = Effort.Unknown, string tags = "", string[] urls = null) : base(details, risk, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public HackAttribute(string details, Risk risk = Risk.Moderate, string tags = "") : base(details, risk, Effort.Unknown, tags, null){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public HackAttribute(string details, Risk risk = Risk.Moderate, string tags = "", string[] urls = null) : base(details, risk, Effort.Unknown, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public HackAttribute(string details, Risk risk = Risk.Moderate, string[] urls = null) : base(details, risk, Effort.Unknown, "", urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public HackAttribute(string details, string tags = "", Risk risk = Risk.Moderate, Effort effort = Effort.Unknown, string[] urls = null) : base(details, risk, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public HackAttribute(string details, string tags = "", string[] urls = null) : base(details, Risk.Moderate, Effort.Unknown, tags, urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public HackAttribute(string details, Effort effort = Effort.Unknown, string tags = "", string[] urls = null) : base(details, Risk.Moderate, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public HackAttribute(string details, Effort effort = Effort.Unknown, string[] urls = null) : base(details, Risk.Moderate, effort, "", urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public HackAttribute(string details, string[] urls = null) : base(details, Risk.Moderate, Effort.Unknown, "", urls){}
    
	}

    /// <summary>
    /// Working feature that needs improvement. (Default risk = Low)
    /// </summary>
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
    public partial class RefactorAttribute : CodeBasedAttribute, IDegredation
    {

		public override Definition Definition {get { return Definitions.Refactor; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public RefactorAttribute(string details, Risk risk = Risk.Low, Effort effort = Effort.Unknown, string tags = "", string[] urls = null) : base(details, risk, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public RefactorAttribute(string details, Risk risk = Risk.Low, string tags = "") : base(details, risk, Effort.Unknown, tags, null){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public RefactorAttribute(string details, Risk risk = Risk.Low, string tags = "", string[] urls = null) : base(details, risk, Effort.Unknown, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public RefactorAttribute(string details, Risk risk = Risk.Low, string[] urls = null) : base(details, risk, Effort.Unknown, "", urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public RefactorAttribute(string details, string tags = "", Risk risk = Risk.Low, Effort effort = Effort.Unknown, string[] urls = null) : base(details, risk, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public RefactorAttribute(string details, string tags = "", string[] urls = null) : base(details, Risk.Low, Effort.Unknown, tags, urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public RefactorAttribute(string details, Effort effort = Effort.Unknown, string tags = "", string[] urls = null) : base(details, Risk.Low, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public RefactorAttribute(string details, Effort effort = Effort.Unknown, string[] urls = null) : base(details, Risk.Low, effort, "", urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public RefactorAttribute(string details, string[] urls = null) : base(details, Risk.Low, Effort.Unknown, "", urls){}
    
	}

    /// <summary>
    /// Test scenario that appears to be missing. (Default risk = Extreme)
    /// </summary>
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
    public partial class TestAttribute : CodeBasedAttribute, IDegredation
    {

		public override Definition Definition {get { return Definitions.Test; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public TestAttribute(string details, Risk risk = Risk.Extreme, Effort effort = Effort.Small, string tags = "", string[] urls = null) : base(details, risk, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public TestAttribute(string details, Risk risk = Risk.Extreme, string tags = "") : base(details, risk, Effort.Small, tags, null){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public TestAttribute(string details, Risk risk = Risk.Extreme, string tags = "", string[] urls = null) : base(details, risk, Effort.Small, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public TestAttribute(string details, Risk risk = Risk.Extreme, string[] urls = null) : base(details, risk, Effort.Small, "", urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public TestAttribute(string details, string tags = "", Risk risk = Risk.Extreme, Effort effort = Effort.Small, string[] urls = null) : base(details, risk, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public TestAttribute(string details, string tags = "", string[] urls = null) : base(details, Risk.Extreme, Effort.Small, tags, urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public TestAttribute(string details, Effort effort = Effort.Small, string tags = "", string[] urls = null) : base(details, Risk.Extreme, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public TestAttribute(string details, Effort effort = Effort.Small, string[] urls = null) : base(details, Risk.Extreme, effort, "", urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public TestAttribute(string details, string[] urls = null) : base(details, Risk.Extreme, Effort.Small, "", urls){}
    
	}

    /// <summary>
    /// Intent is clear.  However, naming could be cleaner. (Default risk = Low)
    /// </summary>
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
    public partial class NamingAttribute : CodeBasedAttribute, IMeaning
    {

		public override Definition Definition {get { return Definitions.Naming; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public NamingAttribute(string details, Risk risk = Risk.Low, Effort effort = Effort.Small, string tags = "", string[] urls = null) : base(details, risk, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public NamingAttribute(string details, Risk risk = Risk.Low, string tags = "") : base(details, risk, Effort.Small, tags, null){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public NamingAttribute(string details, Risk risk = Risk.Low, string tags = "", string[] urls = null) : base(details, risk, Effort.Small, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public NamingAttribute(string details, Risk risk = Risk.Low, string[] urls = null) : base(details, risk, Effort.Small, "", urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public NamingAttribute(string details, string tags = "", Risk risk = Risk.Low, Effort effort = Effort.Small, string[] urls = null) : base(details, risk, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public NamingAttribute(string details, string tags = "", string[] urls = null) : base(details, Risk.Low, Effort.Small, tags, urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public NamingAttribute(string details, Effort effort = Effort.Small, string tags = "", string[] urls = null) : base(details, Risk.Low, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public NamingAttribute(string details, Effort effort = Effort.Small, string[] urls = null) : base(details, Risk.Low, effort, "", urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public NamingAttribute(string details, string[] urls = null) : base(details, Risk.Low, Effort.Small, "", urls){}
    
	}

    /// <summary>
    /// Uncompleted feature. (Default risk = Extreme)
    /// </summary>
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
    public partial class TodoAttribute : CodeBasedAttribute, IWork
    {

		public override Definition Definition {get { return Definitions.Todo; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public TodoAttribute(string details, Risk risk = Risk.Extreme, Effort effort = Effort.Medium, string tags = "", string[] urls = null) : base(details, risk, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public TodoAttribute(string details, Risk risk = Risk.Extreme, string tags = "") : base(details, risk, Effort.Medium, tags, null){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public TodoAttribute(string details, Risk risk = Risk.Extreme, string tags = "", string[] urls = null) : base(details, risk, Effort.Medium, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public TodoAttribute(string details, Risk risk = Risk.Extreme, string[] urls = null) : base(details, risk, Effort.Medium, "", urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public TodoAttribute(string details, string tags = "", Risk risk = Risk.Extreme, Effort effort = Effort.Medium, string[] urls = null) : base(details, risk, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public TodoAttribute(string details, string tags = "", string[] urls = null) : base(details, Risk.Extreme, Effort.Medium, tags, urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public TodoAttribute(string details, Effort effort = Effort.Medium, string tags = "", string[] urls = null) : base(details, Risk.Extreme, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public TodoAttribute(string details, Effort effort = Effort.Medium, string[] urls = null) : base(details, Risk.Extreme, effort, "", urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public TodoAttribute(string details, string[] urls = null) : base(details, Risk.Extreme, Effort.Medium, "", urls){}
    
	}

    /// <summary>
    /// Piece of code that appears to be in the wrong place. (Default risk = Low)
    /// </summary>
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
    public partial class LocationAttribute : CodeBasedAttribute, IMeaning
    {

		public override Definition Definition {get { return Definitions.Location; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public LocationAttribute(string details, Risk risk = Risk.Low, Effort effort = Effort.Unknown, string tags = "", string[] urls = null) : base(details, risk, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public LocationAttribute(string details, Risk risk = Risk.Low, string tags = "") : base(details, risk, Effort.Unknown, tags, null){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public LocationAttribute(string details, Risk risk = Risk.Low, string tags = "", string[] urls = null) : base(details, risk, Effort.Unknown, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public LocationAttribute(string details, Risk risk = Risk.Low, string[] urls = null) : base(details, risk, Effort.Unknown, "", urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public LocationAttribute(string details, string tags = "", Risk risk = Risk.Low, Effort effort = Effort.Unknown, string[] urls = null) : base(details, risk, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public LocationAttribute(string details, string tags = "", string[] urls = null) : base(details, Risk.Low, Effort.Unknown, tags, urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public LocationAttribute(string details, Effort effort = Effort.Unknown, string tags = "", string[] urls = null) : base(details, Risk.Low, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public LocationAttribute(string details, Effort effort = Effort.Unknown, string[] urls = null) : base(details, Risk.Low, effort, "", urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public LocationAttribute(string details, string[] urls = null) : base(details, Risk.Low, Effort.Unknown, "", urls){}
    
	}

    /// <summary>
    /// Unsure of actual intent. (Default risk = Moderate)
    /// </summary>
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
    public partial class PurposeAttribute : CodeBasedAttribute, IMeaning
    {

		public override Definition Definition {get { return Definitions.Purpose; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public PurposeAttribute(string details, Risk risk = Risk.Moderate, Effort effort = Effort.Medium, string tags = "", string[] urls = null) : base(details, risk, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public PurposeAttribute(string details, Risk risk = Risk.Moderate, string tags = "") : base(details, risk, Effort.Medium, tags, null){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public PurposeAttribute(string details, Risk risk = Risk.Moderate, string tags = "", string[] urls = null) : base(details, risk, Effort.Medium, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public PurposeAttribute(string details, Risk risk = Risk.Moderate, string[] urls = null) : base(details, risk, Effort.Medium, "", urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public PurposeAttribute(string details, string tags = "", Risk risk = Risk.Moderate, Effort effort = Effort.Medium, string[] urls = null) : base(details, risk, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public PurposeAttribute(string details, string tags = "", string[] urls = null) : base(details, Risk.Moderate, Effort.Medium, tags, urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public PurposeAttribute(string details, Effort effort = Effort.Medium, string tags = "", string[] urls = null) : base(details, Risk.Moderate, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public PurposeAttribute(string details, Effort effort = Effort.Medium, string[] urls = null) : base(details, Risk.Moderate, effort, "", urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public PurposeAttribute(string details, string[] urls = null) : base(details, Risk.Moderate, Effort.Medium, "", urls){}
    
	}

    /// <summary>
    /// Hard to read at first glance for one or more people. (Default risk = Low)
    /// </summary>
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
    public partial class ReadabilityAttribute : CodeBasedAttribute, IMeaning
    {

		public override Definition Definition {get { return Definitions.Readability; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ReadabilityAttribute(string details, Risk risk = Risk.Low, Effort effort = Effort.Small, string tags = "", string[] urls = null) : base(details, risk, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public ReadabilityAttribute(string details, Risk risk = Risk.Low, string tags = "") : base(details, risk, Effort.Small, tags, null){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ReadabilityAttribute(string details, Risk risk = Risk.Low, string tags = "", string[] urls = null) : base(details, risk, Effort.Small, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ReadabilityAttribute(string details, Risk risk = Risk.Low, string[] urls = null) : base(details, risk, Effort.Small, "", urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ReadabilityAttribute(string details, string tags = "", Risk risk = Risk.Low, Effort effort = Effort.Small, string[] urls = null) : base(details, risk, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ReadabilityAttribute(string details, string tags = "", string[] urls = null) : base(details, Risk.Low, Effort.Small, tags, urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ReadabilityAttribute(string details, Effort effort = Effort.Small, string tags = "", string[] urls = null) : base(details, Risk.Low, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ReadabilityAttribute(string details, Effort effort = Effort.Small, string[] urls = null) : base(details, Risk.Low, effort, "", urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ReadabilityAttribute(string details, string[] urls = null) : base(details, Risk.Low, Effort.Small, "", urls){}
    
	}

    /// <summary>
    /// Used to identify external resources (like StakeOverflow, blogs, etc) that would add value to the context this attribute is applied to. (Default risk = None)
    /// </summary>
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
    public partial class ReferenceMaterialAttribute : CodeBasedAttribute, IMeaning
    {

		public override Definition Definition {get { return Definitions.ReferenceMaterial; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ReferenceMaterialAttribute(string details, Risk risk = Risk.None, Effort effort = Effort.None, string tags = "", string[] urls = null) : base(details, risk, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public ReferenceMaterialAttribute(string details, Risk risk = Risk.None, string tags = "") : base(details, risk, Effort.None, tags, null){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ReferenceMaterialAttribute(string details, Risk risk = Risk.None, string tags = "", string[] urls = null) : base(details, risk, Effort.None, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ReferenceMaterialAttribute(string details, Risk risk = Risk.None, string[] urls = null) : base(details, risk, Effort.None, "", urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ReferenceMaterialAttribute(string details, string tags = "", Risk risk = Risk.None, Effort effort = Effort.None, string[] urls = null) : base(details, risk, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ReferenceMaterialAttribute(string details, string tags = "", string[] urls = null) : base(details, Risk.None, Effort.None, tags, urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ReferenceMaterialAttribute(string details, Effort effort = Effort.None, string tags = "", string[] urls = null) : base(details, Risk.None, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ReferenceMaterialAttribute(string details, Effort effort = Effort.None, string[] urls = null) : base(details, Risk.None, effort, "", urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public ReferenceMaterialAttribute(string details, string[] urls = null) : base(details, Risk.None, Effort.None, "", urls){}
    
	}

    /// <summary>
    /// A distinctive function/attribute about what the application does (Default risk = None)
    /// </summary>
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
    public partial class FeatureAttribute : CodeBasedAttribute, IFeature
    {

		public override Definition Definition {get { return Definitions.Feature; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public FeatureAttribute(string details, Risk risk = Risk.None, Effort effort = Effort.None, string tags = "", string[] urls = null) : base(details, risk, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public FeatureAttribute(string details, Risk risk = Risk.None, string tags = "") : base(details, risk, Effort.None, tags, null){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public FeatureAttribute(string details, Risk risk = Risk.None, string tags = "", string[] urls = null) : base(details, risk, Effort.None, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public FeatureAttribute(string details, Risk risk = Risk.None, string[] urls = null) : base(details, risk, Effort.None, "", urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public FeatureAttribute(string details, string tags = "", Risk risk = Risk.None, Effort effort = Effort.None, string[] urls = null) : base(details, risk, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public FeatureAttribute(string details, string tags = "", string[] urls = null) : base(details, Risk.None, Effort.None, tags, urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public FeatureAttribute(string details, Effort effort = Effort.None, string tags = "", string[] urls = null) : base(details, Risk.None, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public FeatureAttribute(string details, Effort effort = Effort.None, string[] urls = null) : base(details, Risk.None, effort, "", urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public FeatureAttribute(string details, string[] urls = null) : base(details, Risk.None, Effort.None, "", urls){}
    
	}

    /// <summary>
    /// Identification of a major change that is important to communicate and potentially worthy of moving the version # forward if any exist during deployment (major.minor.incr). (Default risk = None)
    /// </summary>
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
    public partial class MajorChangeAttribute : CodeBasedAttribute, IChange, IMajor
    {

		public override Definition Definition {get { return Definitions.MajorChange; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MajorChangeAttribute(string details, Risk risk = Risk.None, Effort effort = Effort.None, string tags = "", string[] urls = null) : base(details, risk, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public MajorChangeAttribute(string details, Risk risk = Risk.None, string tags = "") : base(details, risk, Effort.None, tags, null){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MajorChangeAttribute(string details, Risk risk = Risk.None, string tags = "", string[] urls = null) : base(details, risk, Effort.None, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MajorChangeAttribute(string details, Risk risk = Risk.None, string[] urls = null) : base(details, risk, Effort.None, "", urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MajorChangeAttribute(string details, string tags = "", Risk risk = Risk.None, Effort effort = Effort.None, string[] urls = null) : base(details, risk, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MajorChangeAttribute(string details, string tags = "", string[] urls = null) : base(details, Risk.None, Effort.None, tags, urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MajorChangeAttribute(string details, Effort effort = Effort.None, string tags = "", string[] urls = null) : base(details, Risk.None, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MajorChangeAttribute(string details, Effort effort = Effort.None, string[] urls = null) : base(details, Risk.None, effort, "", urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MajorChangeAttribute(string details, string[] urls = null) : base(details, Risk.None, Effort.None, "", urls){}
    
	}

    /// <summary>
    /// Identification of a minor change that is important to communicate and potentially worthy of moving the version # forward if any exist during deployment (major.minor.incr). (Default risk = None)
    /// </summary>
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
    public partial class MinorChangeAttribute : CodeBasedAttribute, IChange, IMinor
    {

		public override Definition Definition {get { return Definitions.MinorChange; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MinorChangeAttribute(string details, Risk risk = Risk.None, Effort effort = Effort.None, string tags = "", string[] urls = null) : base(details, risk, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public MinorChangeAttribute(string details, Risk risk = Risk.None, string tags = "") : base(details, risk, Effort.None, tags, null){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MinorChangeAttribute(string details, Risk risk = Risk.None, string tags = "", string[] urls = null) : base(details, risk, Effort.None, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MinorChangeAttribute(string details, Risk risk = Risk.None, string[] urls = null) : base(details, risk, Effort.None, "", urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MinorChangeAttribute(string details, string tags = "", Risk risk = Risk.None, Effort effort = Effort.None, string[] urls = null) : base(details, risk, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MinorChangeAttribute(string details, string tags = "", string[] urls = null) : base(details, Risk.None, Effort.None, tags, urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MinorChangeAttribute(string details, Effort effort = Effort.None, string tags = "", string[] urls = null) : base(details, Risk.None, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MinorChangeAttribute(string details, Effort effort = Effort.None, string[] urls = null) : base(details, Risk.None, effort, "", urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MinorChangeAttribute(string details, string[] urls = null) : base(details, Risk.None, Effort.None, "", urls){}
    
	}

    /// <summary>
    /// Identification of a major fix that is important to communicate and potentially worthy of moving the [incr] version # forward if any exist during deployment (major.minor.incr). (Default risk = None)
    /// </summary>
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
    public partial class MajorFixAttribute : CodeBasedAttribute, IChange, IMajor, IFix
    {

		public override Definition Definition {get { return Definitions.MajorFix; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MajorFixAttribute(string details, Risk risk = Risk.None, Effort effort = Effort.None, string tags = "", string[] urls = null) : base(details, risk, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public MajorFixAttribute(string details, Risk risk = Risk.None, string tags = "") : base(details, risk, Effort.None, tags, null){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MajorFixAttribute(string details, Risk risk = Risk.None, string tags = "", string[] urls = null) : base(details, risk, Effort.None, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MajorFixAttribute(string details, Risk risk = Risk.None, string[] urls = null) : base(details, risk, Effort.None, "", urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MajorFixAttribute(string details, string tags = "", Risk risk = Risk.None, Effort effort = Effort.None, string[] urls = null) : base(details, risk, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MajorFixAttribute(string details, string tags = "", string[] urls = null) : base(details, Risk.None, Effort.None, tags, urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MajorFixAttribute(string details, Effort effort = Effort.None, string tags = "", string[] urls = null) : base(details, Risk.None, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MajorFixAttribute(string details, Effort effort = Effort.None, string[] urls = null) : base(details, Risk.None, effort, "", urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MajorFixAttribute(string details, string[] urls = null) : base(details, Risk.None, Effort.None, "", urls){}
    
	}

    /// <summary>
    /// Identification of a minor fix that is important to communicate and potentially worthy of moving the [incr] version # forward if any exist during deployment (major.minor.incr). (Default risk = None)
    /// </summary>
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
    public partial class MinorFixAttribute : CodeBasedAttribute, IChange, IMinor, IFix
    {

		public override Definition Definition {get { return Definitions.MinorFix; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MinorFixAttribute(string details, Risk risk = Risk.None, Effort effort = Effort.None, string tags = "", string[] urls = null) : base(details, risk, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public MinorFixAttribute(string details, Risk risk = Risk.None, string tags = "") : base(details, risk, Effort.None, tags, null){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MinorFixAttribute(string details, Risk risk = Risk.None, string tags = "", string[] urls = null) : base(details, risk, Effort.None, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MinorFixAttribute(string details, Risk risk = Risk.None, string[] urls = null) : base(details, risk, Effort.None, "", urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MinorFixAttribute(string details, string tags = "", Risk risk = Risk.None, Effort effort = Effort.None, string[] urls = null) : base(details, risk, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MinorFixAttribute(string details, string tags = "", string[] urls = null) : base(details, Risk.None, Effort.None, tags, urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MinorFixAttribute(string details, Effort effort = Effort.None, string tags = "", string[] urls = null) : base(details, Risk.None, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MinorFixAttribute(string details, Effort effort = Effort.None, string[] urls = null) : base(details, Risk.None, effort, "", urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public MinorFixAttribute(string details, string[] urls = null) : base(details, Risk.None, Effort.None, "", urls){}
    
	}

    /// <summary>
    /// A potential future scenario, in which this will need to be changed or these are some insights about the change. (Default risk = Low)
    /// </summary>
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
    public partial class FutureAttribute : CodeBasedAttribute, IWork, IFuture
    {

		public override Definition Definition {get { return Definitions.Future; }}

		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public FutureAttribute(string details, Risk risk = Risk.Low, Effort effort = Effort.None, string tags = "", string[] urls = null) : base(details, risk, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
		public FutureAttribute(string details, Risk risk = Risk.Low, string tags = "") : base(details, risk, Effort.None, tags, null){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public FutureAttribute(string details, Risk risk = Risk.Low, string tags = "", string[] urls = null) : base(details, risk, Effort.None, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public FutureAttribute(string details, Risk risk = Risk.Low, string[] urls = null) : base(details, risk, Effort.None, "", urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="risk">The level of risk identified for the context.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public FutureAttribute(string details, string tags = "", Risk risk = Risk.Low, Effort effort = Effort.None, string[] urls = null) : base(details, risk, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public FutureAttribute(string details, string tags = "", string[] urls = null) : base(details, Risk.Low, Effort.None, tags, urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="tags">Comma separated list of tags for any use.  ("," or ", " supported)</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public FutureAttribute(string details, Effort effort = Effort.None, string tags = "", string[] urls = null) : base(details, Risk.Low, effort, tags, urls){}
		
		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="effort">The assumed estimate of effort required.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public FutureAttribute(string details, Effort effort = Effort.None, string[] urls = null) : base(details, Risk.Low, effort, "", urls){}


		/// <summary></summary>
        /// <param name="details">The message to convey. Try to keep it short and to the point.</param>
        /// <param name="urls">One or more Urls that provide reference value (Ex. a link to how something should be refactored.  A link to an article that helped figure out how something should be done.)</param>
		public FutureAttribute(string details, string[] urls = null) : base(details, Risk.Low, Effort.None, "", urls){}
    
	}
}
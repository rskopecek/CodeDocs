using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace CodeDocs
{
    public abstract class CodeBasedAttribute : Attribute
    {

        protected CodeBasedAttribute(string details, Risk risk, Effort effort, string tags, string[] urls)
        {
            this.Risk = risk;
            this.Effort = effort;
            this.Details = details;
            this.Tags = SplitToTags(tags);
            this.Urls = urls;

            this.EstimatedValue = CalculateEstimatedValue(risk, effort);
        }


        public abstract Definition Definition { get; }


        public readonly Risk Risk;

        public readonly Effort Effort;

        public readonly int EstimatedValue;

        public readonly string Details;

        public readonly string[] Tags;

        public readonly string[] Urls;

        public static string[] SplitToTags(string tags)
        {
            return string.IsNullOrEmpty(tags) ? new string[0] : tags.Replace(", ", ",").Split(',');
        }

        public static int CalculateEstimatedValue(Risk risk, Effort effort)
        {
            return (int) effort == 0 ? 0 : ((int) risk / (int) effort);
        }
    }
}

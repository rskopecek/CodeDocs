using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeDocs.Definitions.v2;

namespace CodeDocs.Tests.AttributeUsage
{
    public class Scenario
    {
        public Scenario(string methodValues, DateTime? date, Risk? risk, Effort? effort, string details, string[] tags,
            string[] urls)
        {
            this.MethodValues = methodValues;
            this.Date = date;
            this.Risk = risk;
            this.Effort = effort;
            this.Details = details;
            this.Tags = tags;
            this.Urls = urls;
        }

        public readonly string MethodValues;

        public readonly DateTime? Date;

        public readonly Risk? Risk;

        public readonly Effort? Effort;

        public readonly string Details;

        public readonly string[] Tags;

        public readonly string[] Urls;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeDocs.Helpers;

namespace CodeDocs.v2
{
    public class AuditableChangeAttribute : CodeDocsBaseAttribute
    {
        public AuditableChangeAttribute(int yyyymmdd, string who, string what, string why, params string[] references)
        {
            Who = who;
            What = what;
            When = yyyymmdd.ToDate();
            Why = why;
            References = references;
        }

        public readonly string Who;
        public readonly string What;
        public readonly DateTime When;
        public readonly string Why;
        public readonly string[] References;

    }
}

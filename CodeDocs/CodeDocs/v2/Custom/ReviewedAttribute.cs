using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeDocs.Helpers;

namespace CodeDocs.v2
{
    /// <summary>
    /// Used to tag that an area of code as been reviewed by someone on a particular day.
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
    public class ReviewedAttribute : CodeDocsBaseAttribute
    {
        public ReviewedAttribute(int yyyymmdd, string name)
        {
            this.Date = yyyymmdd.ToDate();
            this.Name = name;
        }

        public readonly DateTime Date;
        public readonly string Name;

    }
}

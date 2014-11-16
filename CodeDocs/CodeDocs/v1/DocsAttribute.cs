using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.v1
{
    [Obsolete(Constants.v1_Obsolete_Message)]
    public class DocsAttribute : CodeDocsBaseAttribute
    {
        public DocsAttribute(string title, string description)
        {
            Title = title;
            Description = description;
        }
        public string Title { get; private set; }
        public string Description { get; private set; }
    }
}

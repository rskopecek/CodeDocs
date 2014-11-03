using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.About
{
    public class DocsAttribute : Attribute
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

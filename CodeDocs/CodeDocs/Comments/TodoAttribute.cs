using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Comments
{

    /// <summary>
    /// Uncompleted feature
    /// </summary>
    public class TodoAttribute : CodeBasedCommentAttribute
    {
        public TodoAttribute(string details) : base(details)
        {
        }
    }
}

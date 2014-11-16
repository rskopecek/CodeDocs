using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs
{
    /// <summary>
    /// Scoped root attribute that all other doc attributes are based off of to allow cross version queries
    /// </summary>
    public abstract class CodeDocsBaseAttribute : Attribute
    {
    }
}

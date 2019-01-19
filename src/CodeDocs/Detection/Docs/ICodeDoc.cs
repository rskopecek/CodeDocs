using System;
using System.Collections.Generic;

namespace CodeDocs.Detection
{
    public interface ICodeDoc
    {
        string Name { get; }
        string FullName { get; }
        IEnumerable<ICodeDoc> AllDocs();
        List<CodeDocsAttribute> Docs { get; }
    }
}

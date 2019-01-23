using System;
using System.Collections.Generic;
using System.Text;

namespace CodeDocs.Detection
{
    public class FlatDoc
    {
        public FlatDoc(ICodeDoc doc, CodeDocsAttribute att)
        {
            Doc = doc;
            Att = att;
        }

        public ICodeDoc Doc { get; }
        public CodeDocsAttribute Att { get; }
    }
}

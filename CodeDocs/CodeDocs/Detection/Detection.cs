using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Text;

namespace CodeDocs
{
    public class Detection
    {
        public Detection()
        {
        }

        public Detection(Type type, object context, CodeDocsAttribute info)
        {
            this.Type = type;
            this.Context = context;
            this.Info = info;
        }


        public Type Type { get; set; }

        public object Context { get; set; }

        public CodeDocsAttribute Info { get; set; }

    }
}

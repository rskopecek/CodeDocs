using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace CodeDocs.Generator
{
    public partial class ExampleTemplate
    {
        public ExampleTemplate(string coreType, string name, Func<string> getId, string nestedType)
        {
            CoreType = coreType;
            Name = name;
            GetId = getId;
            NestedType = nestedType;
            Accessors = new List<string>
            {
            "public", "internal", "private", "protected"
              };

            if (coreType == "struct") Accessors.Remove("protected");
        }

        public string CoreType { get; }
        public string Name { get; }
        public Func<string> GetId { get; }
        public string NestedType { get; }

        public string Doc
        {
            get
            {
                var atts = string.Join(',', Definition.List.Select(att => $"{att.Name}(\"{GetId()}\")"));

                return $"[{atts}]{Environment.NewLine}";
            }
        }

        public List<string> Accessors { get; }

        int argCount = 0;

        public string ConstructorArgs()
            => string.Join(",", Enumerable.Range(1, ++argCount).Select(x => $"bool arg{x}"));


    }
}

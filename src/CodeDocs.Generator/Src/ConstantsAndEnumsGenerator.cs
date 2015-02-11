using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeDocs.Generator.Models;
using CodeDocs.Generator.Src.Templates;

namespace CodeDocs.Generator.Src
{
    public static class ConstantsAndEnumsGenerator
    {
        public const string SaveToPath = Program.CodeDocsPath + @"Generated\ConstantsAndEnums.generated.cs";

        public static void Process(Glossary glossary)
        {
            Reset();

            var template = new ConstantsAndEnumsTemplate(glossary);

            var code = template.TransformText();

            File.WriteAllText(SaveToPath, code);
        }

        private static void Reset()
        {
            if(File.Exists(SaveToPath))
                File.Delete(SaveToPath);
        }
    }
}

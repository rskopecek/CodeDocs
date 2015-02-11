using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeDocs.Generator.Models;
using CodeDocs.Generator.Src.Templates;

namespace CodeDocs.Generator
{
    public static class DefinitionGenerator
    {

        public const string SaveToPath = Program.CodeDocsPath + @"Generated\Definitions\";

        public static void Process(Glossary glossary)
        {
            Reset();
            
            glossary.Definitions.ForEach(Process);
        }

        public static void Process(Definition definition)
        {
            var template = new DefinitionTemplate(definition);

            var code = template.TransformText();

            var filePath = SaveToPath + definition.Id + ".generated.cs";

            File.WriteAllText(filePath, code);
        }

        private static void Reset()
        {
            if (!Directory.Exists(SaveToPath))
                Directory.CreateDirectory(SaveToPath);

            foreach (var file in Directory.EnumerateFiles(SaveToPath))
            {
                File.Delete(file);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeDocs.Generator.Docs.Templates;
using CodeDocs.Generator.Models;

namespace CodeDocs.Generator.Docs
{
    public static class DefinitionGenerator
    {

        public const string SaveToPath = Program.RootPath + @"Docs\Definitions\";

        public static void Process(Glossary glossary)
        {
            Reset();

            glossary.Definitions.ForEach(d=> Process(glossary, d));
        }

        public static void Process(Glossary glossary, Definition definition)
        {
            var template = new DefinitionTemplate(glossary, definition);

            var code = template.TransformText();

            var filePath = SaveToPath + definition.Id + ".md";

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

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
    public static class InterfaceGenerator
    {

        public const string SaveToPath = Program.CodeDocsPath + @"Generated\Interfaces\";

        public static void Process(Glossary glossary)
        {
            Reset();

            // Risks
            foreach (var risk in glossary.Risks)
            {
                var template = new InterfaceTemplate(risk.Name + "RiskTag", "Interface used soley for polymorphic routing.  Interface risk tags are attached to definitions and their attributes.");

                var code = template.TransformText();

                var filePath = SaveToPath + "I" + risk.Name + "RiskTag.generated.cs";

                File.WriteAllText(filePath, code);
            }

            // Efforts
            foreach (var effort in glossary.Efforts)
            {
                var template = new InterfaceTemplate(effort.Name + "EffortTag", "Interface used soley for polymorphic routing.  Interface effort tags are attached to definitions and their attributes.");

                var code = template.TransformText();

                var filePath = SaveToPath + "I" + effort.Name + "EffortTag.generated.cs";

                File.WriteAllText(filePath, code);
            }

            // Tags
            var tags = glossary.Definitions.SelectMany(d => d.Tags).Distinct().ToList();

            tags.Add("OnePerContext");

            foreach (var tag in tags)
            {
                var template = new InterfaceTemplate(tag + "Tag", "Interface used soley for polymorphic routing.  Interface definition tags are attached to definitions and their attributes.");

                var code = template.TransformText();

                var filePath = SaveToPath + "I" + tag + "Tag.generated.cs";

                File.WriteAllText(filePath, code);
            }

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

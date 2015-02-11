using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeDocs.Generator.Models;
using CodeDocs.Generator.Src.Templates;
using CodeDocs.Generator.Tests.Templates;

namespace CodeDocs.Generator.Tests
{
    public static class CompilableAttributeUsageGenerator
    {
        public const string SaveToPath = Program.CodeDocsTestsPath + @"Generated\CompilableAttributeUsage\";

        public static void Process(Glossary glossary)
        {
            Reset();

            var assemblyLevel = new StringBuilder();

            foreach (var definition in glossary.Definitions)
            {
                Process(definition);

                assemblyLevel.AppendLine(@"[assembly:" + definition.Id + @"("""")]");
            }

            UpdateAssemblyInfo(assemblyLevel.ToString());
        }

        public static void Process(Definition definition)
        {
            var template = new CompilableAttributeUsage(definition);

            var code = template.TransformText();

            var filePath = SaveToPath + definition.Id + ".generated.cs";

            File.WriteAllText(filePath, code);
        }


        private static void UpdateAssemblyInfo(string assemblyDefinitions)
        {
            var lines = File.ReadAllLines(Program.CodeDocsTestsPath + Program.ProjectRelativeAssemblyPath);
            var newFile = new StringBuilder();

            foreach (var line in lines)
            {
                newFile.AppendLine(line);

                if (line == Program.SharedFiledParseLine)
                    break;
            }
            
            newFile.AppendLine();
            newFile.Append(assemblyDefinitions);

            File.WriteAllText(Program.CodeDocsTestsPath + Program.ProjectRelativeAssemblyPath, newFile.ToString());
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

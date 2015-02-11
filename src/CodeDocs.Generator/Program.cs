using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeDocs.Generator.Docs;
using CodeDocs.Generator.Models;
using CodeDocs.Generator.Src;
using CodeDocs.Generator.Tests;
using Newtonsoft.Json;

namespace CodeDocs.Generator
{
    class Program
    {
        public const string RootPath = @"..\..\..\..\";
        public const string RelativeBasePath = @"..\..\..\";
        public const string CodeDocsPath = RelativeBasePath + @"CodeDocs\";
        public const string CodeDocsTestsPath = RelativeBasePath + @"CodeDocs.Tests\";
        public const string ProjectRelativeAssemblyPath = @"Properties\AssemblyInfo.cs";
        public const string SharedFiledParseLine = @"//********** Auto-Generated Below **********";

        static void Main(string[] args)
        {
            var json = File.ReadAllText(@"glossary.json");
            var glossary = JsonConvert.DeserializeObject<Glossary>(json);

            SourceGenerator.Process(glossary);
            //DocsGenerator.Process(glossary);
            //TestGenerator.Process(glossary);


        }
    }
}

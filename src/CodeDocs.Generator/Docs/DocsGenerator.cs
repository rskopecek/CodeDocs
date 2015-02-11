using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeDocs.Generator.Models;

namespace CodeDocs.Generator.Docs
{
    public static class DocsGenerator
    {

        public static void Process(Glossary glossary)
        {
            DefinitionGenerator.Process(glossary);
        }
    }
}

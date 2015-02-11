using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeDocs.Generator.Models;

namespace CodeDocs.Generator.Src
{
    public static class SourceGenerator
    {

        public static void Process(Glossary glossary)
        {
            DefinitionGenerator.Process(glossary);
            AttributeGenerator.Process(glossary);
            InterfaceGenerator.Process(glossary);
            ConstantsAndEnumsGenerator.Process(glossary);
            GlossaryGenerator.Process(glossary);
        }

    }
}

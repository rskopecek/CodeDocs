using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using CodeDocs.Generator.Models;

namespace CodeDocs.Generator.Docs.Templates
{
    public partial class DefinitionTemplate
    {
        public DefinitionTemplate(Glossary glossary, Definition definition)
        {
            Glossary = glossary;
            Definition = definition;
        }

        private readonly Glossary Glossary;
        private readonly Definition Definition;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeDocs.Generator.Models;

namespace CodeDocs.Generator.Src.Templates
{
    public partial class GlossaryTemplate
    {
        public GlossaryTemplate(Glossary glossary)
        {
            Glossary = glossary;
        }

        private readonly Glossary Glossary;


    }
}

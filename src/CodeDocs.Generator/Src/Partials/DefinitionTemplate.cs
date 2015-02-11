using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeDocs.Generator.Models;

namespace CodeDocs.Generator.Src.Templates
{
    public partial class DefinitionTemplate
    {

        private readonly Definition Definition;

        public DefinitionTemplate(Definition definition)
        {
            Definition = definition;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeDocs.Generator.Models;

namespace CodeDocs.Generator.Tests.Templates
{
    public partial class CompilableAttributeUsage
    {
        public CompilableAttributeUsage(Definition definition)
        {
            Definition = definition;
        }

        private readonly Definition Definition;


    }
}

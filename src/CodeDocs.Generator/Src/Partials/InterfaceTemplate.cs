using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDocs.Generator.Src.Templates
{
    public partial class InterfaceTemplate
    {
        public InterfaceTemplate(string name, string description)
        {
            Name = name;
            Description = description;
        }

        private readonly string Name;
        private readonly string Description;


    }
}

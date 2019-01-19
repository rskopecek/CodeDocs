using System;
namespace CodeDocs.Generator
{
    public partial class CodeDocAttributeTemplate
    {
        public CodeDocAttributeTemplate(Definition definition)
        {
            Definition = definition;
        }

        public Definition Definition { get; }
    }
}

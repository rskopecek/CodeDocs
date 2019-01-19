using System;
namespace CodeDocs.Generator
{
    public partial class ExampleWrapperTemplate
    {
        public ExampleWrapperTemplate(string internals, int count)
        {
            Internals = internals;
            Count = count;
        }

        public string Internals { get; }
        public int Count { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs
{
    public interface IDefinition
    {
        string Group { get; }
        string Name { get; }
        string Description { get; }
        Risk DefaultRisk { get; }
        Effort DefaultEffort { get; }
        Tag[] Tags { get; }
        bool OnePerContext { get; }
    }
}

using System;
namespace CodeDocs
{
    // Design Patterns - https://en.wikipedia.org/wiki/Software_design_pattern
    [Flags]
    public enum Structural
    {
        NotSet = 0,

        Adapter = 1,
        Bridge = 2,
        Composite = 4,
        Decorator = 8,
        ExtentionObject = 16,
        Facade = 32,
        Flyweight = 64,
        FrontController = 128,
        Marker = 256,
        Module = 512,
        Proxy = 1_024,
        Twin = 2_048,
    }
}

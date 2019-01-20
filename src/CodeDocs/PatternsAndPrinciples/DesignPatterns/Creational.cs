using System;
namespace CodeDocs
{
    // Design Patterns - https://en.wikipedia.org/wiki/Software_design_pattern
    [Flags]
    public enum Creational
    {
        NotSet = 0,

        AbstractFactory = 1,
        Builder = 2,
        DependencyInjection = 4,
        FactoryMethod = 8,
        LazyInitialization = 16,
        Multiton = 32,
        ObjectPool = 64,
        Prototype = 128,
        ResourceAcquisitionIsInitialization = 256,
        Singleton = 512,

    }
}

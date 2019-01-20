using System;
namespace CodeDocs
{
    // https://en.wikipedia.org/wiki/SOLID
    // https://en.wikipedia.org/wiki/Category:Programming_principles
    [Flags]
    public enum Solid
    {
        NotSet = 0,

        SingleResponsibility = 1,
        OpenClosed = 2,
        LiskovSubstitution = 4,
        InterfaceSegregation = 8,
        DependencyInversion = 16,

    }
}

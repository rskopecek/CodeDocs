using System;
namespace CodeDocs
{
    //https://en.wikipedia.org/wiki/Architectural_pattern
    [Flags]
    public enum Functional
    {
        NotSet = 0,

        Closure = 1,
        Currying = 2,
        FunctionComposition = 4,
        Functor = 8,
        Monad = 16,
        Generator = 32


    }
}

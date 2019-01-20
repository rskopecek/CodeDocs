using System;
namespace CodeDocs
{
    // Design Patterns - https://en.wikipedia.org/wiki/Software_design_pattern
    [Flags]
    public enum Behavioral
    {
        NotSet = 0,

        Blackboard = 1,
        ChainOfResponsibility = 2,
        Command = 4,
        Interpreter = 8,
        Iterator = 16,
        Mediator = 32,
        Memento = 64,
        NullObject = 128,
        Observer = 256,
        Servant = 512,
        Specification = 1_024,
        State = 2_048,
        Strategy = 4_096,
        TemplateMethod = 8_192,
        Visitor = 16_384,
    }
}

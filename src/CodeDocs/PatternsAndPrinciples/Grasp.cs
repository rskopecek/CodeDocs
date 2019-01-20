using System;
namespace CodeDocs
{
    [Flags]
    public enum Grasp
    {
        NotSet = 0,

        // GRASP - https://en.wikipedia.org/wiki/GRASP_(object-oriented_design)
        Controller = 1,
        Creator = 2,
        HighCohesion = 4,
        InformationExpert = 8,
        LowCoupling = 16,
        Polymorphism = 32,
        ProtectedVariations = 64,
        PureFabrication = 128,
        Indirection = 256,

    }
}

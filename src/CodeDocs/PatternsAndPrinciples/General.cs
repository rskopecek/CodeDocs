using System;
namespace CodeDocs
{

    // https://stackoverflow.com/questions/1030090/how-do-you-pass-multiple-enum-values-in-c
    // http://geekswithblogs.net/BlackRabbitCoder/archive/2010/07/22/c-fundamentals-combining-enum-values-with-bit-flags.aspx


    // https://en.wikipedia.org/wiki/List_of_software_architecture_styles_and_patterns

    // https://en.wikipedia.org/wiki/SOLID
    // https://en.wikipedia.org/wiki/Category:Programming_principles
    public enum General
    {

        NotSet = 0,

        DontRepeatYourself = 1,
        LeastKnowledge = 2,

        OccamsRazor = 4,

        SeparationOfConcerns = 8,

        YouArentGonnaNeedIt = 16,
        MinimumViableProduct = 32,

        NoSideEffects = 64
    }
}

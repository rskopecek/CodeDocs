using System;
using System.Collections.Generic;

namespace CodeDocs.Generator
{
    public class Definition
    {
        public Definition(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; }
        public string Description { get; }



        public static List<Definition> List = new List<Definition>()
        {
            new Definition("Bug", "Defect or possible defect in code"),
            new Definition("Feature", "Area where a feature could be added."),
            new Definition("Hack", "Work around that should be addressed at some point"),
            new Definition("Insecure", "Situation that could result in a less than secure solution at some point"),
            new Definition("Location", "The location of this item should be reconsidered"),
            new Definition("Purpose", "It's unclear what the true purpose of the code"),
            new Definition("Readability", "Unable to understand the code in a reasonable amount of time"),
            new Definition("Naming", "The name of this item should be reconsidered"),
            new Definition("Slow", "The code is known to be or potentially less than reasonably performant"),
            new Definition("DeadCode", "From all appearances the code can be removed, but need a formal review"),
            new Definition("Reinventing", "Reinventing the wheel instead of using built-in or pre-built code (.net, nuget, etc)"),
            new Definition("Testing", "A use case or scenario that doesn't appear to have adequate automated testing"),
            new Definition("Toxic", "Code no one wants to touch because they are honestly scared"),
            new Definition("Standards", "code is fine, but needs updated to conform to standards"),
            new Definition("Docs", "Code is here, but some kind of documentation needs updated to reflect (ex. visio)"),
            new Definition("Todo", "General task to be accomplished"),
            new Definition("Design", "The general design of the item needs to be reconsidered"),
            new Definition("Scalability", "The code has or will have a scalability issue that will need to be reconsidered"),
            new Definition("Availability", "The code has or will have an availability issue that will need to be reconsidered"),
            new Definition("Integrity", "The code has or will have an integrity issue that will need to be reconsidered"),
            new Definition("SideEffects", "The code has side effects which is either not clear or shouldn't occur"),
        };
    }
}

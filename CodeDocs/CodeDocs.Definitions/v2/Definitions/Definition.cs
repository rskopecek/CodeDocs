using System.Collections.Generic;
using System.Linq;

namespace CodeDocs.Definitions.v2
{
    public abstract class Definition
    {

        protected Definition(string name, bool multipleAllowed, Risk defaultRisk, Effort defaultEffort, string description, params string[] tags)
        {
            this.Name = name;
            this.Description = description;
            this.DefaultRisk = defaultRisk;
            this.DefaultEffort = defaultEffort;
            this.Tags = tags.ToList(); // use this to generate interfaces attached to the generated attributes

            this.MultipleAllowed = multipleAllowed;
        }

        public readonly string Name; //{ get; set; }

        public readonly string Description;// { get; set; }

        public readonly Risk DefaultRisk;// { get; set; }

        public readonly Effort DefaultEffort;// { get; set; }

        public readonly List<string> Tags; //{ get; set; }

        public readonly bool MultipleAllowed;

        public IEnumerable<string> InterfaceNames()
        {
            return Tags.Select(tag => "I" + tag);
        }
    }
}
using System.Collections.Generic;
using System.Linq;

namespace CodeDocs
{
    public class Definition
    {
        public Definition()
        {
        }

        public Definition(string name, Risk defaultRisk, Effort defaultEffort, string description, params string[] tags)
        {
            this.Name = name;
            this.Description = description;
            this.DefaultRisk = defaultRisk;
            this.DefaultEffort = defaultEffort;
            this.Tags = tags.ToList(); // use this to generate interfaces attached to the generated attributes
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public Risk DefaultRisk { get; set; }

        public Effort DefaultEffort { get; set; }

        public List<string> Tags { get; set; }

        public IEnumerable<string> InterfaceNames()
        {
            return Tags.Select(tag => "I" + tag);
        }
    }
}
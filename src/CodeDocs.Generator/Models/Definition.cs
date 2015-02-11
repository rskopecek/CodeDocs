using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CodeDocs.Generator.Models
{
    public class Definition
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty("description", Required = Required.Always)]
        public string Description { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("one_per_context")]
        public bool OnePerContext { get; set; }

        public IEnumerable<string> InterfaceNames()
        {
            var iNames = new List<string>();

            iNames.AddRange(Tags.Select(tag => "I" + tag + "Tag"));

            if (OnePerContext)
                iNames.Add("IOnePerContextTag");

            return iNames;
        }
    }
}

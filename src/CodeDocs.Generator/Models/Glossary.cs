using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CodeDocs.Generator.Models
{
    public class Glossary
    {
        public Glossary()
        {
            Scope = new List<string>();
            Risks = new List<NameValue>();
            Efforts = new List<NameValue>();
            Definitions = new List<Definition>();
        }

        [JsonProperty("scope", Required = Required.Always)]
        public List<string> Scope { get; set; }

        [JsonProperty("risks", Required = Required.Always)]
        public List<NameValue> Risks { get; set; }

        [JsonProperty("efforts", Required = Required.Always)]
        public List<NameValue> Efforts { get; set; }

        [JsonProperty("definitions", Required = Required.Always)]
        public List<Definition> Definitions { get; set; }

    }
}

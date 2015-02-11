using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CodeDocs.Generator.Models
{
    public class NameValue
    {

        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public int Value { get; set; }

    }
}

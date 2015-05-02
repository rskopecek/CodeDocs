using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;

namespace CodeDocs.Evaluation
{
    public class Policy
    {

        public List<Rule> Evaluations { get; set; }

    }

    public interface IPolicy
    {
        string PostResultsToUrl { get; }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Evaluation
{
    public class Rule
    {

        public string Id { get; set; }

        public Risk? MinimumRisk { get; set; }
        public Risk? MaximumRisk { get; set; }
        public Risk? AbsoluteRisk { get; set; }

        public Effort? MinimumEffort { get; set; }
        public Effort? MaximumEffort { get; set; }
        public Effort? AbsoluteEffort { get; set; }

    }
}

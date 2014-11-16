using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Definitions.v2
{
    public class LocationDefinition : Definition
    {
        public LocationDefinition()
            : base(
                "Location", false,
                Risk.Low,
                Effort.Unknown,
                "Piece of code that appears to be in the wrong place.",
                "Meaning")
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Definitions.v2
{

    public enum Risk
    {
        None = 0,
        Low = 3,
        Moderate = 21,
        High = 89,
        Extreme = 144
    }

    public enum Effort
    {
        None = 0,
        VerySmall = 1,
        Small = 8,
        Medium = 34,
        Large = 55,
        VeryLarge = 89,
        Unknown = 144
    }

    public static class Constants
    {
        public const AttributeTargets AttributeScope =
            AttributeTargets.Class | AttributeTargets.Struct | 
            AttributeTargets.Interface | AttributeTargets.Enum |
            AttributeTargets.Delegate | AttributeTargets.Event | 
            AttributeTargets.Field | AttributeTargets.Property |
            AttributeTargets.Constructor | AttributeTargets.Method;

    }

}

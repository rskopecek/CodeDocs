using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDocs.Usage.Tests
{
    [Naming("Class 1 doesn't provided any meaning to the functionality provided")]
    public class Class1
    {
        [Toxic("Whatever you do don't change below or the whole system state will crash")]
        private class abc
        {
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDocs.Tests.AttributeUsage
{

    [Bug("comment")]
    [Bug("comment", Risk.None)]
    [Bug("comment", Effort.None)]
    [Bug("comment", 20010203)]
    [Bug("comment", Risk.None, Effort.None)]
    [Bug("comment", Risk.None, 20010203)]
    [Bug("comment", Effort.None, 20010203)]
    [Bug("comment", Risk.None, Effort.None, 20010203)]
    [Bug("comment", "tag", "http://stackoverflow.com")]
    [Bug("comment", Risk.None, "tag", "http://stackoverflow.com")]
    [Bug("comment", Effort.None, "tag", "http://stackoverflow.com")]
    [Bug("comment", 20010203, "tag", "http://stackoverflow.com")]
    [Bug("comment", Risk.None, Effort.None, "tag", "http://stackoverflow.com")]
    [Bug("comment", Risk.None, 20010203, "tag", "http://stackoverflow.com")]
    [Bug("comment", Effort.None, 20010203, "tag", "http://stackoverflow.com")]
    [Bug("comment", Risk.None, Effort.None, 20010203, "tag", "http://stackoverflow.com")]
    public class ConstructorUsage
    {
    }

}

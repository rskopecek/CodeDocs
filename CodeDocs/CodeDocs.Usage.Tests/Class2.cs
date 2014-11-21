using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDocs.Usage.Tests
{
    [Feature("Class2 brings awesome functionality you can't live without")]
    class Class2
    {
        [Insecure("Oh no", 
            "http://www.troyhunt.com/2013/07/how-to-build-and-how-not-to-build.html", 
            "http://stackoverflow.com/questions/4070693/what-is-the-purpose-of-base-64-encoding-and-why-it-used-in-http-basic-authentica")]
        private string Encrypt(byte[] data)
        {
            return Convert.ToBase64String(data);
        }
    }
}

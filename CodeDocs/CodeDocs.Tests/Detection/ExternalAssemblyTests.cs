using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CodeDocs.Tests.Detection
{
    public class ExternalAssemblyTests
    {

        [Fact]
        public void Can_Detect_All_Attributes_In_External_Assembly()
        {
            var assembly = typeof (Usage.Tests.Class1).Assembly;

            var results = assembly.GetCodeDocs().GetAllDetections();

            Assert.Equal(4, results.Count);
        }

    }
}

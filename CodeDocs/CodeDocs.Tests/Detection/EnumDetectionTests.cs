using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CodeDocs.Tests.Detection
{
    public class EnumDetectionTests
    {
        [Fact]
        public void Can_Detect_Attributes_On_Enum()
        {
            typeof(EnumDetectionExample).Detect().AssertExpectations(2);
        }

    }

    [Bug("1")]
    public enum EnumDetectionExample
    {
        [Bug("2")]
        A
    };
}

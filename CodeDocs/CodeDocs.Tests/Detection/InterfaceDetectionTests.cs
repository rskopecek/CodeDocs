using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CodeDocs.Tests.Detection
{
    public class InterfaceDetectionTests
    {

        [Fact]
        public void Detection_Of_publicInstanceDetectionExampleInterface() { typeof(publicDetectionExampleInterface).GetCodeDocs().AssertExpectations(4); }

        [Fact]
        public void Detection_Of_internalInstanceDetectionExampleInterface() { typeof(internalDetectionExampleInterface).GetCodeDocs().AssertExpectations(4); }


        public delegate string D();


    }

    [Bug("1")]
    public interface publicDetectionExampleInterface
    {

        [Bug("2")]
        string P2 { get; set; }
        [Bug("3")]
        event InterfaceDetectionTests.D Ev3;
        [Bug("4")]
        void M4();
    }

    [Bug("1")]
    internal interface internalDetectionExampleInterface
    {

        [Bug("2")]
        string P2 { get; set; }
        [Bug("3")]
        event InterfaceDetectionTests.D Ev3;
        [Bug("4")]
        void M4();
    }
}

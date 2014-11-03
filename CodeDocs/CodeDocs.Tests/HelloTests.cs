using System;
using System.CodeDom;
using Xunit;

namespace CodeDocs.Tests
{

    public class HelloTests
    {
        [Fact]
        public void HelloWorld()
        {
            var result = CodeDocs.Hello.World();

            Assert.Equal("Howdy", result);
        }
    }
}

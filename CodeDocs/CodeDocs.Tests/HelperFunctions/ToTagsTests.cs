using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CodeDocs.Helpers;

namespace CodeDocs.Tests.HelperFunctions
{
    public class ToTagsTests
    {

        [Fact]
        public void Tags_Split_When_Comma_Present()
        {
            const string value = "a,b";

            var result = value.ToTags();

            Assert.Equal(2, result.Count());
            Assert.Equal("a", result[0]);
            Assert.Equal("b", result[1]);
        }


        [Fact]
        public void Tags_Split_When_CommaSpace_Present()
        {
            const string value = "a, b";

            var result = value.ToTags();

            Assert.Equal(2, result.Count());
            Assert.Equal("a", result[0]);
            Assert.Equal("b", result[1]);
        }

        [Fact]
        public void Tags_Return_Empty_Array_If_String_Is_Empty()
        {
            string value = string.Empty;

            var result = value.ToTags();

            Assert.Equal(0, result.Count());
        }

        [Fact]
        public void Tags_Return_Empty_Array_If_String_Is_Null()
        {
            string value = null;

            var result = value.ToTags();

            Assert.Equal(0, result.Count());
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CodeDocs.Helpers;

namespace CodeDocs.Tests.HelperFunctions
{
    public class ToDate_Tests
    {

        [Fact]
        public void Creates_Proper_DateTime_From_Valid_Date()
        {
            const int value = 20010203;

            var result = value.ToDate();

            Assert.Equal(2001, result.Year);
            Assert.Equal(2, result.Month);
            Assert.Equal(3, result.Day);
        }

        [Fact]
        public void Throw_FormatException_For_Invalid_Date()
        {
            const int value = -20010203;

            Assert.Throws<FormatException>(() => value.ToDate());
        }

        [Fact]
        public void NullableInt_Creates_Proper_DateTime_From_Valid_Date()
        {
            int? value = 20010203;

            var result = value.ToDate();

            Assert.True(result.HasValue);

            Assert.Equal(2001, result.Value.Year);
            Assert.Equal(2, result.Value.Month);
            Assert.Equal(3, result.Value.Day);
        }

        [Fact]
        public void NullableInt_Throw_FormatException_For_Invalid_Date()
        {
            int? value = -20010203;

            Assert.Throws<FormatException>(() => value.ToDate());
        }

        [Fact]
        public void NullableInt_Returns_Null_If_Null_Provided()
        {
            int? value = null;

            var result = value.ToDate();

            Assert.False(result.HasValue);
        }

    }
}

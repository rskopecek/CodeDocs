using System;
using CodeDocs;
using Xunit;


namespace CodeDocs.Tests.Parsing
{
    
    public class ParseNullable
    {
        [Fact]
        public void ReturnsNullForMinValue()
            => Assert.Null(long.MinValue.ParseNullable());

        [Fact]
        public void ReturnsValueMinPlus1()
            => Assert.Equal((long.MinValue + 1), (long.MinValue + 1).ParseNullable());

        [Theory, InlineData(-5), InlineData(0), InlineData(5), InlineData(long.MaxValue)]
        public void ReturnValueAsIs(long value)
            => Assert.Equal(value, value.ParseNullable());
    }

    public class ParseNullableIsoDate
    {
                
        [Fact]
        public void ReturnsDateForYYYYMMDD()
            => Assert.Equal(new DateTime(2019,1,1), int.Parse((new DateTime(2019, 1, 1)).ToString("yyyyMMdd")).ParseNullableIsoDate());

        [Theory, InlineData(0), InlineData(int.MinValue), InlineData(-1), InlineData(2019_02_31)]
        public void ImproperDatesReturnDateMin(int value)
            => Assert.Equal(DateTime.MinValue.Date, value.ParseNullableIsoDate());
    }

    public class ParseTags
    {

        [Theory]
        [InlineData("a,b,c", "a,b,c")]
        [InlineData("a b,c", "a b,c")]
        public void CanParseTags(string expected, string actual)
            => Assert.Equal(expected, string.Join(',', actual.ParseTags()));

        [Fact]
        public void TrimsSurroundingSpaces()
            => Assert.Equal("a,b" , string.Join(',', " a , b ".ParseTags()));

        [Theory, InlineData(""), InlineData(" ")]
        public void EmptyStringReturnsEmptyEnumerable(string value)
            => Assert.Empty(value.ParseTags());

    }

}

using System;
using System.Linq;
using System.Collections.Generic;
using CodeDocs;
using CodeDocs.Examples.Generated;
using CodeDocs.Detection;
using Xunit;


namespace CodeDocs.Tests
{
    public class CheckGenerated
    {

        List<FlatDoc> docs = 
            typeof(PrimaryType).Assembly.GetCodeDocs()
            .AllDocs().Flatten().Where(e=> int.TryParse(e.Att.Comment, out int r))
            .OrderBy(e => int.Parse(e.Att.Comment)).ToList();

        [Fact]
        public void SummaryCountMatchesGenerated()
        {
            Assert.Equal(Summary.ItemCount, docs.Count);
        }

        [Fact]
        public void EachItemIdentifiedOnlyOnce()
        {
            for (var x = 1; x <= Summary.ItemCount; x++)
                Assert.Equal(1, docs.Count(q => int.Parse(q.Att.Comment) == x));
        }

        }
}

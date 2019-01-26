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

        List<ICodeDoc> docs = typeof(PrimaryType).Assembly
                                .GetCodeDocs(t => t.Namespace.Contains("CodeDocs.Examples.Generated"))
                                .OrderBy(e => int.Parse(e.Comment)).ToList();

        [Fact]
        public void SummaryCountMatchesGenerated()
        {
            Assert.Equal(Summary.ItemCount, docs.Count);
        }

        [Fact]
        public void EachItemIdentifiedOnlyOnce()
        {
            for (var x = 1; x <= Summary.ItemCount; x++)
                Assert.Equal(1, docs.Count(q => int.Parse(q.Comment) == x));
        }

        }
}

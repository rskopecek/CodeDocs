using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CodeDocs.Tests.Detection
{
    public static class DetectionTestUtilities
    {


        public static void AssertDetect(this Type type, int amount)
        {
            var results = type.Detect();

            results.AssertExpectations(amount);
        }

        public static void AssertExpectations(this IEnumerable<CodeDocs.Detection> detections, params string[] expectations)
        {
            var results = detections.Select(i => i.Info.Details).ToList();

            Assert.Equal(expectations.Count(), results.Count);

            foreach (var expectation in expectations)
            {
                Assert.True(results.Contains(expectation));
            }
        }


        public static void AssertExpectations(this IEnumerable<CodeDocs.Detection> detections, int expectationCount)
        {
            var results = detections.Select(i => i.Info.Details).ToList();

            Assert.Equal(expectationCount, results.Count);

            for (int x = 1; x <= expectationCount; x++)
            {
                Assert.True(results.Contains(x.ToString()));
            }

        }

    }
}

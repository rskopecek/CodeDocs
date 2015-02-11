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

        public static void AssertExpectations(this IDetectionScope detections, int expectationCount)
        {
            
            var results = detections.GetAllDetections().Select(i => i.Details).ToList();

            Assert.Equal(expectationCount, results.Count);

            for (int x = 1; x <= expectationCount; x++)
            {
                Assert.True(results.Contains(x.ToString()));
            }

        }

    }
}

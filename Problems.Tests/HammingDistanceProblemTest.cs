using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Problems.Tests
{
    public class HammingDistanceProblemTest
    {
        private readonly HammingDistanceProblem _problem;
        public HammingDistanceProblemTest()
        {
            _problem = new HammingDistanceProblem();
        }

        [Fact]
        public void Test1()
        {
            int x = 1;
            int y = 4;

            var result = _problem.HammingDistance(x, y);
            Assert.Equal(2, result);
        }
    }
}

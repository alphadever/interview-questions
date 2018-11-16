using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Problems.Tests
{
    public class OrphanIntInArrayProblemTest
    {
        private readonly OrphanIntInArrayProblem _problem;

        public OrphanIntInArrayProblemTest()
        {
            _problem = new OrphanIntInArrayProblem();
        }

        [Fact]
        public void Test1()
        {
            int[] input = new int[]{2,2,1};

            var result = _problem.SingleNumber(input);
            var result2 = _problem.SingleNumber2(input);
            Assert.Equal(1, result);
            Assert.Equal(1, result2);
        }

        [Fact]
        public void Test2()
        {
            int[] input = new int[] { 4,1,2,1,2 };

            var result = _problem.SingleNumber(input);
            var result2 = _problem.SingleNumber2(input);
            Assert.Equal(4, result);
            Assert.Equal(4, result2);
        }
    }
}

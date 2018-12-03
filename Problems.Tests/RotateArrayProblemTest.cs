using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Problems.Tests
{
    public class RotateArrayProblemTest
    {
        private readonly RotateArrayProblem _problem;

        public RotateArrayProblemTest()
        {
            _problem = new RotateArrayProblem();
        }

        [Fact]
        public void Test1()
        {
            int k = 3;
            int[] input = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int[] res = new int[] { 5, 6, 7, 1, 2, 3, 4 };

            var result = _problem.Rotate(input, k);
            Assert.Equal(res, result);
        }

        [Fact]
        public void Test2()
        {
            int k = 2;
            int[] input = new int[] { -1, -100, 3, 99 };
            int[] res = new int[] { 3, 99, -1, -100};

            var result = _problem.Rotate(input, k);
            Assert.Equal(res, result);
        }

        [Fact]
        public void Test3()
        {
            int k = 2;
            int[] input = new int[] { -1, 3};
            int[] res = new int[] { -1, 3, };

            var result = _problem.Rotate(input, k);
            Assert.Equal(res, result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Problems.Tests
{
    public class TwoArrayIntersectionProblemTest
    {
        private readonly TwoArrayIntersectionProblem _problem;

        public TwoArrayIntersectionProblemTest()
        {
            _problem = new TwoArrayIntersectionProblem();
        }

        [Fact]
        public void Test1()
        {
            int[] input1 = new int[] { 1, 2, 2, 1 };
            int[] input2 = new int[] { 2, 2 };

            int[] exp = new int[] { 2, 2 };
            int[] result = _problem.Intersect1(input1, input2);

            Assert.Equal(result, exp);
        }

        [Fact]
        public void Test2()
        {
            int[] input1 = new int[] { 4, 9, 5 };
            int[] input2 = new int[] { 9, 4, 9, 8, 4 };

            int[] exp = new int[] { 9, 4};
            int[] result = _problem.Intersect1(input1, input2);

            Assert.Equal(result, exp);
        }

        [Fact]
        public void Test3()
        {
            int[] input1 = new int[] { 4 };
            int[] input2 = new int[] { 9, 4, 9, 8, 4 };

            int[] exp = new int[] { 4 };
            int[] result = _problem.Intersect1(input1, input2);

            Assert.Equal(result, exp);
        }

        [Fact]
        public void Test4()
        {
            int[] input1 = new int[] { 4, 9, 5 };
            int[] input2 = new int[] { 9 };

            int[] exp = new int[] { 9 };
            int[] result = _problem.Intersect1(input1, input2);

            Assert.Equal(result, exp);
        }
    }
}

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
            int[] input = new int[] { 1, 2, 3, 4, 5, 6};
            int[] res = new int[] {4, 5, 6, 1, 2, 3};

            _problem.Rotate4(input, k);
            Assert.Equal(res, input);
        }

        [Fact]
        public void Test2()
        {
            int k = 2;
            int[] input = new int[] { -1, -100, 3, 99 };
            int[] res = new int[] { 3, 99, -1, -100 };

            _problem.Rotate(input, k);
            Assert.Equal(res, input);
        }

        [Fact]
        public void Test3()
        {
            int k = 14;
            int[] input = new int[] { -1, 3 };
            int[] res = new int[] { -1, 3, };

            _problem.Rotate(input, k);
            Assert.Equal(res, input);
        }

        [Fact]
        public void Test4()
        {
            int k = 29;
            int[] input = new int[] { -1, 3 };
            int[] res = new int[] { 3, -1 };

            _problem.Rotate(input, k);
            Assert.Equal(res, input);
        }

        [Fact]
        public void Test5()
        {
            int k = 10;
            int[] input = new int[] { -1};
            int[] res = new int[] { -1,};

            _problem.Rotate(input, k);
            Assert.Equal(res, input);
        }

        [Fact]
        public void Test6()
        {
            int k = 21;
            int[] input = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int[] res = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            _problem.Rotate(input, k);
            Assert.Equal(res, input);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Problems.Tests
{
    public class IntArrayPlusOneProblemTest
    {
        private readonly IntArrayPlusOneProblem _problem;

        public IntArrayPlusOneProblemTest()
        {
            _problem = new IntArrayPlusOneProblem();
        }

        [Fact]
        public void Test1()
        {
            int[] input = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] exp = new int[] { 1, 2, 3, 4, 5, 7 };

            var res = _problem.PlusOne(input);
            Assert.Equal(res, exp);
        }

        [Fact]
        public void Test2()
        {
            int[] input = new int[] { 1, 2, 3, 4, 5, 9 };
            int[] exp = new int[] { 1, 2, 3, 4, 6, 0 };

            var res = _problem.PlusOne(input);
            Assert.Equal(res, exp);
        }

        [Fact]
        public void Test3()
        {
            int[] input = new int[] { 1, 2, 9, 9, 9, 9 };
            int[] exp = new int[] { 1, 3, 0, 0, 0, 0 };

            var res = _problem.PlusOne(input);
            Assert.Equal(res, exp);
        }

        [Fact]
        public void Test4()
        {
            int[] input = new int[] { 9, 9, 9, 9, 9, 9 };
            int[] exp = new int[] {1 ,0, 0, 0, 0, 0, 0 };

            var res = _problem.PlusOne(input);
            Assert.Equal(res, exp);
        }
    }
}

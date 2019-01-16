using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Problems.Tests
{
    public class MoveZerosProblemTest
    {
        private readonly MoveZerosProblem _problem;

        public MoveZerosProblemTest()
        {
            _problem = new MoveZerosProblem();
        }

        [Fact]
        public void Test1()
        {
            int[] input = new int[] { 0, 1, 0, 3, 12 };
            _problem.MoveZeroes(input);
            int[] response = new int[] { 1, 3, 12, 0, 0 };
            Assert.Equal(response, input);
        }

        [Fact]
        public void Test2()
        {
            int[] input = new int[] { 0, 1, 0, 3, 12, 0, 0 };
            _problem.MoveZeroes(input);
            int[] response = new int[] { 1, 3, 12, 0, 0, 0, 0 };
            Assert.Equal(response, input);
        }

        [Fact]
        public void Test3()
        {
            int[] input = new int[] { 0, 0 };
            _problem.MoveZeroes(input);
            int[] response = new int[] { 0, 0};
            Assert.Equal(response, input);
        }
    }
}

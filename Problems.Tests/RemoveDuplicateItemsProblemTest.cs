using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Problems.Tests
{
    public class RemoveDuplicateItemsProblemTest
    {
        private readonly RemoveDuplicateItemsProblem _problem;

        public RemoveDuplicateItemsProblemTest()
        {
            _problem = new RemoveDuplicateItemsProblem();
        }

        [Fact]
        public void Test1()
        {
            int[] input = new int[] { 1, 1, 2 };

            var result = _problem.RemoveDuplicates(input);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Test2()
        {
            int[] input = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

            var result = _problem.RemoveDuplicates(input);
            Assert.Equal(5, result);
        }
    }
}

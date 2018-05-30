using System;
using Xunit;
using Problems;

namespace Problems.Tests
{
    public class MagicGridProblemTest
    {
        private readonly MagicGridProblem _problem;

        public MagicGridProblemTest()
        {
            _problem = new MagicGridProblem();
        }

        [Fact]
        public void Test1()
        {
            int[][] input = new int[][]{
                new int[]{3,10,2,3,4},
                new int[]{4,5,6,8,1},
                new int[]{8,8,1,6,8},
                new int[]{1,3,5,7,1},
                new int[]{9,4,9,2,9},
            };

            var result = _problem.NumMagicSquaresInside(input);
            Assert.Equal(1, result);
        }
    }
}

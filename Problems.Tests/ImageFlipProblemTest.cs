using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Problems.Tests
{
    public class ImageFlipProblemTest
    {
        private readonly ImageFlipProblem _problem;

        public ImageFlipProblemTest()
        {
            _problem = new ImageFlipProblem();
        }

        [Fact]
        public void Test1()
        {
            int[][] input = new int[][]{
                new int[]{1,1,0},
                new int[]{1,0,1},
                new int[]{0,0,0}
            };

            int[][] output = new int[][]{
                new int[]{1,0,0},
                new int[]{0,1,0},
                new int[]{1,1,1}
            };

            var result = _problem.FlipAndInvertImage(input);
            Assert.Equal(output, result);
        }

        [Fact]
        public void Test2()
        {
            int[][] input = new int[][]{
                new int[]{1,1,0,0},
                new int[]{1,0,0,1},
                new int[]{0,1,1,1},
                new int[]{1,0,1,0},
            };

            int[][] output = new int[][]{
                new int[]{1,1,0,0},
                new int[]{0,1,1,0},
                new int[]{0,0,0,1},
                new int[]{1,0,1,0},
            };

            var result = _problem.FlipAndInvertImage(input);
            Assert.Equal(output, result);
        }

        [Fact]
        public void Test3()
        {
            int[][] input = new int[][]{
                new int[]{1,1}
            };

            int[][] output = new int[][]{
                new int[]{0,0}
            };

            var result = _problem.FlipAndInvertImage(input);
            Assert.Equal(output, result);
        }

        [Fact]
        public void Test4()
        {
            int[][] input = new int[][]{
                new int[]{1}
            };

            int[][] output = new int[][]{
                new int[]{0}
            };

            var result = _problem.FlipAndInvertImage(input);
            Assert.Equal(output, result);
        }
    }
}

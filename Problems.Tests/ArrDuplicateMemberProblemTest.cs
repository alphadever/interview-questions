using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Problems.Tests
{
    public class ArrDuplicateMemberProblemTest
    {
        private readonly ArrDuplicateMemberProblem _problem;

        public ArrDuplicateMemberProblemTest()
        {
            _problem = new ArrDuplicateMemberProblem();
        }

        [Fact]
        public void Test1()
        {
            int[] input = new int[] { 1, 2, 3, 1};
            var exp = true;
            var res =  _problem.ContainsDuplicate(input);
            Assert.Equal(res, exp);
        }


        [Fact]
        public void Test2()
        {
            int[] input = new int[] { 1, 2, 3, 4 };
            var exp = false;
            var res = _problem.ContainsDuplicate(input);
            Assert.Equal(res, exp);
        }


        [Fact]
        public void Test3()
        {
            int[] input = new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            var exp = true;
            var res = _problem.ContainsDuplicate(input);
            Assert.Equal(res, exp);
        }

        [Fact]
        public void Test4()
        {
            int[] input = new int[] { 1};
            var exp = false;
            var res = _problem.ContainsDuplicate(input);
            Assert.Equal(res, exp);
        }
    }
}

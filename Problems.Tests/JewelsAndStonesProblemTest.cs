using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Problems.Tests
{
    public class JewelsAndStonesProblemTest
    {
        private readonly JewelsAndStonesProblem _problem;
        public JewelsAndStonesProblemTest()
        {
            _problem = new JewelsAndStonesProblem();
        }

        [Fact]
        public void Test1()
        {
            string J = "aA";
            string S = "aAAbbbbsadverfrerafevdfvAAAAAAAdwedew";

            var result = _problem.NumJewelsInStones(J,S);
            Assert.Equal(12, result);
        }

        [Fact]
        public void Test2()
        {
            string J = "z";
            string S = "ZZ";

            var result = _problem.NumJewelsInStones(J, S);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test3()
        {
            string J = "aA";
            string S = "aAAbbbbsadverfrerafevdfvAAAAAAAdwedew";

            var result = _problem.NumJewelsInStones2(J, S);
            Assert.Equal(12, result);
        }

        [Fact]
        public void Test4()
        {
            string J = "z";
            string S = "ZZ";

            var result = _problem.NumJewelsInStones2(J, S);
            Assert.Equal(0, result);
        }
    }
}

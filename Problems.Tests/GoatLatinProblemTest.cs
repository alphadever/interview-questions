using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Problems.Tests
{
    public class GoatLatinProblemTest
    {
        private readonly GoatLatinProblem _problem;

        public GoatLatinProblemTest()
        {
            _problem = new GoatLatinProblem();
        }

        [Fact]
        public void Test1()
        {
            string input_1 = "I speak Goat Latin";
            string output_1 = "Imaa peaksmaaa oatGmaaaa atinLmaaaaa";
            var result = _problem.ToGoatLatin(input_1);
            Assert.Equal(output_1, result);
        }

        [Fact]
        public void Test2()
        {
            string input_1 = "The quick brown fox jumped over the lazy dog";
            string output_1 = "heTmaa uickqmaaa rownbmaaaa oxfmaaaaa umpedjmaaaaaa overmaaaaaaa hetmaaaaaaaa azylmaaaaaaaaa ogdmaaaaaaaaaa";
            var result = _problem.ToGoatLatin(input_1);
            Assert.Equal(output_1, result);
        }
    }
}

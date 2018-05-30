using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Problems.Tests
{
    public class KeysRoomsProblemTest
    {
        private readonly KeysRoomsProblem _problem;

        public KeysRoomsProblemTest()
        {
            _problem = new KeysRoomsProblem();
        }

        [Fact]
        public void Test1()
        {

            IList<IList<int>> input = new List<IList<int>>()
            {
                new List<int>(){1,3},
                new List<int>(){3,0,1},
                new List<int>(){2},
                new List<int>(){0},
            };

            var result = _problem.CanVisitAllRooms(input);
            //Assert.Equal(1, result);
        }
    }
}

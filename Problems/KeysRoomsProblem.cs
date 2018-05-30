using System;
using System.Collections.Generic;
using System.Text;

namespace Problems
{
    public class KeysRoomsProblem
    {


        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            Stack<int> keyStack = new Stack<int>();
            keyStack.Push(0);
            bool[] roomsVisited = new bool[rooms.Count];

            while(keyStack.Count > 0)
            {
                var n = keyStack.Pop();
                foreach (var key in rooms[n])
                {
                    if(!roomsVisited[key])
                    {
                        keyStack.Push(key);
                        roomsVisited[key] = true;
                    }
                }
            }

            foreach (var room in roomsVisited)
            {
                if(!room)
                    return true;
            }
           return false;
        }
    }
}

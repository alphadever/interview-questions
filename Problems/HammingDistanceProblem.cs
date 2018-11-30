using System;
using System.Collections.Generic;
using System.Text;

namespace Problems
{
    public class HammingDistanceProblem
    {
        public int HammingDistance(int x, int y)
        {
            Int32 cnt = 0;
            Int32 res = x ^ y;
            foreach (Char c in Convert.ToString(res,2))
            {
                if(c.Equals('1'))
                    cnt++;
            }
            return cnt;
        }
    }
}

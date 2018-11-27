using System;
using System.Collections.Generic;
using System.Text;

namespace Problems
{
    /*
        You're given strings J representing the types of stones that are jewels, and S representing the stones you have.  
        Each character in S is a type of stone you have.  You want to know how many of the stones you have are also jewels.

        The letters in J are guaranteed distinct, and all characters in J and S are letters. Letters are case sensitive, 
        so "a" is considered a different type of stone from "A".

        Example 1:

        Input: J = "aA", S = "aAAbbbb"
        Output: 3
        Example 2:

        Input: J = "z", S = "ZZ"
        Output: 0
        Note:

        S and J will consist of letters and have length at most 50.
        The characters in J are distinct.
     */

    public class JewelsAndStonesProblem
    {
        public int NumJewelsInStones(string J, string S)
        {
            byte cnt = 0;

            foreach (char s in S)
            {
                foreach (char j in J)
                {
                    if(s.Equals(j))
                    {
                        cnt++;
                        break;
                    }
                }
            }
            return cnt;
        }

        public int NumJewelsInStones2(string J, string S)
        {
            int cnt = 0;
            HashSet<Char> jHash = new HashSet<Char>();
            foreach (char j in J)
            {
                jHash.Add(j);
            }
            foreach (char s in S)
            {
                if(jHash.Contains(s))
                    cnt++;
            }
            return cnt;
        }
    }
}

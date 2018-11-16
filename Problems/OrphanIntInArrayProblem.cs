using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problems
{
    /* Given a non-empty array of integers, every element appears twice except for one. Find that single one.
        Note:
        Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?*/
    public class OrphanIntInArrayProblem
    {
        Hashtable countTbl = new Hashtable();
        Stack<int> stack = new Stack<int>();
        public int SingleNumber(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if(countTbl.Contains(nums[i]))
                {
                    countTbl[nums[i]] = (int)countTbl[nums[i]] + 1;
                }
                else
                    countTbl.Add(nums[i],0);
            }

            foreach (DictionaryEntry item in countTbl)
            {
                if((int)item.Value == 0)
                    return (int)item.Key;
            }
            return -100000;
        }

        public int SingleNumber2(int[] nums)
        {
            int a = 0;
            foreach (int num in nums)
            {
                a ^= num;
            }
            return a;
        }
    }
}

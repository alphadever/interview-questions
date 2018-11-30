using System;
using System.Collections.Generic;
using System.Text;

namespace Problems
{
    public class MoveZerosProblem
    {
        public void MoveZeroes(int[] nums)
        {
            Stack<int> s = new Stack<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i].Equals(0))
                {
                    s.Push(nums[nums.Length - i]);
                    nums[nums.Length - i] = nums[i];
                }
            }
        }

        public void ShiftToLeft(int[] nums, int i = 0)
        {
            while(i < nums.Length)
            {

            }
        }
    }
}

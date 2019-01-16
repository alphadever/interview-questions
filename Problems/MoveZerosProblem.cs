using System;
using System.Collections.Generic;
using System.Text;

namespace Problems
{
    public class MoveZerosProblem
    {
        public void MoveZeroes(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return;

            int index = 0;
            foreach (var item in nums)
            {
                if (item != 0)
                {
                    nums[index++] = item;
                }
            }
            for (int i = 0; i < nums.Length - index; i++)
            {
                nums[nums.Length - i - 1] = 0;
            }
        }
    }
}

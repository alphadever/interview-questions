using System;
using System.Collections.Generic;
using System.Text;

namespace Problems
{
    public class RemoveDuplicateItemsProblem
    {
        public int RemoveDuplicates(int[] nums)
        {
            if(nums.Length < 2)
                return nums.Length;

            int cnt = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (!nums[i].Equals(nums[i - 1]))
                {
                    nums[cnt] = nums[i];
                    cnt++;
                }
            }
            return cnt + 1;
        }
    }
}

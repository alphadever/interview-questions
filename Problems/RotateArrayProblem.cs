using System;
using System.Collections.Generic;
using System.Text;

namespace Problems
{
    public class RotateArrayProblem
    {
        public int[] Rotate(int[] nums, int k)
        {
            int[] ans = new int[nums.Length];
            for (int i = 0; i < k; i++)
            {
                ans[i] = nums[nums.Length - k + i];
            }
            for (int i = 0; i < k + 1; i++)
            {
                if (k + i > ans.Length - 1)
                    break;
                ans[k + i] = nums[i];
            }
            return ans;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Problems
{
    public class RotateArrayProblem
    {
        // solution 1:
        public void Rotate(int[] nums, int k)
        {
            k = k % nums.Length;
            Inverse(nums, 0, nums.Length - k - 1);
            Inverse(nums, nums.Length - k, nums.Length - 1);
            Inverse(nums, 0, nums.Length - 1);            
        }

        private void Inverse(int[] nums, int i, int j)
        {
            while(i < j)
            {
                var temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
                i++;
                j--;
            }
        }

        // solution 2:
        public void Rotate2(int[] nums, int k)
        {
            int temp, previous;
            for (int i = 0; i < k; i++)
            {
                previous = nums[nums.Length - 1];
                for (int j = 0; j < nums.Length; j++)
                {
                    temp = nums[j];
                    nums[j] = previous;
                    previous = temp;
                }
            }
        }

        //solution 3:
        public void Rotate3(int[] nums, int k)
        {
            int[] a = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                a[(i + k) % nums.Length] = nums[i];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = a[i];
            }
        }

        //solution 4:
        public void Rotate4(int[] nums, int k)
        {
            k = k % nums.Length;
            int count = 0;
            for (int start = 0; count < nums.Length; start++)
            {
                int current = start;
                int prev = nums[start];
                do
                {
                    int next = (current + k) % nums.Length;
                    int temp = nums[next];
                    nums[next] = prev;
                    prev = temp;
                    current = next;
                    count++;
                } while (start != current);
            }
        }
    }
}

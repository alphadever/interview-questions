using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Problems
{
    public class TwoArrayIntersectionProblem
    {
        public int[] Intersect1(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            List<int> _out = new List<int>();

            foreach (var num in nums1)
            {
                if (dic.ContainsKey(num))
                    dic[num] += 1;
                else
                    dic.Add(num, 1);
            }

            foreach (var num in nums2)
            {
                if(dic.ContainsKey(num) && dic[num] > 0)
                {
                    _out.Add(num);
                    dic[num] -= 1;
                }
            }
            return _out.ToArray();
        }

        // 2nd soloution
        public int[] Intersect2(int[] nums1, int[] nums2)
        {
            ArrayList _out = new ArrayList();
            
            for (int i = 0, j = 0; i < nums1.Length && j < nums2.Length;)
            {
                if (nums1[i].Equals(nums2[i]))
                {
                    _out.Add(nums1[i]);
                    i++;
                    j++;
                }
                else if (nums1[i] < nums2[j])
                    i++;
                else
                    j++;
            }

            return _out.ToArray(typeof(int)) as int[];
        }
    }
}

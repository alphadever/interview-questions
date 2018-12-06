using System;
using System.Collections.Generic;
using System.Text;

namespace Problems
{
    public class ArrDuplicateMemberProblem
    {
        HashSet<int> h = new HashSet<int>();
        public bool ContainsDuplicate(int[] nums)
        {
            foreach (var num in nums)
            {
                if (!h.Contains(num))
                    h.Add(num);
                else
                    h.Remove(num);
            }

            return h.Count != nums.Length;
        }
    }
}

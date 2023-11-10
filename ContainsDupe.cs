using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeClassLibrary
{
    public class ContainsDupe
    {
        public bool ContainsDuplicate(int[] nums)
        {
            var d = new Dictionary<int, int>();
            foreach (int i in nums)
            {
                if (d.ContainsKey(i))
                {
                    return true;
                }
                d[i] = i;

            }

            return false;
        }
    }

}

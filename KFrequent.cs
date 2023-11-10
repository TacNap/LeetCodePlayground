using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeClassLibrary
{
    public class KFrequent
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            SortedDictionary<int, int> map = new SortedDictionary<int, int>();
            
            foreach (int i in nums)
            {
                if (!map.ContainsKey(i)) {
                    map.Add(i, 1);
                } else
                {
                    map[i]++;
                }
            }

            List<int> result = new List<int>();
            while(k > 0 & map.Count > 0)
            {
                int key = map.First().Key;
                result.Add(key);
                map.Remove(key);
                k--;
            }

            return result.ToArray();
        }
    }
}

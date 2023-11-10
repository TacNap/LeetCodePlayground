using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeClassLibrary
{
    public class Merger
    {
        /// <summary>
        /// Merge two, sorted arrays together
        /// </summary>
        /// <param name="nums1">First Array, includes padding 0's to account for `nums2` variables</param>
        /// <param name="m">length of nums1, non-inclusive of padded 0's</param>
        /// <param name="nums2">Second Array</param>
        /// <param name="n">length of nums2</param>
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            
            if (n == 0)
            {
                return;
            }
            
            int[] solution = new int[m + n];
            int i = 0;
            int j = 0;
            for(int N = 0; N < solution.Length; N++) {
                if (j == n || nums1[i] <= nums2[j] && i < m)
                {
                    solution[N] = nums1[i];
                    i++;
                } else
                {
                    solution[N] = nums2[j];
                    j++;
                }
            }

            for(int N = 0; N < nums1.Length; N++)
            {
                nums1[N] = solution[N];
            }
        }
    }
}

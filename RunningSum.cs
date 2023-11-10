using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeClassLibrary
{
    public class SumRunner
    {
        /// <summary>
        /// RunningSum
        /// </summary>
        /// <param name="nums"></param>
        /// <returns>Cumulative sum of integers in an array</returns>
        public int[] RunningSum(int[] nums)
        {
            int[] sum = new int[nums.Length];
            sum[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                sum[i] = nums[i] + sum[i - 1];
            }

            return sum;
        }
    }
}

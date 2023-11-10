using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeClassLibrary
{
    public class StairClimber
    {
        private int[] memo;

        /// <summary>
        /// ClimbStairs, Recursive function that is closely reminiscent of the Fibonacci sequence
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int ClimbStairs(int n)
        {

            memo = new int[n + 1];
            return ClimbStairsMemo(n);
        }

        private int ClimbStairsMemo(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else if (n == 2)
            {
                return 2;
            }
            else
            {
                if (memo[n] > 0)
                {
                    return memo[n];
                }

                memo[n] = ClimbStairsMemo(n - 1) + ClimbStairsMemo(n - 2);
                return memo[n];
            }
        }
    }
}

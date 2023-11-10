using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeClassLibrary
{
    public class MaxWealth
    {
        /// <summary>
        /// Given the wealth of individuals across multiple bank accounts
        /// return whomever is the wealthiest
        /// </summary>
        /// <param name="accounts"></param>
        /// <returns>max, largest account sum</returns>
        public int MaximumWealth(int[][] accounts)
        {
            //C# Has a .Sum keyword for arrays.
            //So, you can actually just iterate through each array and use accounts[i].Sum()
            int max = 0;
            int current = 0;
            for (int i = 0; i < accounts.Length; i++)
            {
                for (int j = 0; j < accounts[i].Length; j++)
                {
                    current += accounts[i][j];
                }
                if (current > max)
                {
                    max = current;
                }
                current = 0;
            }

            return max;
        }
    }
}

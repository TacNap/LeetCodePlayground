using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeClassLibrary
{
    public class Product
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            List<int> result = new List<int>();

            int leftMulti = 1;
            int rightMulti = 1;

            for(int i = 0; i < nums.Length; i++)
            {
                if (i == 0) left.Add(1);
                leftMulti *= nums[i];
                left.Add(leftMulti);
            }

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (i == nums.Length - 1) right.Add(1);
                rightMulti *= nums[i];
                right.Add(rightMulti);
            }

            for (int i = 0; i < nums.Length; i++)
                result.Add(left[i] * right[nums.Length - 1 - i]);

            return result.ToArray();
        }
    }
}

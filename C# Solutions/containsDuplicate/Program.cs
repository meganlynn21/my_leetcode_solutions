
using System;
using System.Collections.Generic;
using System.Linq;



namespace pract
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] numbers = new int[4] { 1, 2, 3, 1 };
            solution.ContainsDuplicate(numbers);
        }

        public class Solution
        {
            public bool ContainsDuplicate(int[] nums)
            {
                var frequency = new HashSet<int>();

                for (int i = 0; i < nums.Length; i++)
                {
                    if (frequency.Contains(nums[i]))
                        return true;

                    frequency.Add(nums[i]);
                }
                return false;
            }
        }




    }

}








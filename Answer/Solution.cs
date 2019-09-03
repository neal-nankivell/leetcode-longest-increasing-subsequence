using System;
using System.Collections.Generic;

namespace Answer
{
    public class Solution
    {
        /*
        Given an unsorted array of integers,
        find the length of longest increasing subsequence.

        Example:
        Input: [10,9,2,5,3,7,101,18]
        Output: 4 
        Explanation: The longest increasing subsequence is
        [2,3,7,101], therefore the length is 4.

        Note:
        There may be more than one LIS combination,
        it is only necessary for you to return the length.
        Your algorithm should run in O(n2) complexity.
        Follow up: Could you improve it to O(n log n) time complexity?
         */
        public int LengthOfLIS(int[] nums)
        {
            if (nums.Length == 0) { return 0; }

            List<Tuple<int, int>> memo = new List<Tuple<int, int>>();
            memo.Add(new Tuple<int, int>(nums[0], 1));

            int overalMaxLength = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                var max = 0;
                for (int j = 0; j < i; j++)
                {
                    if (memo[j].Item1 < nums[i] && memo[j].Item2 > max)
                    {
                        max = memo[j].Item2;
                    }
                }
                max++;
                memo.Add(new Tuple<int, int>(nums[i], max));
                if (max > overalMaxLength)
                {
                    overalMaxLength = max;
                }
            }
            return overalMaxLength;
        }
    }
}

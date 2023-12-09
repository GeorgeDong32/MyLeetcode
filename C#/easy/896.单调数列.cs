/*
 * @lc app=leetcode.cn id=896 lang=csharp
 *
 * [896] 单调数列
 */

// @lc code=start
public class Solution
{
    public bool IsMonotonic(int[] nums)
    {
        int length = nums.Length;
        int prevDifference = 0;
        for (int i = 1; i < length; i++)
        {
            int difference = nums[i] - nums[i - 1];
            if (prevDifference * difference < 0)
            {
                return false;
            }
            if (difference != 0)
            {
                prevDifference = difference;
            }
        }
        return true;
    }
}
// @lc code=end


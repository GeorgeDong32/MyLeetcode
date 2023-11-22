/*
 * @lc app=leetcode.cn id=53 lang=csharp
 *
 * [53] 最大子数组和
 */

// @lc code=start
public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        if (nums.Length == 1)
            return nums[0];
        var max = -999999; var temp = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (temp >= 0)
                temp += nums[i];
            else
                temp = nums[i];
            if (temp > max)
                max = temp;
        }
        return max;
    }
}
// @lc code=end


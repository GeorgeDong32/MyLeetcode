/*
 * @lc app=leetcode.cn id=162 lang=csharp
 *
 * [162] 寻找峰值
 */

// @lc code=start
public class Solution
{
    public int FindPeakElement(int[] nums)
    {
        var peek = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] > nums[peek])
                peek = i;
        }
        return peek;
    }
}
// @lc code=end


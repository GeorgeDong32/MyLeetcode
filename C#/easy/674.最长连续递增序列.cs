/*
 * @lc app=leetcode.cn id=674 lang=csharp
 *
 * [674] 最长连续递增序列
 */

// @lc code=start
public class Solution
{
    public int FindLengthOfLCIS(int[] nums)
    {
        var max = 1;
        var l = 1;
        var length = nums.Length;
        for (int i = 1; i < length; i++)
        {
            if (nums[i] > nums[i - 1])
            {
                l++;
            }
            else
            {
                l = 1;
            }
            max = Math.Max(max, l);
        }
        return max;
    }
}
// @lc code=end


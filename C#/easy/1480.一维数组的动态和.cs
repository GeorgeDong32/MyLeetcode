/*
 * @lc app=leetcode.cn id=1480 lang=csharp
 *
 * [1480] 一维数组的动态和
 */

// @lc code=start
public class Solution
{
    public int[] RunningSum(int[] nums)
    {
        var ans = new int[nums.Length];
        ans[0] = nums[0];
        for (var i = 1; i < nums.Length; i++)
        {
            ans[i] = ans[i - 1] + nums[i];
        }
        return ans;
    }
}
// @lc code=end


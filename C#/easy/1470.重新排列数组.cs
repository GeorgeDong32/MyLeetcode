/*
 * @lc app=leetcode.cn id=1470 lang=csharp
 *
 * [1470] 重新排列数组
 */

// @lc code=start
public class Solution
{
    public int[] Shuffle(int[] nums, int n)
    {
        var ans = new int[2 * n];
        for (var i = 0; i < n; i++)
        {
            ans[2 * i] = nums[i];
            ans[2 * i + 1] = nums[n + i];
        }
        return ans;
    }
}
// @lc code=end


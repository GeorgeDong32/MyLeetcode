/*
 * @lc app=leetcode.cn id=2974 lang=csharp
 *
 * [2974] 最小数字游戏
 */

// @lc code=start
public class Solution
{
    public int[] NumberGame(int[] nums)
    {
        Array.Sort(nums);
        var ans = new List<int>();
        for (var i = 1; i < nums.Length; i += 2)
        {
            ans.Add(nums[i]);
            ans.Add(nums[i - 1]);
        }
        return ans.ToArray();
    }
}
// @lc code=end


/*
 * @lc app=leetcode.cn id=2824 lang=csharp
 *
 * [2824] 统计和小于目标的下标对数目
 */

// @lc code=start
public class Solution
{
    public int CountPairs(IList<int> nums, int target)
    {
        return nums.Select((n, i) => nums.Skip(i + 1).Count(m => n + m < target)).Sum();
    }
}
// @lc code=end


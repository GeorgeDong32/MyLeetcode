/*
 * @lc app=leetcode.cn id=1399 lang=csharp
 *
 * [1399] 统计最大组的数目
 */

// @lc code=start
public class Solution
{
    public int CountLargestGroup(int n)
    {
        var groups = Enumerable.Range(1, n)
                               .GroupBy(i => i.ToString().Sum(c => c - '0'));
        var maxGroupSize = groups.Max(g => g.Count());
        return groups.Count(g => g.Count() == maxGroupSize);
    }
}
// @lc code=end


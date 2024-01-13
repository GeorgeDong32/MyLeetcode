/*
 * @lc app=leetcode.cn id=1828 lang=csharp
 *
 * [1828] 统计一个圆中点的数目
 */

// @lc code=start
public class Solution
{
    public int[] CountPoints(int[][] points, int[][] queries)
    {
        return queries.Select(c => points.Count(p => (c[0] - p[0]) * (c[0] - p[0]) + (c[1] - p[1]) * (c[1] - p[1]) <= c[2] * c[2])).ToArray();
    }
}
// @lc code=end


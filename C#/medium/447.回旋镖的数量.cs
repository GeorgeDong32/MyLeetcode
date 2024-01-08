/*
 * @lc app=leetcode.cn id=447 lang=csharp
 *
 * [447] 回旋镖的数量
 */

// @lc code=start
public class Solution
{
    public int NumberOfBoomerangs(int[][] points)
    {
        if (points.Length < 3)
            return 0;
        return points.SelectMany((p1, i) =>
        points.Where((p2, j) => i != j)
            .GroupBy(p2 => (p2[0] - p1[0]) * (p2[0] - p1[0]) + (p2[1] - p1[1]) * (p2[1] - p1[1]))
            .Select(group => group.Count() * (group.Count() - 1)))
        .Sum();
    }
}
// @lc code=end


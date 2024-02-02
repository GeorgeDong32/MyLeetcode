/*
 * @lc app=leetcode.cn id=1637 lang=csharp
 *
 * [1637] 两点之间不包含任何点的最宽垂直区域
 */

// @lc code=start
public class Solution
{
    public int MaxWidthOfVerticalArea(int[][] points)
    {
        var sorted = points.Select(point => point[0]).OrderBy(x => x).ToArray();
        var max = 0;
        for (var i = 1; i < sorted.Length; i++)
        {
            max = Math.Max(max, sorted[i] - sorted[i - 1]);
        }
        return max;
    }
}
// @lc code=end


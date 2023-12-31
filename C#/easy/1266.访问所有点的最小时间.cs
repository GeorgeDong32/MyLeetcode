/*
 * @lc app=leetcode.cn id=1266 lang=csharp
 *
 * [1266] 访问所有点的最小时间
 */

// @lc code=start
public class Solution
{
    public int MinTimeToVisitAllPoints(int[][] points)
    {
        int res = 0;
        for (int i = 1; i < points.Length; i++)
            res += Math.Max(Math.Abs(points[i][0] - points[i - 1][0]), Math.Abs(points[i][1] - points[i - 1][1]));
        return res;
    }
}
// @lc code=end


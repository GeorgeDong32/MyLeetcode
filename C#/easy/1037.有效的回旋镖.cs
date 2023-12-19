/*
 * @lc app=leetcode.cn id=1037 lang=csharp
 *
 * [1037] 有效的回旋镖
 */

// @lc code=start
public class Solution
{
    public bool IsBoomerang(int[][] points)
    {
        var dx1 = points[1][0] - points[0][0];
        var dx2 = points[2][0] - points[0][0];
        var dy1 = points[1][1] - points[0][1];
        var dy2 = points[2][1] - points[0][1];
        return dx1 * dy2 - dx2 * dy1 != 0;
    }
}
// @lc code=end


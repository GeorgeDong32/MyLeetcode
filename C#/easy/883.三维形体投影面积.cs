/*
 * @lc app=leetcode.cn id=883 lang=csharp
 *
 * [883] 三维形体投影面积
 */

// @lc code=start
public class Solution
{
    public int ProjectionArea(int[][] grid)
    {
        var l = grid.Length;
        int xy = 0, xz = 0, yz = 0;
        for (var i = 0; i < l; i++)
        {
            int yzHeight = 0, xzHeight = 0;
            for (var j = 0; j < l; j++)
            {
                xy += grid[i][j] > 0 ? 1 : 0;
                yzHeight = Math.Max(yzHeight, grid[j][i]);
                xzHeight = Math.Max(xzHeight, grid[i][j]);
            }
            yz += yzHeight;
            xz += xzHeight;
        }
        return xy + yz + xz;
    }
}
// @lc code=end


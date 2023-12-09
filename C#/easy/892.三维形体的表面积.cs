/*
 * @lc app=leetcode.cn id=892 lang=csharp
 *
 * [892] 三维形体的表面积
 */

// @lc code=start
public class Solution
{
    public int SurfaceArea(int[][] grid)
    {
        var leny = grid[0].Length;
        var lenx = grid.Length;
        var sum = 0;
        for (var i = 0; i < lenx; i++)
        {
            for (var j = 0; j < leny; j++)
            {
                if (grid[i][j] != 0)
                    sum += 4 * grid[i][j] + 2;
                if (j + 1 < leny)
                    sum -= 2 * Math.Min(grid[i][j], grid[i][j + 1]);
                if (i + 1 < lenx)
                    sum -= 2 * Math.Min(grid[i][j], grid[i + 1][j]);
            }
        }
        return sum;
    }
}
// @lc code=end


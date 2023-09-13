/*
 * @lc app=leetcode.cn id=463 lang=csharp
 *
 * [463] 岛屿的周长
 */

// @lc code=start
public class Solution
{
    public int IslandPerimeter(int[][] grid)
    {
        if (grid == null)
            return 0;
        int m = grid.Length, n = grid[0].Length;
        if (m == 0 || n == 0)
            return 0;
        int count = 0, near = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (grid[i][j] == 0)
                    continue;
                count++;
                if (j + 1 < n && grid[i][j + 1] == 1)
                    near++;
                if (i + 1 < m && grid[i + 1][j] == 1)
                    near++;
            }
        }
        return 4 * count - 2 * near;
    }
}
// @lc code=end


/*
 * @lc app=leetcode.cn id=1260 lang=csharp
 *
 * [1260] 二维网格迁移
 */

// @lc code=start
public class Solution
{
    public IList<IList<int>> ShiftGrid(int[][] grid, int k)
    {
        int m = grid.Length, n = grid[0].Length;
        IList<IList<int>> ret = new List<IList<int>>();
        for (int i = 0; i < m; i++)
        {
            IList<int> row = new List<int>();
            for (int j = 0; j < n; j++)
            {
                row.Add(0);
            }
            ret.Add(row);
        }
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int index1 = (i * n + j + k) % (m * n);
                ret[index1 / n][index1 % n] = grid[i][j];
            }
        }
        return ret;
    }
}
// @lc code=end


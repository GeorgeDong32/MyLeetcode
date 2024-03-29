/*
 * @lc app=leetcode.cn id=2319 lang=csharp
 * @lcpr version=30120
 *
 * [2319] 判断矩阵是否是一个 X 矩阵
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool CheckXMatrix(int[][] grid)
    {
        int n = grid.Length;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j || i == n - j - 1)
                {
                    if (grid[i][j] == 0)
                    {
                        return false;
                    }
                }
                else
                {
                    if (grid[i][j] != 0)
                    {
                        return false;
                    }
                }
            }
        }
        return true;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [[2,0,0,1],[0,3,1,0],[0,5,2,0],[4,0,0,2]]\n
// @lcpr case=end

// @lcpr case=start
// [[5,7,0],[0,3,1],[0,5,0]]\n
// @lcpr case=end

 */


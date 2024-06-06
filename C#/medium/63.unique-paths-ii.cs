/*
 * @lc app=leetcode.cn id=63 lang=csharp
 * @lcpr version=30202
 *
 * [63] 不同路径 II
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int UniquePathsWithObstacles(int[][] obstacleGrid)
    {
        var m = obstacleGrid.Length;
        var n = obstacleGrid[0].Length;
        var dp = new int[m][];
        for (var i = 0; i < m; i++)
        {
            dp[i] = new int[n];
        }
        for (int i = 0; i < m && obstacleGrid[i][0] == 0; i++) dp[i][0] = 1;
        for (int j = 0; j < n && obstacleGrid[0][j] == 0; j++) dp[0][j] = 1;
        for (int i = 1; i < m; i++)
        {
            for (int j = 1; j < n; j++)
            {
                if (obstacleGrid[i][j] == 1)
                {
                    dp[i][j] = 0;
                }
                else
                {
                    dp[i][j] = dp[i - 1][j] + dp[i][j - 1];
                }
            }
        }
        return dp[m - 1][n - 1];
    }
}
// @lc code=end



/*
// @lcpr case=start
// [[0,0,0],[0,1,0],[0,0,0]]\n
// @lcpr case=end

// @lcpr case=start
// [[0,1],[0,0]]\n
// @lcpr case=end

 */


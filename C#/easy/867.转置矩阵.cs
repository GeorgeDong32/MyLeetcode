/*
 * @lc app=leetcode.cn id=867 lang=csharp
 *
 * [867] 转置矩阵
 */

// @lc code=start
public class Solution
{
    public int[][] Transpose(int[][] matrix)
    {
        int m = matrix.Length, n = matrix[0].Length;
        var ans = new int[n][];
        for (var t = 0; t < n; t++)
            ans[t] = new int[m];
        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                ans[j][i] = matrix[i][j];
            }
        }
        return ans;
    }
}
// @lc code=end


/*
 * @lc app=leetcode.cn id=1582 lang=csharp
 *
 * [1582] 二进制矩阵中的特殊位置
 */

// @lc code=start
public class Solution
{
    public int NumSpecial(int[][] mat)
    {
        int m = mat.Length, n = mat[0].Length;
        int[] rowSum = new int[m], colSum = new int[n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                rowSum[i] += mat[i][j];
                colSum[j] += mat[i][j];
            }
        }
        int count = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (mat[i][j] == 1 && rowSum[i] == 1 && colSum[j] == 1)
                {
                    count++;
                }
            }
        }
        return count;
    }
}
// @lc code=end


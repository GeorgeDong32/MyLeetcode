/*
 * @lc app=leetcode.cn id=1572 lang=csharp
 *
 * [1572] 矩阵对角线元素的和
 */

// @lc code=start
public class Solution
{
    public int DiagonalSum(int[][] mat)
    {
        int n = mat.Length;
        int sum = Enumerable.Range(0, n).Sum(i => mat[i][i] + mat[i][n - i - 1]);
        if (n % 2 == 1)
        {
            sum -= mat[n / 2][n / 2];
        }
        return sum;
    }
}
// @lc code=end


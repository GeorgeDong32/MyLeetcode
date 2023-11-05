/*
 * @lc app=leetcode.cn id=566 lang=csharp
 *
 * [566] 重塑矩阵
 */

// @lc code=start
using System.Diagnostics.CodeAnalysis;

public class Solution
{
    public int[][] MatrixReshape(int[][] mat, int r, int c)
    {
        if (mat.Length * mat[0].Length != r * c)
            return mat;
        var m = 0; var n = 0;
        int[][] res = new int[r][];
        for (int i = 0; i < r; i++) res[i] = new int[c];
        for (int i = 0; i < mat.Length; i++)
        {
            for (int j = 0; j < mat[i].Length; j++)
            {
                if (n == c)
                { //满行进位
                    m++;
                    n = 0;
                }
                res[m][n] = mat[i][j];
                n++;
            }
        }
        return res;
    }
}
// @lc code=end


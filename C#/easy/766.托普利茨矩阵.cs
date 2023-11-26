/*
 * @lc app=leetcode.cn id=766 lang=csharp
 *
 * [766] 托普利茨矩阵
 */

// @lc code=start
public class Solution
{
    public bool IsToeplitzMatrix(int[][] matrix)
    {
        bool flag = true;
        int col = matrix[0].Length;//列
        int row = matrix.Length;//行
        int num = 0;
        for (int i = 0; i < col; i++)
        {
            num = matrix[0][i];

            for (int j = 1, k = i + 1; j < row && k < col; j++)
            {
                if (matrix[j][k] != num)
                {
                    return false;
                }
                ++k;
            }
        }
        for (int i = 0; i < row; i++)
        {
            num = matrix[i][0];
            for (int j = i + 1, k = 1; j < row && k < col; j++, k++)
            {
                if (num != matrix[j][k])
                {
                    return false;
                }
            }
        }
        return flag;
    }
}
// @lc code=end


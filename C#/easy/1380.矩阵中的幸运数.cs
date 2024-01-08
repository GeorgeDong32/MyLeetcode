/*
 * @lc app=leetcode.cn id=1380 lang=csharp
 *
 * [1380] 矩阵中的幸运数
 */

// @lc code=start
public class Solution
{
    public IList<int> LuckyNumbers(int[][] matrix)
    {
        return matrix.SelectMany((row, i) =>
            row.Where((val, j) =>
                val == row.Min() && val == matrix.Max(column => column[j])
            )
        ).ToList();
    }
}
// @lc code=end


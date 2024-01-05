/*
 * @lc app=leetcode.cn id=1351 lang=csharp
 *
 * [1351] 统计有序矩阵中的负数
 */

// @lc code=start
public class Solution
{
    public int CountNegatives(int[][] grid)
    {
        return grid.Select(rows => rows.Where(num => num < 0).Count()).Sum();
    }
}
// @lc code=end


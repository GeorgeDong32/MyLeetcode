/*
 * @lc app=leetcode.cn id=2639 lang=csharp
 * @lcpr version=30122
 *
 * [2639] 查询网格图中每一列的宽度
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int[] FindColumnWidth(int[][] grid)
    {
        var colw = new int[grid[0].Length];
        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid[0].Length; j++)
            {
                var width = grid[i][j].ToString().Length;
                colw[j] = Math.Max(width, colw[j]);
            }
        }
        return colw;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [[1],[22],[333]]\n
// @lcpr case=end

// @lcpr case=start
// [[-15,1,3],[15,7,12],[5,6,-2]]\n
// @lcpr case=end

 */


/*
 * @lc app=leetcode.cn id=2352 lang=csharp
 * @lcpr version=30122
 *
 * [2352] 相等行列对
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int EqualPairs(int[][] grid)
    {
        var n = grid.Length;
        var rows = new List<IList<int>>();
        var cols = new List<IList<int>>();
        var ans = 0;
        for (var i = 0; i < n; i++)
        {
            rows.Add(new List<int>(grid[i]));
            cols.Add(new List<int>());
            for (var j = 0; j < n; j++)
            {
                cols[i].Add(grid[j][i]);
            }
        }
        for (var i = 0; i < n; i++)
        {
            ans += cols.Count(col => col.SequenceEqual(rows[i]));
        }
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [[3,2,1],[1,7,6],[2,7,7]]\n
// @lcpr case=end

// @lcpr case=start
// [[3,1,2,2],[1,4,4,5],[2,4,2,2],[2,4,2,2]]\n
// @lcpr case=end

 */


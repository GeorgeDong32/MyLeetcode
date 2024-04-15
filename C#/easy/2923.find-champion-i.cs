/*
 * @lc app=leetcode.cn id=2923 lang=csharp
 * @lcpr version=30122
 *
 * [2923] 找到冠军 I
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int FindChampion(int[][] grid)
    {
        return grid.Select((t, i) => new { t, i }).Where(kv => kv.t.Count(x => x == 0) == 1).Select(kv => kv.i).Single();
    }
}
// @lc code=end



/*
// @lcpr case=start
// [[0,1],[0,0]]\n
// @lcpr case=end

// @lcpr case=start
// [[0,0,1],[1,0,1],[0,0,0]]\n
// @lcpr case=end

 */


/*
 * @lc app=leetcode.cn id=2924 lang=csharp
 * @lcpr version=30122
 *
 * [2924] 找到冠军 II
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int FindChampion(int n, int[][] edges)
    {
        if (n == 1 || edges == null)
            return 0;
        var dictin = new int[n];
        var dictout = new int[n];
        foreach (var e in edges)
        {
            dictout[e[0]]++;
            dictin[e[1]]++;
        }
        var select = dictin.Select((x, i) => new { x, i }).Where((kv) => kv.x == 0).Select(kv => kv.i);
        return select.Count() > 1 ? -1 : select.Single();
    }
}
// @lc code=end



/*
// @lcpr case=start
// 3\n[[0,1],[1,2]]\n
// @lcpr case=end

// @lcpr case=start
// 4\n[[0,2],[1,3],[1,2]]\n
// @lcpr case=end

 */


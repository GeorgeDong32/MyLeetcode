/*
 * @lc app=leetcode.cn id=2965 lang=csharp
 * @lcpr version=30202
 *
 * [2965] 找出缺失和重复的数字
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int[] FindMissingAndRepeatedValues(int[][] grid)
    {
        var n = grid.Length;
        var maxl = n * n;
        var count = Enumerable.Repeat(0, maxl + 1).ToArray();
        count[0] = -1;
        foreach (var num in grid.SelectMany(row => row))
        {
            count[num]++;
        }
        var ans = new int[2];
        ans[0] = Array.IndexOf(count, 2);
        ans[1] = Array.IndexOf(count, 0);
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [[1,3],[2,2]]\n
// @lcpr case=end

// @lcpr case=start
// [[9,1,7],[8,9,2],[3,4,6]]\n
// @lcpr case=end

 */


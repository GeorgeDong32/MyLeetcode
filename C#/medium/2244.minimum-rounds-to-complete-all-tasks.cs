/*
 * @lc app=leetcode.cn id=2244 lang=csharp
 * @lcpr version=30201
 *
 * [2244] 完成所有任务需要的最少轮数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MinimumRounds(int[] tasks)
    {
        var counts = tasks.GroupBy(t => t).Select(g => g.Count()).ToList();
        var ans = 0;
        foreach (var c in counts)
        {
            if (c < 2)
                return -1;
            else
                ans += (c + 2) / 3;
        }
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [2,2,3,3,2,4,4,4,4,4]\n
// @lcpr case=end

// @lcpr case=start
// [2,3,3]\n
// @lcpr case=end

 */


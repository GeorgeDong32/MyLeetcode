/*
 * @lc app=leetcode.cn id=338 lang=csharp
 * @lcpr version=30122
 *
 * [338] 比特位计数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int[] CountBits(int n)
    {
        var ans = new int[n + 1];
        for (int i = 0; i <= n; i++)
        {
            ans[i] = int.PopCount(i);
        }
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// 2\n
// @lcpr case=end

// @lcpr case=start
// 5\n
// @lcpr case=end

 */


/*
 * @lc app=leetcode.cn id=2073 lang=csharp
 * @lcpr version=30119
 *
 * [2073] 买票需要的时间
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int TimeRequiredToBuy(int[] tickets, int k)
    {
        var ans = 0;
        for (var i = 0; i < tickets.Length; i++)
        {
            if (i <= k)
            {
                ans += (tickets[i] > tickets[k]) ? tickets[k] : tickets[i];
            }
            else
            {
                ans += (tickets[i] > tickets[k] - 1) ? tickets[k] - 1 : tickets[i];
            }
        }
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [2,3,2]\n2\n
// @lcpr case=end

// @lcpr case=start
// [5,1,1,1]\n0\n
// @lcpr case=end

 */


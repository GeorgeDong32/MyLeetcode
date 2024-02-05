/*
 * @lc app=leetcode.cn id=1672 lang=csharp
 *
 * [1672] 最富有客户的资产总量
 */

// @lc code=start
public class Solution
{
    public int MaximumWealth(int[][] accounts)
    {
        return accounts.Max(account => account.Sum());
    }
}
// @lc code=end


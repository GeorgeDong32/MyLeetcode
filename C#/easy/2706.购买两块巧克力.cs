/*
 * @lc app=leetcode.cn id=2706 lang=csharp
 *
 * [2706] 购买两块巧克力
 */

// @lc code=start
public class Solution
{
    public int BuyChoco(int[] prices, int money)
    {
        Array.Sort(prices);
        var sum = prices[0] + prices[1];
        return sum > money ? money : money - sum;
    }
}
// @lc code=end


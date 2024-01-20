/*
 * @lc app=leetcode.cn id=1475 lang=csharp
 *
 * [1475] 商品折扣后的最终价格
 */

// @lc code=start
public class Solution
{
    public int[] FinalPrices(int[] prices)
    {
        int n = prices.Length;
        int[] ans = new int[n];
        for (int i = 0; i < n; ++i)
        {
            int discount = 0;
            for (int j = i + 1; j < n; ++j)
            {
                if (prices[j] <= prices[i])
                {
                    discount = prices[j];
                    break;
                }
            }
            ans[i] = prices[i] - discount;
        }
        return ans;
    }
}
// @lc code=end


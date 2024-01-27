/*
 * @lc app=leetcode.cn id=2861 lang=csharp
 *
 * [2861] 最大合金数
 */

// @lc code=start
public class Solution
{
    public int MaxNumberOfAlloys(int n, int k, int budget, IList<IList<int>> composition, IList<int> stock, IList<int> cost)
    {
        int low = 0, high = stock.Min() + budget;
        while (low < high)
        {
            int mid = low + (high - low + 1) / 2;
            if (IsPossible(n, budget, composition, stock, cost, mid))
            {
                low = mid;
            }
            else
            {
                high = mid - 1;
            }
        }
        return low;
    }

    public bool IsPossible(int n, int budget, IList<IList<int>> composition, IList<int> stock, IList<int> cost, long target)
    {
        foreach (IList<int> machine in composition)
        {
            long totalCoins = 0;
            for (int i = 0; i < n && totalCoins <= budget; i++)
            {
                long additional = Math.Max(machine[i] * target - stock[i], 0);
                totalCoins += additional * cost[i];
            }
            if (totalCoins <= budget)
            {
                return true;
            }
        }
        return false;
    }
}
// @lc code=end


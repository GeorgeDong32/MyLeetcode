/*
 * @lc app=leetcode.cn id=2144 lang=csharp
 * @lcpr version=30119
 *
 * [2144] 打折购买糖果的最小开销
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MinimumCost(int[] cost)
    {
        Array.Sort(cost);
        var bill = 0;
        for (var i = cost.Length - 1; i > -1; i -= 3)
        {
            bill += cost[i];
            if (i - 1 > -1)
                bill += cost[i - 1];
        }
        return bill;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,3]\n
// @lcpr case=end

// @lcpr case=start
// [6,5,7,9,2,2]\n
// @lcpr case=end

// @lcpr case=start
// [5,5]\n
// @lcpr case=end

 */


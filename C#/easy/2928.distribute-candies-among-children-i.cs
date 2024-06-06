/*
 * @lc app=leetcode.cn id=2928 lang=csharp
 * @lcpr version=30203
 *
 * [2928] 给小朋友们分糖果 I
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int DistributeCandies(int n, int limit)
    {
        if (n > limit * 3)
        {
            return 0;
        }
        return Combinations(n + 2, 2) - Combinations(n - limit + 1, 2) * 3 + Combinations(n - limit * 2, 2) * 3 - Combinations(n - limit * 3 - 1, 2);
    }

    public int Combinations(int m, int k)
    {
        if (m < k)
        {
            return 0;
        }
        int count = 1;
        for (int i = 1; i <= k; i++)
        {
            count *= m - i + 1;
        }
        for (int i = 1; i <= k; i++)
        {
            count /= i;
        }
        return count;
    }
}
// @lc code=end



/*
// @lcpr case=start
// 5\n2\n
// @lcpr case=end

// @lcpr case=start
// 3\n3\n
// @lcpr case=end

 */


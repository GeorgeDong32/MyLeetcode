/*
 * @lc app=leetcode.cn id=2834 lang=csharp
 * @lcpr version=30118
 *
 * [2834] 找出美丽数组的最小和
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MinimumPossibleSum(int n, int target)
    {
        const int mod = (int)1e9 + 7;
        int m = target / 2;
        if (n <= m)
        {
            return (int)((long)(1 + n) * n / 2 % mod);
        }
        return (int)(((long)(1 + m) * m / 2 +
                ((long)target + target + (n - m) - 1) * (n - m) / 2) % mod);
    }
}
// @lc code=end



/*
// @lcpr case=start
// 2\n3\n
// @lcpr case=end

// @lcpr case=start
// 3\n3\n
// @lcpr case=end

// @lcpr case=start
// 1\n1\n
// @lcpr case=end

 */


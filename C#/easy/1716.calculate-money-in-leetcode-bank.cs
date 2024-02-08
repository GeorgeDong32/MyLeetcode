/*
 * @lc app=leetcode.cn id=1716 lang=csharp
 * @lcpr version=30116
 *
 * [1716] 计算力扣银行的钱
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int TotalMoney(int n)
    {
        int weeks = n / 7;
        int days = n % 7;
        return 28 * weeks + 7 * weeks * (weeks - 1) / 2 + (weeks + 1 + weeks + days) * days / 2;
    }
}
// @lc code=end



/*
// @lcpr case=start
// 4\n
// @lcpr case=end

// @lcpr case=start
// 10\n
// @lcpr case=end

// @lcpr case=start
// 20\n
// @lcpr case=end

 */


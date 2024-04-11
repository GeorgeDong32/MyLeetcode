/*
 * @lc app=leetcode.cn id=2544 lang=csharp
 * @lcpr version=30121
 *
 * [2544] 交替数字和
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int AlternateDigitSum(int n)
    {
        int sum = 0;
        while (n != 0)
        {
            int digit = n % 10;
            sum = digit - sum;
            n /= 10;
        }
        return sum;
    }
}
// @lc code=end



/*
// @lcpr case=start
// 521\n
// @lcpr case=end

// @lcpr case=start
// 111\n
// @lcpr case=end

// @lcpr case=start
// 886996\n
// @lcpr case=end

 */


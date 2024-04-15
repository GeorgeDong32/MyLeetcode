/*
 * @lc app=leetcode.cn id=7 lang=csharp
 * @lcpr version=30122
 *
 * [7] 整数反转
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int Reverse(int x)
    {
        if (x == 0)
            return 0;
        var minus = x < 0;
        long temp = long.Abs(x); long ans = 0;
        while (temp > 0)
        {
            ans *= 10;
            ans += temp % 10;
            temp /= 10;
        }
        return ans > int.MaxValue ? 0 : minus ? -(int)ans : (int)ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// 123\n
// @lcpr case=end

// @lcpr case=start
// -123\n
// @lcpr case=end

// @lcpr case=start
// 120\n
// @lcpr case=end

// @lcpr case=start
// 0\n
// @lcpr case=end

 */


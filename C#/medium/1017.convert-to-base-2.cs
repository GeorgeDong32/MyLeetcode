/*
 * @lc app=leetcode.cn id=1017 lang=csharp
 * @lcpr version=30122
 *
 * [1017] 负二进制转换
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
using System.Text;

public class Solution
{
    public string BaseNeg2(int n)
    {
        if (n == 0)
            return "0";
        var sb = new StringBuilder();
        while (n != 0)
        {
            var remain = Math.Abs(n) % -2;
            sb.Append(remain);
            n -= remain;
            n /= -2;
        }
        var narr = sb.ToString().ToCharArray();
        Array.Reverse(narr);
        return new string(narr);
    }
}
// @lc code=end

/*
// @lcpr case=start
// 2\n
// @lcpr case=end

// @lcpr case=start
// 3\n
// @lcpr case=end

// @lcpr case=start
// 4\n
// @lcpr case=end

 */


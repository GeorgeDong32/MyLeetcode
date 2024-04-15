/*
 * @lc app=leetcode.cn id=8 lang=csharp
 * @lcpr version=30122
 *
 * [8] 字符串转换整数 (atoi)
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
using System.Numerics;

public class Solution
{
    public int MyAtoi(string s)
    {
        s = s.Trim();
        BigInteger res = 0;
        var minus = false;
        for (var i = 0; i < s.Length; i++)
        {
            if (i == 0 && s[i] == '-')
                minus = true;
            else if (i == 0 && s[i] == '+')
                minus = false;
            else if (!char.IsDigit(s[i]))
            {
                return ReturnResult(minus, res);
            }
            else
            {
                res *= 10;
                res += (s[i] - '0');
            }
        }
        return ReturnResult(minus, res);
    }

    private int ReturnResult(bool minus, BigInteger res)
    {
        try
        {
            checked
            {
                if (minus)
                {
                    return -res < int.MinValue ? int.MinValue : -(int)res;
                }
                else
                {
                    return res > int.MaxValue ? int.MaxValue : (int)res;
                }
            }
        }
        catch (OverflowException)
        {
            return minus ? int.MinValue : int.MaxValue;
        }
    }
}
// @lc code=end



/*
// @lcpr case=start
// "42"\n
// @lcpr case=end

// @lcpr case=start
// "   -42"\n
// @lcpr case=end

// @lcpr case=start
// "4193 with words"\n
// @lcpr case=end

 */


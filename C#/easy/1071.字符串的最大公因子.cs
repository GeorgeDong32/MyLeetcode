/*
 * @lc app=leetcode.cn id=1071 lang=csharp
 *
 * [1071] 字符串的最大公因子
 */

// @lc code=start
public class Solution
{
    public string GcdOfStrings(string str1, string str2)
    {
        if (str1 + str2 != str2 + str1)
        {
            return "";
        }
        var gcdl = GCD(str1.Length, str2.Length);
        return str1.Substring(0, gcdl);
    }

    public int GCD(int a, int b)
    {
        return b == 0 ? a : GCD(b, a % b);
    }
}
// @lc code=end


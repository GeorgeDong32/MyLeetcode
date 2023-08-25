/*
 * @lc app=leetcode.cn id=415 lang=csharp
 *
 * [415] 字符串相加
 */

// @lc code=start
using System.Numerics;

public class Solution
{
    public string AddStrings(string num1, string num2)
    {
        BigInteger n1, n2;
        BigInteger.TryParse(num1.ToCharArray(), out n1);
        BigInteger.TryParse(num2.ToCharArray(), out n2);
        return BigInteger.Add(n1, n2).ToString();
    }
}
// @lc code=end


/*
 * @lc app=leetcode.cn id=43 lang=csharp
 * @lcpr version=30122
 *
 * [43] 字符串相乘
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
using System.Text;

public class Solution
{
    public string Multiply(string num1, string num2)
    {
        if (num1 == "0" || num2 == "0")
            return "0";
        int m = num1.Length, n = num2.Length;
        var product = new int[m + n];
        for (var i = n - 1; i >= 0; i--)
        {
            var multiplicator = num2[i] - '0';
            for (var j = m - 1; j >= 0; j--)
            {
                var multiplicand = num1[j] - '0';
                product[i + j + 1] += multiplicand * multiplicator;
            }
        }
        for (var i = m + n - 1; i > 0; i--)
        {
            if (product[i] >= 10)
            {
                product[i - 1] += product[i] / 10;
                product[i] %= 10;
            }
        }
        var sb = new StringBuilder();
        var start = product[0] == 0 ? 1 : 0;
        for (var i = start; i < m + n; i++)
        {
            sb.Append(product[i]);
        }
        return sb.ToString();
    }
}
// @lc code=end



/*
// @lcpr case=start
// "2"\n"3"\n
// @lcpr case=end

// @lcpr case=start
// "123"\n"456"\n
// @lcpr case=end

 */


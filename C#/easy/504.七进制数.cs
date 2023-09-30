/*
 * @lc app=leetcode.cn id=504 lang=csharp
 *
 * [504] 七进制数
 */

// @lc code=start
using System.Text;

public class Solution
{
    public string ConvertToBase7(int num)
    {
        if (num == 0) return "0";
        bool isNegative = num < 0;
        num = Math.Abs(num);
        var sb = new StringBuilder();
        while (num > 0)
        {
            sb.Append(num % 7);
            num /= 7;
        }
        if (isNegative) sb.Append("-");
        char[] arr = sb.ToString().ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}
// @lc code=end


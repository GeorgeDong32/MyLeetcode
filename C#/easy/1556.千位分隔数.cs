/*
 * @lc app=leetcode.cn id=1556 lang=csharp
 *
 * [1556] 千位分隔数
 */

// @lc code=start
using System.Text;

public class Solution
{
    public string ThousandSeparator(int n)
    {
        string str = n.ToString();
        int len = str.Length;
        if (len <= 3) return str;
        StringBuilder sb = new StringBuilder();
        int count = 0;
        for (int i = len - 1; i >= 0; i--)
        {
            sb.Insert(0, str[i]);
            count++;
            if (count % 3 == 0 && i != 0)
            {
                sb.Insert(0, '.');
            }
        }
        return sb.ToString();
    }
}
// @lc code=end


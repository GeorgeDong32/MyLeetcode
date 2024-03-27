/*
 * @lc app=leetcode.cn id=2243 lang=csharp
 * @lcpr version=30120
 *
 * [2243] 计算字符串的数字和
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
using System.Text;

public class Solution
{
    public string DigitSum(string s, int k)
    {
        while (s.Length > k)
        {
            s = OneRound(s, k);
        }
        return s;
    }

    public string OneRound(string s, int k)
    {
        StringBuilder sb = new StringBuilder();
        int length = s.Length;
        for (int i = 0; i < length; i += k)
        {
            int start = i, end = Math.Min(start + k - 1, length - 1);
            int sum = 0;
            for (int j = start; j <= end; j++)
            {
                sum += s[j] - '0';
            }
            sb.Append(sum);
        }
        return sb.ToString();
    }
}
// @lc code=end



/*
// @lcpr case=start
// "11111222223"\n3\n
// @lcpr case=end

// @lcpr case=start
// "00000000"\n3\n
// @lcpr case=end

 */


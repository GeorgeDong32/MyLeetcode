/*
 * @lc app=leetcode.cn id=2810 lang=csharp
 * @lcpr version=30121
 *
 * [2810] 故障键盘
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
using System.Text;

public class Solution
{
    public string FinalString(string s)
    {
        var sb = new StringBuilder();
        foreach (char c in s)
        {
            if (c == 'i')
            {
                Reverse(ref sb);
            }
            else
            {
                sb.Append(c);
            }
        }
        return sb.ToString();
    }

    private void Reverse(ref StringBuilder sb)
    {
        for (int i = 0, j = sb.Length - 1; i < j; i++, j--)
        {
            char temp = sb[i];
            sb[i] = sb[j];
            sb[j] = temp;
        }
    }
}
// @lc code=end



/*
// @lcpr case=start
// "string"\n
// @lcpr case=end

// @lcpr case=start
// "poiinter"\n
// @lcpr case=end

 */


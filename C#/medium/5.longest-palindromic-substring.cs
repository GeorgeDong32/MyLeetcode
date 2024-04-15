/*
 * @lc app=leetcode.cn id=5 lang=csharp
 * @lcpr version=30122
 *
 * [5] 最长回文子串
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public string LongestPalindrome(string s)
    {
        int maxLength = 1;
        int maxStartIndex = 0;
        int n = s.Length;
        bool[][] dp = new bool[n][];
        for (int i = 0; i < n; i++)
        {
            dp[i] = new bool[n];
            dp[i][i] = true;
        }
        for (int i = 0; i < n - 1; i++)
        {
            dp[i][i + 1] = s[i] == s[i + 1];
            if (dp[i][i + 1] && maxLength == 1)
            {
                maxLength = 2;
                maxStartIndex = i;
            }
        }
        for (int subLength = 3; subLength <= n; subLength++)
        {
            for (int i = 0, j = subLength - 1; j < n; i++, j++)
            {
                if (s[i] == s[j] && dp[i + 1][j - 1])
                {
                    dp[i][j] = true;
                    if (subLength > maxLength)
                    {
                        maxLength = subLength;
                        maxStartIndex = i;
                    }
                }
            }
        }
        return s.Substring(maxStartIndex, maxLength);
    }
}
// @lc code=end



/*
// @lcpr case=start
// "babad"\n
// @lcpr case=end

// @lcpr case=start
// "cbbd"\n
// @lcpr case=end

 */


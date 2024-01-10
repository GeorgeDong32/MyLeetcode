/*
 * @lc app=leetcode.cn id=2707 lang=csharp
 *
 * [2707] 字符串中的额外字符
 */

// @lc code=start
public class Solution
{
    public int MinExtraChar(string s, string[] dictionary)
    {
        var dictSet = new HashSet<string>(dictionary);
        int n = s.Length;
        int[] dp = new int[n + 1];
        for (int i = 0; i < n; i++)
        {
            dp[i + 1] = dp[i] + 1;
            for (int j = 0; j <= i; j++)
            {
                if (dictSet.Contains(s.Substring(j, i - j + 1)))
                {
                    dp[i + 1] = Math.Min(dp[i + 1], dp[j]);
                }
            }
        }
        return dp[n];
    }
}
// @lc code=end


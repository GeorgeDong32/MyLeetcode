/*
 * @lc app=leetcode.cn id=696 lang=csharp
 *
 * [696] 计数二进制子串
 */

// @lc code=start
public class Solution
{
    public int CountBinarySubstrings(string s)
    {
        int p = 0, last = 0, ans = 0;
        while (p < s.Length)
        {
            char c = s[p]; int count = 0;
            while (p < s.Length && s[p] == c)
            {
                p++; count++;
            }
            ans += Math.Min(count, last);
            last = count;
        }
        return ans;
    }
}
// @lc code=end


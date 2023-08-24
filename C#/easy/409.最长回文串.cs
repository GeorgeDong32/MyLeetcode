/*
 * @lc app=leetcode.cn id=409 lang=csharp
 *
 * [409] 最长回文串
 */

// @lc code=start
public class Solution
{
    public int LongestPalindrome(string s)
    {
        var count = new int[128];
        var ans = 0;
        foreach (var c in s)
        {
            count[c]++;
        }
        foreach (var c in count)
        {
            ans += (c / 2) * 2;
            if (c % 2 == 1 && ans % 2 == 0)
                ans++;
        }
        return ans;
    }
}
// @lc code=end


/*
 * @lc app=leetcode.cn id=821 lang=csharp
 *
 * [821] 字符的最短距离
 */

// @lc code=start
public class Solution
{
    public int[] ShortestToChar(string s, char c)
    {
        int n = s.Length;
        int[] ans = new int[n];

        for (int i = 0, idx = -n; i < n; ++i)
        {
            if (s[i] == c)
            {
                idx = i;
            }
            ans[i] = i - idx;
        }

        for (int i = n - 1, idx = 2 * n; i >= 0; --i)
        {
            if (s[i] == c)
            {
                idx = i;
            }
            ans[i] = Math.Min(ans[i], idx - i);
        }
        return ans;
    }
}
// @lc code=end


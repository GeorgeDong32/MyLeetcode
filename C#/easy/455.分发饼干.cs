/*
 * @lc app=leetcode.cn id=455 lang=csharp
 *
 * [455] 分发饼干
 */

// @lc code=start
public class Solution
{
    public int FindContentChildren(int[] g, int[] s)
    {
        Array.Sort(g);
        Array.Sort(s);
        var m = g.Length; var n = s.Length;
        int count = 0;
        for (int i = 0, j = 0; i < m && j < n; i++, j++)
        {
            while (j < n && g[i] > s[j])
            {
                j++;
            }
            if (j < n)
            {
                count++;
            }
        }
        return count;
    }
}
// @lc code=end


/*
 * @lc app=leetcode.cn id=997 lang=csharp
 *
 * [997] 找到小镇的法官
 */

// @lc code=start
public class Solution
{
    public int FindJudge(int n, int[][] trust)
    {
        var trusted = new int[n + 1];
        var betrusted = new int[n + 1];
        foreach (var p in trust)
        {
            trusted[p[0]]++;
            betrusted[p[1]]++;
        }
        for (var i = 1; i < n + 1; i++)
        {
            if (trusted[i] == 0 && betrusted[i] == n - 1)
                return i;
        }
        return -1;
    }
}
// @lc code=end


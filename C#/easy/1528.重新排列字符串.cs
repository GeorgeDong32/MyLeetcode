/*
 * @lc app=leetcode.cn id=1528 lang=csharp
 *
 * [1528] 重新排列字符串
 */

// @lc code=start
public class Solution
{
    public string RestoreString(string s, int[] indices)
    {
        var ans = new char[s.Length];
        for (var i = 0; i < s.Length; i++)
        {
            ans[indices[i]] = s[i];
        }
        return new string(ans);
    }
}
// @lc code=end


/*
 * @lc app=leetcode.cn id=1684 lang=csharp
 *
 * [1684] 统计一致字符串的数目
 */

// @lc code=start
public class Solution
{
    public int CountConsistentStrings(string allowed, string[] words)
    {
        var ans = 0;
        foreach (var word in words)
        {
            if (IsConsistentString(allowed, word))
                ans++;
        }
        return ans;
    }

    private bool IsConsistentString(string allowed, string word)
    {
        return !word.Any(x => !allowed.Contains(x));
    }
}
// @lc code=end


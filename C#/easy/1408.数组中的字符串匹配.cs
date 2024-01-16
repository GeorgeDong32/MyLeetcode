/*
 * @lc app=leetcode.cn id=1408 lang=csharp
 *
 * [1408] 数组中的字符串匹配
 */

// @lc code=start
public class Solution
{
    public IList<string> StringMatching(string[] words)
    {
        return words.Where(word => words.Any(other => other != word && other.Contains(word))).Distinct().ToList();
    }
}
// @lc code=end


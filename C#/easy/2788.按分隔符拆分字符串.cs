/*
 * @lc app=leetcode.cn id=2788 lang=csharp
 *
 * [2788] 按分隔符拆分字符串
 */

// @lc code=start
public class Solution
{
    public IList<string> SplitWordsBySeparator(IList<string> words, char separator)
    {
        var ans = new List<string>();
        foreach (var word in words)
        {
            var split = word.Split(separator).ToList();
            split.RemoveAll(x => x == "" || x == string.Empty);
            ans.AddRange(split);
        }
        return ans;
    }
}
// @lc code=end


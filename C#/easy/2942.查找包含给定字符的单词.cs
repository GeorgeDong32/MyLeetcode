/*
 * @lc app=leetcode.cn id=2942 lang=csharp
 *
 * [2942] 查找包含给定字符的单词
 */

// @lc code=start
public class Solution
{
    public IList<int> FindWordsContaining(string[] words, char x)
    {
        return words.Select((word, index) => new { word, index })
                    .Where(item => item.word.Contains(x))
                    .Select(item => item.index)
                    .ToList();
    }
}
// @lc code=end


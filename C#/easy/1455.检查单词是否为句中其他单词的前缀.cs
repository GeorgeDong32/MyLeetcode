/*
 * @lc app=leetcode.cn id=1455 lang=csharp
 *
 * [1455] 检查单词是否为句中其他单词的前缀
 */

// @lc code=start
public class Solution
{
    public int IsPrefixOfWord(string sentence, string searchWord)
    {
        var words = sentence.Split(" ");
        var result = words.Select((word, index) => new { word, index })
                          .FirstOrDefault(item => item.word.StartsWith(searchWord));
        return result != null ? result.index + 1 : -1;
    }
}
// @lc code=end


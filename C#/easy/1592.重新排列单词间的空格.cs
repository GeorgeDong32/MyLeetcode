/*
 * @lc app=leetcode.cn id=1592 lang=csharp
 *
 * [1592] 重新排列单词间的空格
 */

// @lc code=start
public class Solution
{
    public string ReorderSpaces(string text)
    {
        int spaceCount = text.Count(c => c == ' ');
        var words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int wordCount = words.Length;
        int spacesBetween = wordCount > 1 ? spaceCount / (wordCount - 1) : 0;
        int spacesEnd = wordCount > 1 ? spaceCount % (wordCount - 1) : spaceCount;
        return string.Join(new string(' ', spacesBetween), words) + new string(' ', spacesEnd);
    }
}
// @lc code=end


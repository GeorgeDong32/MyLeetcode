/*
 * @lc app=leetcode.cn id=434 lang=csharp
 *
 * [434] 字符串中的单词数
 */

// @lc code=start
public class Solution
{
    public int CountSegments(string s)
    {
        return s.Split(" ", StringSplitOptions.RemoveEmptyEntries).Length;
    }
}
// @lc code=end


/*
 * @lc app=leetcode.cn id=1662 lang=csharp
 *
 * [1662] 检查两个字符串数组是否相等
 */

// @lc code=start
public class Solution
{
    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        var w1 = string.Join("", word1);
        var w2 = string.Join("", word2);
        return w1.Equals(w2);
    }
}
// @lc code=end


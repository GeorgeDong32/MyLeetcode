/*
 * @lc app=leetcode.cn id=1668 lang=csharp
 *
 * [1668] 最大重复子字符串
 */

// @lc code=start
public class Solution
{
    public int MaxRepeating(string sequence, string word)
    {
        int count = 0;
        string temp = word;
        while (sequence.Contains(temp))
        {
            count++;
            temp += word;
        }
        return count;
    }
}
// @lc code=end


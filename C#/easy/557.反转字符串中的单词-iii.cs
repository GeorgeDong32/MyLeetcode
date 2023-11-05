/*
 * @lc app=leetcode.cn id=557 lang=csharp
 *
 * [557] 反转字符串中的单词 III
 */

// @lc code=start
using System.Text;
public class Solution
{
    public string ReverseWords(string s)
    {
        StringBuilder a = new StringBuilder(s);
        int front = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ')
            {
                ReverseString(front, i - 1, a);
                front = i + 1;
            }
        }
        ReverseString(front, s.Length - 1, a);
        return a.ToString();
    }

    public void ReverseString(int front, int tail, StringBuilder str)
    {
        while (front < tail)
        {
            str[front] ^= str[tail];
            str[tail] ^= str[front];
            str[front++] ^= str[tail--];
        }
    }
}
// @lc code=end


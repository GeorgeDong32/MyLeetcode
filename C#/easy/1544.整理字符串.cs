/*
 * @lc app=leetcode.cn id=1544 lang=csharp
 *
 * [1544] 整理字符串
 */

// @lc code=start
public class Solution
{
    public string MakeGood(string s)
    {
        var stack = new Stack<char>();
        foreach (var ch in s)
        {
            if (stack.Count > 0 && Math.Abs(stack.Peek() - ch) == 32)
            {
                stack.Pop();
            }
            else
            {
                stack.Push(ch);
            }
        }
        return new string(stack.Reverse().ToArray());
    }
}
// @lc code=end


/*
 * @lc app=leetcode.cn id=2696 lang=csharp
 *
 * [2696] 删除子串后的字符串最小长度
 */

// @lc code=start
public class Solution
{
    public int MinLength(string s)
    {
        var stack = new Stack<char>();
        foreach (var c in s)
        {
            if (stack.Count > 0)
            {
                var top = stack.Peek();
                if ((top == 'A' && c == 'B') || (top == 'C' && c == 'D'))
                {
                    stack.Pop();
                    continue;
                }
            }
            stack.Push(c);
        }
        return stack.Count;
    }
}
// @lc code=end


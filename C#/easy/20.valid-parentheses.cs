/*
 * @lc app=leetcode.cn id=20 lang=csharp
 * @lcpr version=30201
 *
 * [20] 有效的括号
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool IsValid(string s)
    {
        if (s.Length % 2 != 0)
            return false;
        var stack = new Stack<char>();
        foreach (var c in s)
        {
            if (c == '(')
                stack.Push(')');
            else if (c == '[')
                stack.Push(']');
            else if (c == '{')
                stack.Push('}');
            else
            {
                if (stack.Count == 0 || stack.Peek() != c)
                    return false;
                else
                    stack.Pop();
            }
        }
        return stack.Count == 0;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "()"\n
// @lcpr case=end

// @lcpr case=start
// "()[]{}"\n
// @lcpr case=end

// @lcpr case=start
// "(]"\n
// @lcpr case=end

 */


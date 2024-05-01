/*
 * @lc app=leetcode.cn id=394 lang=csharp
 * @lcpr version=30122
 *
 * [394] 字符串解码
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
using System.Text;

public class Solution
{
    public string DecodeString(string s)
    {
        StringBuilder sb = new StringBuilder();
        Stack<int> stack = new Stack<int>();
        int num = 0;
        int length = s.Length;
        for (int i = 0; i < length; i++)
        {
            char c = s[i];
            if (char.IsDigit(c))
            {
                num = num * 10 + c - '0';
            }
            else if (char.IsLetter(c))
            {
                sb.Append(c);
            }
            else if (c == '[')
            {
                stack.Push(num);
                num = 0;
                sb.Append(c);
            }
            else
            {
                int top = sb.Length - 1;
                var temp = new StringBuilder();
                while (sb[top] != '[')
                {
                    temp.Append(sb[top]);
                    sb.Length = top;
                    top--;
                }
                sb.Length = top;
                top--;
                var temp2 = new StringBuilder();
                for (int j = temp.Length - 1; j >= 0; j--)
                {
                    temp2.Append(temp[j]);
                }
                int k = stack.Pop();
                for (int j = 0; j < k; j++)
                {
                    sb.Append(temp2);
                }
            }
        }
        return sb.ToString();
    }
}
// @lc code=end



/*
// @lcpr case=start
// "3[a]2[bc]"\n
// @lcpr case=end

// @lcpr case=start
// "3[a2[c]]"\n
// @lcpr case=end

// @lcpr case=start
// "2[abc]3[cd]ef"\n
// @lcpr case=end

// @lcpr case=start
// "abc3[cd]xyz"\n
// @lcpr case=end

 */


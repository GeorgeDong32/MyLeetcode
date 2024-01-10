/*
 * @lc app=leetcode.cn id=1678 lang=csharp
 *
 * [1678] 设计 Goal 解析器
 */

// @lc code=start
using System.Text;

public class Solution
{
    public string Interpret(string command)
    {
        var n = command.Length;
        var sb = new StringBuilder();
        for (var i = 0; i < n; i++)
        {
            if (command[i] == 'G')
                sb.Append('G');
            else if (command[i] == '(')
            {
                if (command[i + 1] == ')')
                {
                    sb.Append('o');
                    i++;
                }
                else
                {
                    sb.Append("al");
                    i += 3;
                }
            }
            else
            {
                throw new InvalidDataException("Invaild input: command");
            }
        }
        return sb.ToString();
    }
}
// @lc code=end


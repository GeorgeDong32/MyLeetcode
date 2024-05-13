/*
 * @lc app=leetcode.cn id=150 lang=csharp
 * @lcpr version=30201
 *
 * [150] 逆波兰表达式求值
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        var stack = new Stack<long>();
        foreach (var token in tokens)
        {
            if (token == "+" || token == "-" || token == "*" || token == "/")
            {
                var num2 = stack.Pop();
                var num1 = stack.Pop();
                switch (token)
                {
                    case "+":
                        stack.Push(num1 + num2);
                        break;
                    case "-":
                        stack.Push(num1 - num2);
                        break;
                    case "*":
                        stack.Push(num1 * num2);
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            stack.Push(num1 / num2);
                        }
                        else
                        {
                            throw new DivideByZeroException();
                        }
                        break;
                    default:
                        break;
                }
            }
            else
            {
                stack.Push(long.Parse(token));
            }
        }
        return (int)stack.Pop();
    }
}
// @lc code=end



/*
// @lcpr case=start
// ["2","1","+","3","*"]\n
// @lcpr case=end

// @lcpr case=start
// ["4","13","5","/","+"]\n
// @lcpr case=end

// @lcpr case=start
// ["10","6","9","3","+","-11","*","/","*","17","+","5","+"]\n
// @lcpr case=end

 */


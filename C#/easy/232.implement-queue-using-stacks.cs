/*
 * @lc app=leetcode.cn id=232 lang=csharp
 * @lcpr version=30201
 *
 * [232] 用栈实现队列
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class MyQueue
{
    private Stack<int> input;
    private Stack<int> output;

    public MyQueue()
    {
        input = new Stack<int>();
        output = new Stack<int>();
    }

    public void Push(int x)
    {
        input.Push(x);
    }

    public int Pop()
    {
        Peek();
        return output.Pop();
    }

    public int Peek()
    {
        if (output.Count == 0)
        {
            while (input.Count > 0)
            {
                output.Push(input.Pop());
            }
        }
        return output.Peek();
    }

    public bool Empty()
    {
        return input.Count == 0 && output.Count == 0;
    }
}
/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */
// @lc code=end



/*
// @lcpr case=start
// ["MyQueue", "push", "push", "peek", "pop", "empty"][[], [1], [2], [], [], []]\n
// @lcpr case=end

 */


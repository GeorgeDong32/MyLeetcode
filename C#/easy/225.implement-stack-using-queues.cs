/*
 * @lc app=leetcode.cn id=225 lang=csharp
 * @lcpr version=30201
 *
 * [225] 用队列实现栈
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class MyStack
{
    private Queue<int> q1;
    private Queue<int> q2;

    public MyStack()
    {
        q1 = new();
        q2 = new();
    }

    public void Push(int x)
    {
        q1.Enqueue(x);
        while (q2.Count > 0)
        {
            q1.Enqueue(q2.Dequeue());
        }
        SwapQueue(ref q1, ref q2);
    }

    public int Pop()
    {
        return q2.Dequeue();
    }

    public int Top()
    {
        return q2.Peek();
    }

    public bool Empty()
    {
        return q2.Count == 0;
    }
    private void SwapQueue(ref Queue<int> q1, ref Queue<int> q2)
    {
        var temp = q1;
        q1 = q2;
        q2 = temp;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */
// @lc code=end



/*
// @lcpr case=start
// ["MyStack", "push", "push", "top", "pop", "empty"][[], [1], [2], [], [], []]\n
// @lcpr case=end

 */


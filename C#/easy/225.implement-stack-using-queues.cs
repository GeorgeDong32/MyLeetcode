/*
 * @lc app=leetcode.cn id=225 lang=csharp
 * @lcpr version=30118
 *
 * [225] 用队列实现栈
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class MyStack
{
    Queue<int> q1;
    Queue<int> q2;
    public MyStack()
    {
        q1 = new Queue<int>();
        q2 = new Queue<int>();
    }

    public void Push(int x)
    {
        q2.Enqueue(x);
        while (q1.Count > 0)
        {
            q2.Enqueue(q1.Dequeue());
        }
        SwapQueue(ref q1, ref q2);
    }

    public int Pop()
    {
        return q1.Dequeue();
    }

    public int Top()
    {
        return q1.Peek();
    }

    public bool Empty()
    {
        return q1.Count == 0;
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


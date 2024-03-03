/*
 * @lc app=leetcode.cn id=933 lang=csharp
 * @lcpr version=30117
 *
 * [933] 最近的请求次数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class RecentCounter
{
    Queue<int> requests;
    public RecentCounter()
    {
        requests = new Queue<int>();
    }

    public int Ping(int t)
    {
        requests.Enqueue(t);
        while (requests.Peek() < t - 3000)
        {
            requests.Dequeue();
        }
        return requests.Count;
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */
// @lc code=end



/*
// @lcpr case=start
// ["RecentCounter", "ping", "ping", "ping", "ping"][[], [1], [100], [3001], [3002]]\n
// @lcpr case=end

 */


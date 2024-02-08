/*
 * @lc app=leetcode.cn id=LCP 30 lang=csharp
 * @lcpr version=30116
 *
 * [LCP 30] 魔塔游戏
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MagicTower(int[] nums)
    {
        long total = 1, sum = 1;
        int res = 0;
        var pq = new PriorityQueue<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            if (nums[i] < 0)
            {
                pq.Enqueue(nums[i]);
            }
            while (sum <= 0)
            {
                if (pq.Count == 0)
                {
                    return -1;
                }
                sum -= pq.Dequeue();
                res++;
            }
            total += nums[i];
        }
        if (total < 0)
        {
            return -1;
        }
        return res;
    }
}

public class PriorityQueue<T> where T : IComparable
{
    private List<T> data;
    public PriorityQueue()
    {
        this.data = new List<T>();
    }
    public void Enqueue(T item)
    {
        data.Add(item);
        int ci = data.Count - 1;
        while (ci > 0)
        {
            int pi = (ci - 1) / 2;
            if (data[ci].CompareTo(data[pi]) >= 0) break;
            T tmp = data[ci]; data[ci] = data[pi]; data[pi] = tmp;
            ci = pi;
        }
    }
    public T Dequeue()
    {
        int li = data.Count - 1;
        T frontItem = data[0];
        data[0] = data[li];
        data.RemoveAt(li);
        --li;
        int pi = 0;
        while (true)
        {
            int ci = pi * 2 + 1;
            if (ci > li) break;
            int rc = ci + 1;
            if (rc <= li && data[rc].CompareTo(data[ci]) < 0)
                ci = rc;
            if (data[pi].CompareTo(data[ci]) <= 0) break;
            T tmp = data[pi]; data[pi] = data[ci]; data[ci] = tmp;
            pi = ci;
        }
        return frontItem;
    }
    public int Count
    {
        get
        {
            return data.Count;
        }
    }
}
// @lc code=end



/*
// @lcpr case=start
// [100,100,100,-250,-60,-140,-50,-50,100,150]`>\n
// @lcpr case=end

// @lcpr case=start
// [-200,-300,400,0]`>\n
// @lcpr case=end

 */


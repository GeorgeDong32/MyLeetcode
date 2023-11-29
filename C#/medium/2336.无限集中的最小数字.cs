/*
 * @lc app=leetcode.cn id=2336 lang=csharp
 *
 * [2336] 无限集中的最小数字
 */

// @lc code=start
using System.Collections;

public class SmallestInfiniteSet
{
    private static int N = 1000;
    private PriorityQueue<int, int> list = new();
    private HashSet<int> hash = new();
    public SmallestInfiniteSet()
    {
        for (var i = 1; i <= N; i++)
        {
            list.Enqueue(i, i);
            hash.Add(i);
        }
    }

    public int PopSmallest()
    {
        var res = list.Dequeue();
        hash.Remove(res);
        return res;
    }

    public void AddBack(int num)
    {
        if (!hash.Contains(num))
        {
            hash.Add(num);
            list.Enqueue(num, num);
        }
    }
}
// @lc code=end


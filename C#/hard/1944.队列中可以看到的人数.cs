/*
 * @lc app=leetcode.cn id=1944 lang=csharp
 *
 * [1944] 队列中可以看到的人数
 */

// @lc code=start
public class Solution
{
    public int[] CanSeePersonsCount(int[] heights)
    {
        var n = heights.Length;
        var stack = new Stack<int>();
        var res = new int[n];
        for (int i = n - 1; i >= 0; i--)
        {
            int h = heights[i];
            //出栈直至有比自己高的人，同时统计自己能看到的人
            while (stack.Count > 0 && stack.Peek() < h)
            {
                stack.Pop();
                res[i]++;
            }
            if (stack.Count > 0) //还能看到一个最高的人
            {
                res[i]++;
            }
            stack.Push(h);
        }
        return res;
    }
}
// @lc code=end


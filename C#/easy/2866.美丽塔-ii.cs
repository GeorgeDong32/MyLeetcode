/*
 * @lc app=leetcode.cn id=2866 lang=csharp
 *
 * [2866] 美丽塔 II
 */

// @lc code=start
public class Solution
{
    public long MaximumSumOfHeights(IList<int> maxHeights)
    {
        int n = maxHeights.Count;
        long res = 0;
        long[] prefix = new long[n];
        long[] suffix = new long[n];
        Stack<int> stack1 = new Stack<int>();
        Stack<int> stack2 = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            while (stack1.Count > 0 && maxHeights[i] < maxHeights[stack1.Peek()])
            {
                stack1.Pop();
            }
            if (stack1.Count == 0)
            {
                prefix[i] = (long)(i + 1) * maxHeights[i];
            }
            else
            {
                prefix[i] = prefix[stack1.Peek()] + (long)(i - stack1.Peek()) * maxHeights[i];
            }
            stack1.Push(i);
        }
        for (int i = n - 1; i >= 0; i--)
        {
            while (stack2.Count > 0 && maxHeights[i] < maxHeights[stack2.Peek()])
            {
                stack2.Pop();
            }
            if (stack2.Count == 0)
            {
                suffix[i] = (long)(n - i) * maxHeights[i];
            }
            else
            {
                suffix[i] = suffix[stack2.Peek()] + (long)(stack2.Peek() - i) * maxHeights[i];
            }
            stack2.Push(i);
            res = Math.Max(res, prefix[i] + suffix[i] - maxHeights[i]);
        }
        return res;
    }
}
// @lc code=end


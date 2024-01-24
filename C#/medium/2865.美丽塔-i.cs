/*
 * @lc app=leetcode.cn id=2865 lang=csharp
 *
 * [2865] 美丽塔 I
 */

// @lc code=start
public class Solution
{
    public long MaximumSumOfHeights(IList<int> maxHeights)
    {
        int len = maxHeights.Count;
        long[] preSum = new long[len];  //前缀和
        long[] sufSum = new long[len];  //后缀和
        long max = 0;
        Stack<int> stack = new Stack<int>();
        //前缀和计算
        for (int i = 0; i < len; i++)
        {
            while (stack.Count > 0 && maxHeights[stack.Peek()] > maxHeights[i])
                stack.Pop();
            if (stack.Count == 0)
                preSum[i] = (long)(i + 1) * maxHeights[i];
            else
                preSum[i] = preSum[stack.Peek()] + (long)(i - stack.Peek()) * maxHeights[i];
            stack.Push(i);
        }
        stack.Clear();
        //后缀和计算
        for (int i = len - 1; i >= 0; i--)
        {
            while (stack.Count > 0 && maxHeights[stack.Peek()] > maxHeights[i])
                stack.Pop();
            if (stack.Count == 0)
                sufSum[i] = (long)(len - i) * maxHeights[i];
            else
                sufSum[i] = sufSum[stack.Peek()] + (long)(stack.Peek() - i) * maxHeights[i];
            stack.Push(i);
            max = Math.Max(max, preSum[i] + sufSum[i] - maxHeights[i]);
        }
        return max;
    }
}
// @lc code=end


/*
 * @lc app=leetcode.cn id=739 lang=csharp
 * @lcpr version=30122
 *
 * [739] 每日温度
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        var ans = new int[temperatures.Length];
        var stack = new Stack<int>();
        for (var i = temperatures.Length - 1; i >= 0; i--)
        {
            while (stack.Count > 0 && temperatures[i] >= temperatures[stack.Peek()])
            {
                stack.Pop();
            }
            ans[i] = stack.Count == 0 ? 0 : stack.Peek() - i;
            stack.Push(i);
        }
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [73,74,75,71,69,72,76,73]\n
// @lcpr case=end

// @lcpr case=start
// [30,40,50,60]\n
// @lcpr case=end

// @lcpr case=start
// [30,60,90]\n
// @lcpr case=end

 */


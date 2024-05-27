/*
 * @lc app=leetcode.cn id=1673 lang=csharp
 * @lcpr version=30202
 *
 * [1673] 找出最具竞争力的子序列
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int[] MostCompetitive(int[] nums, int k)
    {
        var stack = new Stack<int>();
        var remove = nums.Length - k;
        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];
            while (stack.Count > 0 && stack.Peek() > num && remove > 0)
            {
                stack.Pop();
                remove--;
            }
            stack.Push(num);
        }
        while (remove > 0)
        {
            stack.Pop();
            remove--;
        }
        var ans = new int[k];
        for (int i = k - 1; i >= 0; i--)
        {
            ans[i] = stack.Pop();
        }
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [3,5,2,6]\n2\n
// @lcpr case=end

// @lcpr case=start
// [2,4,3,3,5,4,9,6]\n4\n
// @lcpr case=end

 */


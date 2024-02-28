/*
 * @lc app=leetcode.cn id=1929 lang=csharp
 * @lcpr version=30117
 *
 * [1929] 数组串联
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int[] GetConcatenation(int[] nums)
    {
        var n = nums.Length;
        var ans = new int[n * 2];
        for (var i = 0; i < 2; i++)
        {
            for (var j = 0; j < n; j++)
            {
                ans[i * n + j] = nums[j];
            }
        }
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,1]\n
// @lcpr case=end

// @lcpr case=start
// [1,3,2,1]\n
// @lcpr case=end

 */


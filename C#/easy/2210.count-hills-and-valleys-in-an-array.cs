/*
 * @lc app=leetcode.cn id=2210 lang=csharp
 * @lcpr version=30119
 *
 * [2210] 统计数组中峰和谷的数量
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int CountHillValley(int[] nums)
    {
        int count = 0;
        int n = nums.Length;
        int prev = 0;
        int curr = 1;
        while (curr < n - 1)
        {
            while (curr < n - 1 && nums[curr] == nums[curr + 1])
            {
                curr++;
            }
            if (curr < n - 1)
            {
                int next = curr + 1;
                if (nums[curr] > Math.Max(nums[prev], nums[next]) || nums[curr] < Math.Min(nums[prev], nums[next]))
                {
                    count++;
                }
            }
            prev = curr;
            curr++;
        }
        return count;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [2,4,1,1,6,5]\n
// @lcpr case=end

// @lcpr case=start
// [6,6,5,5,4,1]\n
// @lcpr case=end

 */


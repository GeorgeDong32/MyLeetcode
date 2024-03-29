/*
 * @lc app=leetcode.cn id=2908 lang=csharp
 * @lcpr version=30121
 *
 * [2908] 元素和最小的山形三元组 I
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MinimumSum(int[] nums)
    {
        int minSum = int.MaxValue;
        int n = nums.Length;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (nums[i] >= nums[j])
                {
                    continue;
                }
                for (int k = j + 1; k < n; k++)
                {
                    if (nums[k] >= nums[j])
                    {
                        continue;
                    }
                    minSum = Math.Min(minSum, nums[i] + nums[j] + nums[k]);
                }
            }
        }
        return minSum != int.MaxValue ? minSum : -1;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [8,6,1,5,3]\n
// @lcpr case=end

// @lcpr case=start
// [5,4,8,7,10,2]\n
// @lcpr case=end

// @lcpr case=start
// [6,5,4,3,4,5]\n
// @lcpr case=end

 */


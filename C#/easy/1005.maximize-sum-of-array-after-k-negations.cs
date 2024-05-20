/*
 * @lc app=leetcode.cn id=1005 lang=csharp
 * @lcpr version=30202
 *
 * [1005] K 次取反后最大化的数组和
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int LargestSumAfterKNegations(int[] nums, int k)
    {
        Array.Sort(nums);
        int i = 0;
        while (i < nums.Length && k > 0 && nums[i] < 0)
        {
            nums[i] = -nums[i];
            i++;
            k--;
        }
        if (k % 2 != 0)
        {
            if (i > 0 && (i == nums.Length || nums[i - 1] < nums[i]))
            {
                nums[i - 1] = -nums[i - 1];
            }
            else
            {
                nums[i] = -nums[i];
            }
        }
        return nums.Sum();
    }
}
// @lc code=end



/*
// @lcpr case=start
// [4,2,3]\n1\n
// @lcpr case=end

// @lcpr case=start
// [3,-1,0,2]\n3\n
// @lcpr case=end

// @lcpr case=start
// [2,-3,-1,5,-4]\n2\n
// @lcpr case=end

 */


/*
 * @lc app=leetcode.cn id=2460 lang=csharp
 * @lcpr version=30121
 *
 * [2460] 对数组执行操作
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int[] ApplyOperations(int[] nums)
    {
        int n = nums.Length;
        for (int i = 0, j = 0; i < n; i++)
        {
            if (i + 1 < n && nums[i] == nums[i + 1])
            {
                nums[i] *= 2;
                nums[i + 1] = 0;
            }
            if (nums[i] != 0)
            {
                Swap(nums, i, j);
                j++;
            }
        }
        return nums;
    }

    public void Swap(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,2,1,1,0]\n
// @lcpr case=end

// @lcpr case=start
// [0,1]\n
// @lcpr case=end

 */


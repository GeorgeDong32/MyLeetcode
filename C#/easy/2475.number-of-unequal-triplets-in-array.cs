/*
 * @lc app=leetcode.cn id=2475 lang=csharp
 * @lcpr version=30121
 *
 * [2475] 数组中不等三元组的数目
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int UnequalTriplets(int[] nums)
    {
        Array.Sort(nums);
        int count = 0;
        for (int i = 0; i < nums.Length - 2; i++)
        {
            for (int j = i + 1; j < nums.Length - 1; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    if (nums[i] != nums[j] && nums[j] != nums[k] && nums[i] != nums[k])
                    {
                        count++;
                    }
                }
            }
        }
        return count;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [4,4,2,4,3]\n
// @lcpr case=end

// @lcpr case=start
// [1,1,1,1,1]\n
// @lcpr case=end

 */


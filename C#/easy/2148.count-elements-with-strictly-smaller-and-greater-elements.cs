/*
 * @lc app=leetcode.cn id=2148 lang=csharp
 * @lcpr version=30119
 *
 * [2148] 元素计数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int CountElements(int[] nums)
    {
        var count = 0;
        Array.Sort(nums);
        for (var i = 1; i < nums.Length - 1; i++)
        {
            if (nums[i] != nums[0] && nums[i] != nums[nums.Length - 1])
                count++;
        }
        return count;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [11,7,2,15]\n
// @lcpr case=end

// @lcpr case=start
// [-3,3,3,90]\n
// @lcpr case=end

 */


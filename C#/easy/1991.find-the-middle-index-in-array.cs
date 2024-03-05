/*
 * @lc app=leetcode.cn id=1991 lang=csharp
 * @lcpr version=30118
 *
 * [1991] 找到数组的中间位置
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int FindMiddleIndex(int[] nums)
    {
        int totalSum = nums.Sum();
        int leftSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (leftSum == totalSum - leftSum - nums[i])
            {
                return i;
            }
            leftSum += nums[i];
        }
        return -1;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [2,3,-1,8,4]\n
// @lcpr case=end

// @lcpr case=start
// [1,-1,4]\n
// @lcpr case=end

// @lcpr case=start
// [2,5]\n
// @lcpr case=end

// @lcpr case=start
// [1]\n
// @lcpr case=end

 */


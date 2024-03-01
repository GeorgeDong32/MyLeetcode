/*
 * @lc app=leetcode.cn id=1863 lang=csharp
 * @lcpr version=30117
 *
 * [1863] 找出所有子集的异或总和再求和
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int SubsetXORSum(int[] nums)
    {
        var ans = 0;
        foreach (var num in nums)
        {
            ans |= num;
        }
        return ans << (nums.Length - 1);
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,3]\n
// @lcpr case=end

// @lcpr case=start
// [5,1,6]\n
// @lcpr case=end

// @lcpr case=start
// [3,4,5,6,7,8]\n
// @lcpr case=end

 */


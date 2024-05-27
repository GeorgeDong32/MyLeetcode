/*
 * @lc app=leetcode.cn id=2903 lang=csharp
 * @lcpr version=30202
 *
 * [2903] 找出满足差值条件的下标 I
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int[] FindIndices(int[] nums, int indexDifference, int valueDifference)
    {
        return nums.Take(nums.Length - indexDifference).SelectMany((num, i) => Enumerable.Range(i + indexDifference, nums.Length - indexDifference - i).Select(j => new int[2] { i, j })).FirstOrDefault(arr => Math.Abs(nums[arr[0]] - nums[arr[1]]) >= valueDifference, new int[2] { -1, -1 });
    }
}
// @lc code=end



/*
// @lcpr case=start
// [5,1,4,1]\n2\n4\n
// @lcpr case=end

// @lcpr case=start
// [2,1]\n0\n0\n
// @lcpr case=end

// @lcpr case=start
// [1,2,3]\n2\n4\n
// @lcpr case=end

 */


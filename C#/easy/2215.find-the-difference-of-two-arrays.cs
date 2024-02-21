/*
 * @lc app=leetcode.cn id=2215 lang=csharp
 * @lcpr version=30116
 *
 * [2215] 找出两数组的不同
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        var ans = new List<IList<int>>
        {
            nums1.Except(nums2).ToList(),
            nums2.Except(nums1).ToList()
        };
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,3]\n[2,4,6]\n
// @lcpr case=end

// @lcpr case=start
// [1,2,3,3]\n[1,1,2,2]\n
// @lcpr case=end

 */


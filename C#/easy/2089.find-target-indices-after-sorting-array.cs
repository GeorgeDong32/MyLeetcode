/*
 * @lc app=leetcode.cn id=2089 lang=csharp
 * @lcpr version=30119
 *
 * [2089] 找出数组排序后的目标下标
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
using System.Security.Cryptography.X509Certificates;

public class Solution
{
    public IList<int> TargetIndices(int[] nums, int target)
    {
        Array.Sort(nums);
        return nums.Select((x, i) => i).Where(i => nums[i] == target).ToArray();
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,5,2,3]\n2\n
// @lcpr case=end

// @lcpr case=start
// [1,2,5,2,3]\n3\n
// @lcpr case=end

// @lcpr case=start
// [1,2,5,2,3]\n5\n
// @lcpr case=end

// @lcpr case=start
// [1,2,5,2,3]\n4\n
// @lcpr case=end

 */


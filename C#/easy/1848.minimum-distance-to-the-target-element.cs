/*
 * @lc app=leetcode.cn id=1848 lang=csharp
 * @lcpr version=30117
 *
 * [1848] 到目标元素的最小距离
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int GetMinDistance(int[] nums, int target, int start)
    {
        int minDistance = nums.Length;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {
                int distance = Math.Abs(i - start);
                minDistance = Math.Min(minDistance, distance);
            }
        }
        return minDistance;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,3,4,5]\n5\n3\n
// @lcpr case=end

// @lcpr case=start
// [1]\n1\n0\n
// @lcpr case=end

// @lcpr case=start
// [1,1,1,1,1,1,1,1,1,1]\n1\n0\n
// @lcpr case=end

 */


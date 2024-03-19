/*
 * @lc app=leetcode.cn id=2176 lang=csharp
 * @lcpr version=30119
 *
 * [2176] 统计数组中相等且可以被整除的数对
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int CountPairs(int[] nums, int k)
    {
        var count = 0;
        for (var i = 0; i < nums.Length - 1; ++i)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                    if (i * j % k == 0)
                        count++;
            }
        }
        return count;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [3,1,2,2,2,1,3]\n2\n
// @lcpr case=end

// @lcpr case=start
// [1,2,3,4]\n1\n
// @lcpr case=end

 */


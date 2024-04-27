/*
 * @lc app=leetcode.cn id=1493 lang=csharp
 * @lcpr version=30122
 *
 * [1493] 删掉一个元素以后全为 1 的最长子数组
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int LongestSubarray(int[] nums)
    {
        int left = 0, right = 0;
        int maxCount = 0;
        int zeroCount = 0;
        while (right < nums.Length)
        {
            if (nums[right] == 0)
            {
                zeroCount++;
            }
            while (zeroCount > 1)
            {
                if (nums[left] == 0)
                {
                    zeroCount--;
                }
                left++;
            }
            maxCount = Math.Max(maxCount, right - left + 1);
            right++;
        }
        return maxCount - 1;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,1,0,1]\n
// @lcpr case=end

// @lcpr case=start
// [0,1,1,1,0,1,1,0,1]\n
// @lcpr case=end

// @lcpr case=start
// [1,1,1]\n
// @lcpr case=end

 */


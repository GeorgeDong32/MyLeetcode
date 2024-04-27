/*
 * @lc app=leetcode.cn id=1004 lang=csharp
 * @lcpr version=30122
 *
 * [1004] 最大连续1的个数 III
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int LongestOnes(int[] nums, int k)
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
            while (zeroCount > k)
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
        return maxCount;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,1,1,0,0,0,1,1,1,1,0]\n2\n
// @lcpr case=end

// @lcpr case=start
// [0,0,1,1,0,0,1,1,1,0,1,1,0,0,0,1,1,1,1]\n3\n
// @lcpr case=end

 */


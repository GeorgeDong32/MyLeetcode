/*
 * @lc app=leetcode.cn id=2562 lang=csharp
 * @lcpr version=30122
 *
 * [2562] 找出数组的串联值
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public long FindTheArrayConcVal(int[] nums)
    {
        if (nums.Length < 2)
            return nums[0];
        long ans = 0;
        var l = 0; var r = nums.Length - 1;
        while (l < r)
        {
            ans += int.Parse($"{nums[l]}{nums[r]}");
            l++; r--;
        }
        if (l == r)
            ans += nums[l];
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [7,52,2,4]\n
// @lcpr case=end

// @lcpr case=start
// [5,14,13,8,12]\n
// @lcpr case=end

 */


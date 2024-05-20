/*
 * @lc app=leetcode.cn id=376 lang=csharp
 * @lcpr version=30202
 *
 * [376] 摆动序列
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int WiggleMaxLength(int[] nums)
    {
        var ans = 1;
        var prev = 0;
        var curr = 0;
        for (var i = 1; i < nums.Length; i++)
        {
            curr = nums[i] - nums[i - 1];
            if (curr > 0 && prev <= 0 || curr < 0 && prev >= 0)
            {
                ans++;
                prev = curr;
            }
        }
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,7,4,9,2,5]\n
// @lcpr case=end

// @lcpr case=start
// [1,17,5,10,13,15,10,5,16,8]\n
// @lcpr case=end

// @lcpr case=start
// [1,2,3,4,5,6,7,8,9]\n
// @lcpr case=end

 */


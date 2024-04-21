/*
 * @lc app=leetcode.cn id=283 lang=csharp
 * @lcpr version=30122
 *
 * [283] 移动零
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        var l = 0; var r = 0;
        while (r < nums.Length)
        {
            if (nums[r] != 0)
            {
                var temp = nums[r];
                nums[r] = nums[l];
                nums[l] = temp;
                l++;
            }
            r++;
        }
    }
}
// @lc code=end



/*
// @lcpr case=start
// [0,1,0,3,12]\n
// @lcpr case=end

// @lcpr case=start
// [0]\n
// @lcpr case=end

 */


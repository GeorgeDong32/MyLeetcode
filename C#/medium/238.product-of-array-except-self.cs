/*
 * @lc app=leetcode.cn id=238 lang=csharp
 * @lcpr version=30122
 *
 * [238] 除自身以外数组的乘积
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] prefix = new int[nums.Length];
        int[] suffix = new int[nums.Length];
        var i = 0; var j = nums.Length - 1;
        prefix[0] = 1; suffix[nums.Length - 1] = 1;
        while (i < nums.Length - 1 && j > 0)
        {
            //prefix
            prefix[i + 1] = prefix[i] * nums[i];
            //suffix
            suffix[j - 1] = suffix[j] * nums[j];
            i++; j--;
        }
        for (i = 0; i < nums.Length; i++)
        {
            prefix[i] *= suffix[i];
        }
        return prefix;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,3,4]\n
// @lcpr case=end

// @lcpr case=start
// [-1,1,0,-3,3]\n
// @lcpr case=end

 */


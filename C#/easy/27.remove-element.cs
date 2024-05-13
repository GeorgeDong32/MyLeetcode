/*
 * @lc app=leetcode.cn id=27 lang=csharp
 * @lcpr version=30201
 *
 * [27] 移除元素
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        var fasti = 0;
        var slowi = 0;
        for (fasti = 0; fasti < nums.Length; fasti++)
        {
            if (nums[fasti] != val)
            {
                nums[slowi] = nums[fasti];
                slowi++;
            }
        }
        return slowi;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [3,2,2,3]\n3\n
// @lcpr case=end

// @lcpr case=start
// [0,1,2,2,3,0,4,2]\n2\n
// @lcpr case=end

 */


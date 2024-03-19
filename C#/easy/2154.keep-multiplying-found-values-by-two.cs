/*
 * @lc app=leetcode.cn id=2154 lang=csharp
 * @lcpr version=30119
 *
 * [2154] 将找到的值乘以 2
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int FindFinalValue(int[] nums, int original)
    {
        var no = original;
        var index = Array.IndexOf(nums, no);
        while (index != -1)
        {
            no *= 2;
            index = Array.IndexOf(nums, no);
        }
        return no;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [5,3,6,1,12]\n3\n
// @lcpr case=end

// @lcpr case=start
// [2,7,9]\n4\n
// @lcpr case=end

 */


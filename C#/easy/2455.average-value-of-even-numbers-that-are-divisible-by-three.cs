/*
 * @lc app=leetcode.cn id=2455 lang=csharp
 * @lcpr version=30121
 *
 * [2455] 可被三整除的偶数的平均值
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int AverageValue(int[] nums)
    {
        var tars = nums.Where(x => x % 2 == 0 && x % 3 == 0).ToArray();
        return tars.Length > 0 ? (int)tars.Average() : 0;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,3,6,10,12,15]\n
// @lcpr case=end

// @lcpr case=start
// [1,2,4,7,10]\n
// @lcpr case=end

 */


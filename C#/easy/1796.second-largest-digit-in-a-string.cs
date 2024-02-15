/*
 * @lc app=leetcode.cn id=1796 lang=csharp
 * @lcpr version=30116
 *
 * [1796] 字符串中第二大的数字
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int SecondHighest(string s)
    {
        var chars = s.Where(c => c >= '0' && c <= '9').Distinct();
        var nums = chars.Select(c => c - '0').ToArray();
        Array.Sort(nums);
        return nums.Length > 1 ? nums[nums.Length - 2] : -1;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "dfa12321afd"\n
// @lcpr case=end

// @lcpr case=start
// "abc1111"\n
// @lcpr case=end

 */


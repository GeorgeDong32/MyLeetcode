/*
 * @lc app=leetcode.cn id=2309 lang=csharp
 * @lcpr version=30116
 *
 * [2309] 兼具大小写的最好英文字母
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public string GreatestLetter(string s)
    {
        var ans = "";
        try
        {
            ans = s.Where(c => s.Contains(c.ToString().ToLower()) && s.Contains(c.ToString().ToUpper())).OrderBy(c => c).Last().ToString().ToUpper();
        }
        catch (Exception e)
        {
            ans = "";
        }
        return String.IsNullOrEmpty(ans) ? "" : ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "lEeTcOdE"\n
// @lcpr case=end

// @lcpr case=start
// "arRAzFif"\n
// @lcpr case=end

// @lcpr case=start
// "AbCdEfGhIjK"\n
// @lcpr case=end

 */


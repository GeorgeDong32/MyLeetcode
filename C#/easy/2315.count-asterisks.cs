/*
 * @lc app=leetcode.cn id=2315 lang=csharp
 * @lcpr version=30121
 *
 * [2315] 统计星号
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int CountAsterisks(string s)
    {
        var inside = false;
        var star = 0;
        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == '|')
                inside = !inside;
            else if (!inside && s[i] == '*')
                star++;
        }
        return star;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "l|*e*et|c**o|*de|"\n
// @lcpr case=end

// @lcpr case=start
// "iamprogrammer"\n
// @lcpr case=end

// @lcpr case=start
// "yo|uar|e**|b|e***au|tifu|l"\n
// @lcpr case=end

 */


/*
 * @lc app=leetcode.cn id=455 lang=csharp
 * @lcpr version=30202
 *
 * [455] 分发饼干
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int FindContentChildren(int[] g, int[] s)
    {
        Array.Sort(g);
        Array.Sort(s);
        var index = 0;
        for (var i = 0; i < s.Length; i++)
        {
            if (index < g.Length && g[index] <= s[i])
            {
                index++;
            }
        }
        return index;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,3]\n[1,1]\n
// @lcpr case=end

// @lcpr case=start
// [1,2]\n[1,2,3]\n
// @lcpr case=end

 */


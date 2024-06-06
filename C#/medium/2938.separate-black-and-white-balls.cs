/*
 * @lc app=leetcode.cn id=2938 lang=csharp
 * @lcpr version=30203
 *
 * [2938] 区分黑球与白球
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public long MinimumSteps(string s)
    {
        var blacks = new Stack<int>();
        var l = s.Length;
        for (var i = 0; i < l; i++)
        {
            if (s[i] == '1')
                blacks.Push(i);
        }
        var bc = blacks.Count;
        long ans = 0;
        for (var i = 1; i <= bc; i++)
        {
            var temp = blacks.Pop();
            ans += l - i - temp;
        }
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "101"\n
// @lcpr case=end

// @lcpr case=start
// "100"\n
// @lcpr case=end

// @lcpr case=start
// "0111"\n
// @lcpr case=end

 */


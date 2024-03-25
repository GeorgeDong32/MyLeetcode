/*
 * @lc app=leetcode.cn id=2264 lang=csharp
 * @lcpr version=30120
 *
 * [2264] 字符串中最大的 3 位相同数字
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public string LargestGoodInteger(string num)
    {
        var subs = new List<string>();
        for (int i = 0; i <= num.Length - 3; i++)
        {
            subs.Add(num.Substring(i, 3));
        }
        var ans = subs.Where(s => s[0] == s[1] && s[1] == s[2]).Max();
        return ans == null ? "" : ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "6777133339"\n
// @lcpr case=end

// @lcpr case=start
// "2300019"\n
// @lcpr case=end

// @lcpr case=start
// "42352338"\n
// @lcpr case=end

 */


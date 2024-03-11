/*
 * @lc app=leetcode.cn id=2129 lang=csharp
 * @lcpr version=30119
 *
 * [2129] 将标题首字母大写
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
using System.Text;

public class Solution
{
    public string CapitalizeTitle(string title)
    {
        var split = title.ToLower().Split(' ');
        var sb = new StringBuilder();
        foreach (var s in split)
        {
            if (s.Length <= 2)
                sb.Append(s + " ");
            else
                sb.Append(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(s.ToLowerInvariant() + " "));
        }
        return sb.ToString().Trim();
    }
}
// @lc code=end



/*
// @lcpr case=start
// "capiTalIze tHe titLe"\n
// @lcpr case=end

// @lcpr case=start
// "First leTTeR of EACH Word"\n
// @lcpr case=end

// @lcpr case=start
// "i lOve leetcode"\n
// @lcpr case=end

 */


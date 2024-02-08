/*
 * @lc app=leetcode.cn id=1694 lang=csharp
 * @lcpr version=30116
 *
 * [1694] 重新格式化电话号码
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
using System.Text;

public class Solution
{
    public string ReformatNumber(string number)
    {
        var ns = number.Replace(" ", "").Replace("-", "");
        var len = ns.Length;
        var sb = new StringBuilder();
        int i = 0;
        while (i < len)
        {
            if (len - i == 4)
            {
                sb.Append(ns.Substring(i, 2)).Append('-');
                sb.Append(ns.Substring(i + 2, 2)).Append('-');
                i += 4;
            }
            else if (len - i == 2)
            {
                sb.Append(ns.Substring(i, 2)).Append('-');
                i += 2;
            }
            else
            {
                sb.Append(ns.Substring(i, 3)).Append('-');
                i += 3;
            }
        }
        return sb.ToString().TrimEnd('-');
    }
}
// @lc code=end



/*
// @lcpr case=start
// "1-23-45 6"\n
// @lcpr case=end

// @lcpr case=start
// "123 4-567"\n
// @lcpr case=end

// @lcpr case=start
// "123 4-5678"\n
// @lcpr case=end

// @lcpr case=start
// "12"\n
// @lcpr case=end

// @lcpr case=start
// "--17-5 229 35-39475 "\n
// @lcpr case=end

 */


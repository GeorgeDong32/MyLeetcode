/*
 * @lc app=leetcode.cn id=1773 lang=csharp
 *
 * [1773] 统计匹配检索规则的物品数量
 */

// @lc code=start
public class Solution
{
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
    {
        var count = 0;
        switch (ruleKey)
        {
            case "type":
                count = items.Where(item => item[0].Equals(ruleValue)).Count();
                break;
            case "color":
                count = items.Where(item => item[1].Equals(ruleValue)).Count();
                break;
            case "name":
                count = items.Where(item => item[2].Equals(ruleValue)).Count();
                break;
        }
        return count;
    }
}
// @lc code=end


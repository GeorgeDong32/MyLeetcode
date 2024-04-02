/*
 * @lc app=leetcode.cn id=2347 lang=csharp
 * @lcpr version=30121
 *
 * [2347] 最好的扑克手牌
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public string BestHand(int[] ranks, char[] suits)
    {
        if (suits.All(s => s == suits[0]))
            return "Flush";
        if (ranks.GroupBy(x => x).Any(g => g.Count() >= 3))
            return "Three of a Kind";
        if (ranks.GroupBy(x => x).Any(g => g.Count() >= 2))
            return "Pair";
        if (ranks.GroupBy(x => x).All(g => g.Count() == 1))
            return "High Card";
        else
            return "";
    }
}
// @lc code=end



/*
// @lcpr case=start
// [13,2,3,1,9]\n["a","a","a","a","a"]\n
// @lcpr case=end

// @lcpr case=start
// [4,4,2,4,4]\n["d","a","a","b","c"]\n
// @lcpr case=end

// @lcpr case=start
// [10,10,2,12,9]\n["a","b","c","a","d"]\n
// @lcpr case=end

 */


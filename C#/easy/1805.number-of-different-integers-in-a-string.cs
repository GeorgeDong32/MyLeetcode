/*
 * @lc app=leetcode.cn id=1805 lang=csharp
 * @lcpr version=30116
 *
 * [1805] 字符串中不同整数的数目
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int NumDifferentIntegers(string word)
    {
        var newWord = System.Text.RegularExpressions.Regex.Replace(word, "[^0-9]", " ");
        var nums = newWord.Split(' ', System.StringSplitOptions.RemoveEmptyEntries);
        var set = new HashSet<string>();
        foreach (var num in nums)
        {
            set.Add(num.TrimStart('0'));
        }
        return set.Count;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "a123bc34d8ef34"\n
// @lcpr case=end

// @lcpr case=start
// "leet1234code234"\n
// @lcpr case=end

// @lcpr case=start
// "a1b01c001"\n
// @lcpr case=end

 */


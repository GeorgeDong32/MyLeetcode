/*
 * @lc app=leetcode.cn id=383 lang=csharp
 *
 * [383] 赎金信
 */

// @lc code=start
public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        if (ransomNote.Length > magazine.Length)
            return false;
        return ransomNote.ToLookup(c => c).All(r => magazine.ToLookup(c => c)[r.Key].Count() >= r.Count());
    }
}
// @lc code=end


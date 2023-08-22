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
        var count = new int[26];
        if (ransomNote.Length > magazine.Length)
            return false;
        for (int i = 0; i < magazine.Length; i++)
        {
            count[magazine[i] - 'a']++;
        }
        for (int i = 0; i < ransomNote.Length; i++)
        {
            count[ransomNote[i] - 'a']--;
            if (count[ransomNote[i] - 'a'] < 0)
                return false;
        }
        return true;
    }
}
// @lc code=end


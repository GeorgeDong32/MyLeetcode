/*
 * @lc app=leetcode.cn id=187 lang=csharp
 *
 * [187] 重复的DNA序列
 */

// @lc code=start
public class Solution
{
    public IList<string> FindRepeatedDnaSequences(string s)
    {
        List<string> ans = new();
        const int L = 10;
        Dictionary<string, int> dict = new();
        for (var i = 0; i <= s.Length - L; i++)
        {
            var sub = s.Substring(i, L);
            if (!dict.ContainsKey(sub))
            {
                dict.Add(sub, 1);
            }
            else
            {
                dict[sub]++;
            }
            if (dict[sub] == 2)
                ans.Add(sub);
        }
        return ans;
    }
}
// @lc code=end


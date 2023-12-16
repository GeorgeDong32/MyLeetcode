/*
 * @lc app=leetcode.cn id=953 lang=csharp
 *
 * [953] 验证外星语词典
 */

// @lc code=start
public class Solution
{
    public bool IsAlienSorted(string[] words, string order)
    {
        var index = new int[26];
        for (var i = 0; i < order.Length; i++)
        {
            index[order[i] - 'a'] = i;
        }
        for (int i = 1; i < words.Length; i++)
        {
            bool valid = false;
            for (int j = 0; j < words[i - 1].Length && j < words[i].Length; j++)
            {
                int prev = index[words[i - 1][j] - 'a'];
                int curr = index[words[i][j] - 'a'];
                if (prev < curr)
                {
                    valid = true;
                    break;
                }
                else if (prev > curr)
                {
                    return false;
                }
            }
            if (!valid)
            {
                if (words[i - 1].Length > words[i].Length)
                {
                    return false;
                }
            }
        }
        return true;
    }
}
// @lc code=end


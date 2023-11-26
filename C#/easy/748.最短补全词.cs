/*
 * @lc app=leetcode.cn id=748 lang=csharp
 *
 * [748] 最短补全词
 */

// @lc code=start
public class Solution
{
    public string ShortestCompletingWord(string licensePlate, string[] words)
    {
        string ans = null;
        int[] cnt_0 = new int[26];
        int[] cnt_1 = new int[26];
        foreach (char item in licensePlate)
        {
            if (char.IsLetter(item))
            {
                cnt_0[char.ToLower(item) - 'a']++;
            }
        }
        foreach (var item in words)
        {
            if (ans != null && item.Length >= ans.Length)
            {
                continue;
            }
            Array.Fill(cnt_1, 0);
            foreach (char c in item)
            {
                cnt_1[c - 'a']++;
            }
            bool flag = true;
            for (int i = 0; i < 26; i++)
            {
                if (cnt_0[i] > cnt_1[i])
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                ans = item;
            }
        }
        return ans;
    }
}
// @lc code=end


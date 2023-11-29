/*
 * @lc app=leetcode.cn id=819 lang=csharp
 *
 * [819] 最常见的单词
 */

// @lc code=start
using System.Text;

public class Solution
{
    public string MostCommonWord(string paragraph, string[] banned)
    {
        ISet<string> bannedSet = new HashSet<string>();
        foreach (string word in banned)
        {
            bannedSet.Add(word);
        }
        int maxFrequency = 0;
        Dictionary<string, int> frequencies = new Dictionary<string, int>();
        StringBuilder sb = new();
        int length = paragraph.Length;
        for (int i = 0; i <= length; i++)
        {
            if (i < length && char.IsLetter(paragraph[i]))
            {
                sb.Append(char.ToLower(paragraph[i]));
            }
            else if (sb.Length > 0)
            {
                string word = sb.ToString();
                if (!bannedSet.Contains(word))
                {
                    if (!frequencies.ContainsKey(word))
                    {
                        frequencies.Add(word, 1);
                    }
                    else
                    {
                        frequencies[word]++;
                    }
                    maxFrequency = Math.Max(maxFrequency, frequencies[word]);
                }
                sb.Length = 0;
            }
        }
        string mostCommon = "";
        foreach (KeyValuePair<string, int> pair in frequencies)
        {
            string word = pair.Key;
            int frequency = pair.Value;
            if (frequency == maxFrequency)
            {
                mostCommon = word;
                break;
            }
        }
        return mostCommon;
    }
}
// @lc code=end


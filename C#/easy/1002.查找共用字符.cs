/*
 * @lc app=leetcode.cn id=1002 lang=csharp
 *
 * [1002] 查找共用字符
 */

// @lc code=start
public class Solution
{
    public IList<string> CommonChars(string[] words)
    {
        IList<string> list = new List<string>();

        string str = words[0];
        for (int i = 0; i < str.Length; i++)
        {
            int j;
            for (j = 0; j < words.Length; j++)
            {
                if (!words[j].Contains(str[i]))
                    break;
                else words[j] = words[j].Remove(words[j].IndexOf(str[i]), 1);
            }
            if (j == words.Length) list.Add(str[i].ToString());
        }
        return list;
    }
}
// @lc code=end


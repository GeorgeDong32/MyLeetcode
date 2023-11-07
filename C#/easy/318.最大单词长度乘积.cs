/*
 * @lc app=leetcode.cn id=318 lang=csharp
 *
 * [318] 最大单词长度乘积
 */

// @lc code=start
using System.Reflection.Metadata.Ecma335;

public class Solution
{
    public int MaxProduct(string[] words)
    {
        int l = words.Length;
        int[] abw = new int[l];
        var count = 0;
        foreach (var word in words)
        {
            for (var i = 0; i < word.Length; i++)
            {
                abw[count] |= 1 << (word[i] - 'a');
            }
            count++;
        }
        var res = 0;
        for (int i = 0; i < l; i++)
        {
            for (int j = i + 1; j < l; j++)
            {
                if ((abw[i] & abw[j]) == 0)
                {
                    res = Math.Max(res, words[i].Length * words[j].Length);
                }
            }
        }
        return res;
    }
}
// @lc code=end


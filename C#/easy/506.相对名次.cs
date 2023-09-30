/*
 * @lc app=leetcode.cn id=506 lang=csharp
 *
 * [506] 相对名次
 */

// @lc code=start
public class Solution
{
    public string[] FindRelativeRanks(int[] score)
    {
        var l = score.Length;
        var sorted = new int[l];
        Array.Copy(score, sorted, l);
        var result = new List<string>();
        Array.Sort(sorted);
        for (var i = 0; i < l; i++)
        {
            var s = score[i];
            var rank = Array.IndexOf(sorted, s);
            if (rank == l - 1)
            {
                result.Add("Gold Medal");
            }
            else if (rank == l - 2)
            {
                result.Add("Silver Medal");
            }
            else if (rank == l - 3)
            {
                result.Add("Bronze Medal");
            }
            else
            {
                result.Add((l - rank).ToString());
            }
        }
        return result.ToArray();
    }
}
// @lc code=end


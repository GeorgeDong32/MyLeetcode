/*
 * @lc app=leetcode.cn id=1686 lang=csharp
 *
 * [1686] 石子游戏 VI
 */

// @lc code=start
public class Solution
{
    public int StoneGameVI(int[] aliceValues, int[] bobValues)
    {
        int n = aliceValues.Length;
        var values = new List<(int, int)>();
        for (int i = 0; i < n; i++)
        {
            values.Add((aliceValues[i] + bobValues[i], i));
        }
        values.Sort((x, y) => y.Item1 - x.Item1);
        int aliceScore = 0, bobScore = 0;
        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
            {
                aliceScore += aliceValues[values[i].Item2];
            }
            else
            {
                bobScore += bobValues[values[i].Item2];
            }
        }
        return aliceScore > bobScore ? 1 : aliceScore < bobScore ? -1 : 0;
    }
}
// @lc code=end


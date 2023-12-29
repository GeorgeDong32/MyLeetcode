/*
 * @lc app=leetcode.cn id=2660 lang=csharp
 *
 * [2660] 保龄球游戏的获胜者
 */

// @lc code=start
public class Solution
{
    public int IsWinner(int[] player1, int[] player2)
    {
        int s1 = Score(player1);
        int s2 = Score(player2);
        return s1 == s2 ? 0 : s1 > s2 ? 1 : 2;
    }

    public int Score(int[] player)
    {
        int res = 0;
        for (int i = 0; i < player.Length; i++)
        {
            if ((i > 0 && player[i - 1] == 10) || (i > 1 && player[i - 2] >= 10))
            {
                res += 2 * player[i];
            }
            else
            {
                res += player[i];
            }
        }
        return res;
    }
}
// @lc code=end


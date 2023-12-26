/*
 * @lc app=leetcode.cn id=1189 lang=csharp
 *
 * [1189] “气球” 的最大数量
 */

// @lc code=start
public class Solution
{
    public int MaxNumberOfBalloons(string text)
    {
        int[] cnt = new int[5];
        foreach (char ch in text)
        {
            if (ch == 'b')
            {
                cnt[0]++;
            }
            else if (ch == 'a')
            {
                cnt[1]++;
            }
            else if (ch == 'l')
            {
                cnt[2]++;
            }
            else if (ch == 'o')
            {
                cnt[3]++;
            }
            else if (ch == 'n')
            {
                cnt[4]++;
            }
        }
        cnt[2] /= 2;
        cnt[3] /= 2;
        return cnt.Min();
    }
}
// @lc code=end


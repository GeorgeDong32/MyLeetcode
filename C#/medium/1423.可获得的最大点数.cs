/*
 * @lc app=leetcode.cn id=1423 lang=csharp
 *
 * [1423] 可获得的最大点数
 */

// @lc code=start
public class Solution
{
    public int MaxScore(int[] cardPoints, int k)
    {
        int sum = 0;
        int n = cardPoints.Length;
        for (int i = 0; i < n; i++)
        {
            sum += cardPoints[i];
        }
        int remain = n - k;
        int remainSum = 0;
        for (int i = 0; i < remain; i++)
        {
            remainSum += cardPoints[i];
        }
        int minRemainSum = remainSum;
        for (int i = remain; i < n; i++)
        {
            remainSum -= cardPoints[i - remain];
            remainSum += cardPoints[i];
            minRemainSum = Math.Min(minRemainSum, remainSum);
        }
        return sum - minRemainSum;
    }
}
// @lc code=end


/*
 * @lc app=leetcode.cn id=1422 lang=csharp
 *
 * [1422] 分割字符串的最大得分
 */

// @lc code=start
public class Solution
{
    public int MaxScore(string s)
    {
        int count = 0;
        int maxCount = -1;
        int digitOneQuantity = 0;
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] == '1')
            {
                digitOneQuantity++;
                count--;
            }
            else
            {
                count++;
            }
            if (count > maxCount) maxCount = count;
        }
        if (s[s.Length - 1] == '1') digitOneQuantity++;
        return maxCount + digitOneQuantity;
    }
}
// @lc code=end


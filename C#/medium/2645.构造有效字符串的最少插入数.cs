/*
 * @lc app=leetcode.cn id=2645 lang=csharp
 *
 * [2645] 构造有效字符串的最少插入数
 */

// @lc code=start
public class Solution
{
    public int AddMinimum(string word)
    {
        int n = word.Length, cnt = 1;
        for (int i = 1; i < n; i++)
        {
            if (word[i] <= word[i - 1])
            {
                cnt++;
            }
        }
        return cnt * 3 - n;
    }
}
// @lc code=end


/*
 * @lc app=leetcode.cn id=942 lang=csharp
 *
 * [942] 增减字符串匹配
 */

// @lc code=start
public class Solution
{
    public int[] DiStringMatch(string s)
    {
        int n = s.Length, left = 0, right = n;
        int[] ans = new int[n + 1];
        for (int i = 0; i < n; ++i)
        {
            if (s[i] == 'I')
                ans[i] = left++;
            else
                ans[i] = right--;
        }
        ans[n] = left;
        return ans;
    }
}
// @lc code=end


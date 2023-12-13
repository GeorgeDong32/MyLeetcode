/*
 * @lc app=leetcode.cn id=2697 lang=csharp
 *
 * [2697] 字典序最小回文串
 */

// @lc code=start
public class Solution
{
    public string MakeSmallestPalindrome(string s)
    {
        var sarr = s.ToCharArray();
        int left = 0, right = sarr.Length - 1;
        while (left < right)
        {
            if (sarr[left] > sarr[right])
            {
                sarr[left] = sarr[right];
            }
            else if (sarr[left] < sarr[right])
            {
                sarr[right] = sarr[left];
            }
            left++; right--;
        }
        return new string(sarr);
    }
}
// @lc code=end


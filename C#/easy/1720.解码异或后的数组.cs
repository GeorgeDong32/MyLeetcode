/*
 * @lc app=leetcode.cn id=1720 lang=csharp
 *
 * [1720] 解码异或后的数组
 */

// @lc code=start
public class Solution
{
    public int[] Decode(int[] encoded, int first)
    {
        var ans = new int[encoded.Length + 1];
        ans[0] = first;
        for (var i = 1; i < ans.Length; i++)
        {
            ans[i] = ans[i - 1] ^ encoded[i - 1];
        }
        return ans;
    }
}
// @lc code=end


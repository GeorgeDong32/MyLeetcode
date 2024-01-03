/*
 * @lc app=leetcode.cn id=1313 lang=csharp
 *
 * [1313] 解压缩编码列表
 */

// @lc code=start
public class Solution
{
    public int[] DecompressRLElist(int[] nums)
    {
        var l = new List<int>();
        for (var i = 0; i < nums.Length; i += 2)
        {
            for (var j = 0; j < nums[i]; j++)
            {
                l.Add(nums[i + 1]);
            }
        }
        return l.ToArray();
    }
}
// @lc code=end


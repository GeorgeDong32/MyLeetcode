/*
 * @lc app=leetcode.cn id=888 lang=csharp
 *
 * [888] 公平的糖果交换
 */

// @lc code=start
public class Solution
{
    public int[] FairCandySwap(int[] aliceSizes, int[] bobSizes)
    {
        var suma = aliceSizes.Sum(); var sumb = bobSizes.Sum();
        var dict = new HashSet<int>(); var del = (suma - sumb) / 2;
        foreach (var size in aliceSizes)
        {
            if (!dict.Contains(size))
                dict.Add(size);
        }
        var ans = new int[2];
        foreach (var size in bobSizes)
        {
            int x = size + del;
            if (dict.Contains(x))
            {
                ans[0] = x;
                ans[1] = size;
                return ans;
            }
        }
        return ans;
    }
}
// @lc code=end


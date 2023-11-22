/*
 * @lc app=leetcode.cn id=703 lang=csharp
 *
 * [703] 数据流中的第 K 大元素
 */

// @lc code=start
public class KthLargest
{
    private int[] sorted;
    private int tar;
    public KthLargest(int k, int[] nums)
    {
        tar = k; sorted = nums;
        Array.Sort(sorted);
    }

    public int Add(int val)
    {
        sorted = sorted.Append(val).ToArray();
        Array.Sort(sorted);
        return sorted[sorted.Length - tar];
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */
// @lc code=end


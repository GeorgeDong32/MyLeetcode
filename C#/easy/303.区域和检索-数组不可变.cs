/*
 * @lc app=leetcode.cn id=303 lang=csharp
 *
 * [303] 区域和检索 - 数组不可变
 */

// @lc code=start
public class NumArray
{

    private int[] sum;
    public NumArray(int[] nums)
    {
        sum = new int[nums.Length + 1];
        for (int i = 1; i < sum.Length; i++)
        {
            sum[i] = sum[i - 1] + nums[i - 1];
        }
    }

    public int SumRange(int left, int right)
    {
        return sum[right + 1] - sum[left];
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */
// @lc code=end


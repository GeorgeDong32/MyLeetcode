/*
 * @lc app=leetcode.cn id=303 lang=csharp
 * @lcpr version=30119
 *
 * [303] 区域和检索 - 数组不可变
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class NumArray
{
    private int[] sum;
    public NumArray(int[] nums)
    {
        sum = new int[nums.Length];
        sum[0] = nums[0];
        for (var i = 1; i < nums.Length; i++)
        {
            sum[i] = sum[i - 1] + nums[i];
        }
    }

    public int SumRange(int left, int right)
    {
        return left <= 0 ? sum[right] : sum[right] - sum[left - 1];
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */
// @lc code=end



/*
// @lcpr case=start
// ["NumArray", "sumRange", "sumRange", "sumRange"][[[-2, 0, 3, -5, 2, -1]], [0, 2], [2, 5], [0, 5]]\n
// @lcpr case=end

 */


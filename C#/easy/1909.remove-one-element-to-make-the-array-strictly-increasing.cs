/*
 * @lc app=leetcode.cn id=1909 lang=csharp
 * @lcpr version=30117
 *
 * [1909] 删除一个元素使数组严格递增
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool CanBeIncreasing(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            var temp = new List<int>(nums);
            temp.RemoveAt(i);
            if (IsIncreasing(temp))
            {
                return true;
            }
        }
        return false;
    }

    private bool IsIncreasing(List<int> nums)
    {
        for (int i = 1; i < nums.Count; i++)
        {
            if (nums[i] <= nums[i - 1])
            {
                return false;
            }
        }
        return true;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,10,5,7]\n
// @lcpr case=end

// @lcpr case=start
// [2,3,1,2]\n
// @lcpr case=end

// @lcpr case=start
// [1,1,1]\n
// @lcpr case=end

// @lcpr case=start
// [1,2,3]\n
// @lcpr case=end

 */


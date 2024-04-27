/*
 * @lc app=leetcode.cn id=334 lang=csharp
 * @lcpr version=30122
 *
 * [334] 递增的三元子序列
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool IncreasingTriplet(int[] nums)
    {
        int length = nums.Length;
        if (length < 3)
        {
            return false;
        }
        int firstNum = nums[0], secondNum = int.MaxValue;
        for (int i = 1; i < length; i++)
        {
            int num = nums[i];
            if (num > secondNum)
            {
                return true;
            }
            else if (num > firstNum)
            {
                secondNum = num;
            }
            else
            {
                firstNum = num;
            }
        }
        return false;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,3,4,5]\n
// @lcpr case=end

// @lcpr case=start
// [5,4,3,2,1]\n
// @lcpr case=end

// @lcpr case=start
// [2,1,5,0,4,6]\n
// @lcpr case=end

 */


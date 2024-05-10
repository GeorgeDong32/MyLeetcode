/*
 * @lc app=leetcode.cn id=2105 lang=csharp
 * @lcpr version=30201
 *
 * [2105] 给植物浇水 II
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MinimumRefill(int[] plants, int capacityA, int capacityB)
    {
        int refill = 0;
        int amountA = capacityA, amountB = capacityB;
        int left = 0, right = plants.Length - 1;
        while (left < right)
        {
            if (amountA < plants[left])
            {
                refill++;
                amountA = capacityA;
            }
            if (amountB < plants[right])
            {
                refill++;
                amountB = capacityB;
            }
            amountA -= plants[left];
            amountB -= plants[right];
            left++;
            right--;
        }
        if (left == right)
        {
            if ((amountA >= amountB && amountA < plants[left]) || (amountA < amountB && amountB < plants[right]))
            {
                refill++;
            }
        }
        return refill;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [2,2,3,3]\n5\n5\n
// @lcpr case=end

// @lcpr case=start
// [2,2,3,3]\n3\n4\n
// @lcpr case=end

// @lcpr case=start
// [5]\n10\n8\n
// @lcpr case=end

 */


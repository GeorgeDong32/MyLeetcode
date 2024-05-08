/*
 * @lc app=leetcode.cn id=2300 lang=csharp
 * @lcpr version=30122
 *
 * [2300] 咒语和药水的成功对数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
    {
        Array.Sort(potions);
        var res = new int[spells.Length];
        for (var i = 0; i < spells.Length; i++)
        {
            long temp = (success + spells[i] - 1) / spells[i] - 1;
            res[i] = potions.Length - BinarySearch(potions, 0, potions.Length - 1, temp);
        }
        return res;
    }

    public static int BinarySearch(int[] arr, int lo, int hi, long target)
    {
        int res = hi + 1;
        while (lo <= hi)
        {
            int mid = lo + (hi - lo) / 2;
            if (arr[mid] > target)
            {
                res = mid;
                hi = mid - 1;
            }
            else
            {
                lo = mid + 1;
            }
        }
        return res;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [5,1,3]\n[1,2,3,4,5]\n7\n
// @lcpr case=end

// @lcpr case=start
// [3,1,2]\n[8,5,8]\n16\n
// @lcpr case=end

 */


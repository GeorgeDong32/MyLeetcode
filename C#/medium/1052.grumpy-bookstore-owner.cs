/*
 * @lc app=leetcode.cn id=1052 lang=csharp
 * @lcpr version=30122
 *
 * [1052] 爱生气的书店老板
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MaxSatisfied(int[] customers, int[] grumpy, int minutes)
    {
        var nsum = 0;
        for (var i = 0; i < customers.Length; i++)
        {
            nsum += customers[i] * (1 - grumpy[i]);
        }
        var add = 0;
        for (var i = 0; i < customers.Length - minutes + 1; i++)
        {
            var temp = 0;
            for (var j = 0; j < minutes; j++)
            {
                temp += grumpy[i + j] == 0 ? 0 : customers[i + j];
            }
            add = Math.Max(add, temp);
        }
        return nsum + add;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,0,1,2,1,1,7,5]\n[0,1,0,1,0,1,0,1]\n3\n
// @lcpr case=end

// @lcpr case=start
// [1]\n[0]\n1\n
// @lcpr case=end

 */


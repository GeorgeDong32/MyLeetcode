/*
 * @lc app=leetcode.cn id=1431 lang=csharp
 * @lcpr version=30122
 *
 * [1431] 拥有最多糖果的孩子
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var ans = new List<bool>();
        var max = candies.Max();
        var l = candies.Length;
        foreach (var c in candies)
        {
            if (c + extraCandies >= max)
                ans.Add(true);
            else
                ans.Add(false);
        }
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [2,3,5,1,3]\n3\n
// @lcpr case=end

// @lcpr case=start
// [4,2,1,1,2]\n1\n
// @lcpr case=end

// @lcpr case=start
// [12,1,12]\n10\n
// @lcpr case=end

 */


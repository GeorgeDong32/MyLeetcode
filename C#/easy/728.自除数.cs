/*
 * @lc app=leetcode.cn id=728 lang=csharp
 *
 * [728] 自除数
 */

// @lc code=start
public class Solution
{
    public IList<int> SelfDividingNumbers(int left, int right)
    {
        var ans = new List<int>();
        for (var i = left; i <= right; i++)
        {
            if (IsSelfDividing(i))
                ans.Add(i);
        }
        return ans;
    }

    public bool IsSelfDividing(int num)
    {
        int x = num;
        while (x > 0)
        {
            int d = x % 10;
            x /= 10;
            if (d == 0 || (num % d) > 0)
            {
                return false;
            }
        }
        return true;
    }
}
// @lc code=end


/*
 * @lc app=leetcode.cn id=2469 lang=csharp
 * @lcpr version=30121
 *
 * [2469] 温度转换
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public double[] ConvertTemperature(double celsius)
    {
        var res = new double[2];
        res[0] = 273.15 + celsius;
        res[1] = 1.80 * celsius + 32;
        return res;
    }
}
// @lc code=end



/*
// @lcpr case=start
// 36.50\n
// @lcpr case=end

// @lcpr case=start
// 122.11\n
// @lcpr case=end

 */


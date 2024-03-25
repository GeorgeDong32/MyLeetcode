/*
 * @lc app=leetcode.cn id=2259 lang=csharp
 * @lcpr version=30120
 *
 * [2259] 移除指定数字得到的最大结果
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
using System.Numerics;

public class Solution
{
    public string RemoveDigit(string number, char digit)
    {
        BigInteger max = 0;
        for (var i = 0; i < number.Length; i++)
        {
            if (number[i] == digit)
            {
                var temp = number.Remove(i, 1);
                max = BigInteger.Max(max, BigInteger.Parse(temp));
            }
        }
        return max.ToString();
    }
}
// @lc code=end



/*
// @lcpr case=start
// "123"\n"3"\n
// @lcpr case=end

// @lcpr case=start
// "1231"\n"1"\n
// @lcpr case=end

// @lcpr case=start
// "551"\n"5"\n
// @lcpr case=end

 */


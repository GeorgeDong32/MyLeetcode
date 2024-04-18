/*
 * @lc app=leetcode.cn id=12 lang=csharp
 * @lcpr version=30122
 *
 * [12] 整数转罗马数字
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
using System.Text;

public class Solution
{
    readonly Tuple<int, string>[] valueSymbols = {
        new(1000, "M"),
        new(900, "CM"),
        new(500, "D"),
        new(400, "CD"),
        new(100, "C"),
        new(90, "XC"),
        new(50, "L"),
        new(40, "XL"),
        new(10, "X"),
        new(9, "IX"),
        new(5, "V"),
        new(4, "IV"),
        new(1, "I")
    };

    public string IntToRoman(int num)
    {
        StringBuilder roman = new();
        foreach (var tuple in valueSymbols)
        {
            var value = tuple.Item1;
            var symbol = tuple.Item2;
            while (num >= value)
            {
                num -= value;
                roman.Append(symbol);
            }
            if (num == 0)
            {
                break;
            }
        }
        return roman.ToString();
    }
}
// @lc code=end



/*
// @lcpr case=start
// 3\n
// @lcpr case=end

// @lcpr case=start
// 4\n
// @lcpr case=end

// @lcpr case=start
// 9\n
// @lcpr case=end

// @lcpr case=start
// 58\n
// @lcpr case=end

// @lcpr case=start
// 1994\n
// @lcpr case=end

 */


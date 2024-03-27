/*
 * @lc app=leetcode.cn id=2283 lang=csharp
 * @lcpr version=30120
 *
 * [2283] 判断一个数的数字计数是否等于数位的值
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool DigitCount(string num)
    {
        for (var i = 0; i < num.Length; i++)
        {
            if (num.Count(x => x == ('0' + i)) != (num[i] - '0'))
                return false;
        }
        return true;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "1210"\n
// @lcpr case=end

// @lcpr case=start
// "030"\n
// @lcpr case=end

 */


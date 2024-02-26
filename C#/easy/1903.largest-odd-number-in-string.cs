/*
 * @lc app=leetcode.cn id=1903 lang=csharp
 * @lcpr version=30117
 *
 * [1903] 字符串中的最大奇数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public string LargestOddNumber(string num)
    {
        for (int i = num.Length - 1; i >= 0; i--)
        {
            if ((num[i] - '0') % 2 == 1)
            {
                return num.Substring(0, i + 1);
            }
        }
        return "";
    }
}
// @lc code=end



/*
// @lcpr case=start
// "52"\n
// @lcpr case=end

// @lcpr case=start
// "4206"\n
// @lcpr case=end

// @lcpr case=start
// "35427"\n
// @lcpr case=end

 */


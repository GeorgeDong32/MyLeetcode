/*
 * @lc app=leetcode.cn id=2108 lang=csharp
 * @lcpr version=30119
 *
 * [2108] 找出数组中的第一个回文字符串
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public string FirstPalindrome(string[] words)
    {
        return words.FirstOrDefault(IsPalindrome) ?? "";
    }

    private bool IsPalindrome(string str)
    {
        return str.SequenceEqual(str.Reverse());
    }
}
// @lc code=end



/*
// @lcpr case=start
// ["abc","car","ada","racecar","cool"]\n
// @lcpr case=end

// @lcpr case=start
// ["notapalindrome","racecar"]\n
// @lcpr case=end

// @lcpr case=start
// ["def","ghi"]\n
// @lcpr case=end

 */


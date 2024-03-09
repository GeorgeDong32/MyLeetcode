/*
 * @lc app=leetcode.cn id=2042 lang=csharp
 * @lcpr version=30118
 *
 * [2042] 检查句子中的数字是否递增
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool AreNumbersAscending(string s)
    {
        var split = s.Split(' ');
        var nums = split.Where(x => x.All(char.IsDigit)).Select(int.Parse).ToArray();
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] <= nums[i - 1])
                return false;
        }
        return true;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "1 box has 3 blue 4 red 6 green and 12 yellow marbles"\n
// @lcpr case=end

// @lcpr case=start
// "hello world 5 x 5"\n
// @lcpr case=end

// @lcpr case=start
// "sunset is at 7 51 pm overnight lows will be in the low 50 and 60 s"\n
// @lcpr case=end

// @lcpr case=start
// "4 5 11 26"\n
// @lcpr case=end

 */


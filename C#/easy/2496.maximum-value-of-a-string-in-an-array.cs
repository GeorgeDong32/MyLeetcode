/*
 * @lc app=leetcode.cn id=2496 lang=csharp
 * @lcpr version=30121
 *
 * [2496] 数组中字符串的最大值
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MaximumValue(string[] strs)
    {
        var nums = new List<int>();
        foreach (var str in strs)
        {
            var temp = 0;
            if (int.TryParse(str, out temp))
                nums.Add(temp);
            else
                nums.Add(str.Length);
        }
        return nums.Max();
    }
}
// @lc code=end



/*
// @lcpr case=start
// ["alic3","bob","3","4","00000"]\n
// @lcpr case=end

// @lcpr case=start
// ["1","01","001","0001"]\n
// @lcpr case=end

 */


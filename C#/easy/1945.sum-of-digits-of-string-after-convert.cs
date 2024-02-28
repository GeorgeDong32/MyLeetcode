/*
 * @lc app=leetcode.cn id=1945 lang=csharp
 * @lcpr version=30117
 *
 * [1945] 字符串转化后的各位数字之和
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int GetLucky(string s, int k)
    {
        foreach (var c in s)
        {
            s = s.Replace($"{c}", (c - 'a' + 1).ToString());
        }
        var sum = 0;
        while (k > 0)
        {
            sum = 0;
            foreach (var c in s)
            {
                sum += c - '0';
            }
            s = sum.ToString();
            k--;
        }
        return sum;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "iiii"\n1\n
// @lcpr case=end

// @lcpr case=start
// "leetcode"\n2\n
// @lcpr case=end

 */


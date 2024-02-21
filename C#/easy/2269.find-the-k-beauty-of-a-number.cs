/*
 * @lc app=leetcode.cn id=2269 lang=csharp
 * @lcpr version=30117
 *
 * [2269] 找到一个数字的 K 美丽值
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int DivisorSubstrings(int num, int k)
    {
        string strNum = num.ToString();
        if (strNum.Length < k)
            return 0;
        int len = strNum.Length - k, temp, count = 0;
        String t;
        for (int i = 0; i <= len; i++)
        {
            temp = Convert.ToInt32(strNum.Substring(i, k));
            if (temp != 0 && num % temp == 0)
                ++count;
        }
        return count;
    }
}
// @lc code=end



/*
// @lcpr case=start
// 240\n2\n
// @lcpr case=end

// @lcpr case=start
// 430043\n2\n
// @lcpr case=end

 */


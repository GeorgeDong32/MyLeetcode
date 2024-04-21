/*
 * @lc app=leetcode.cn id=443 lang=csharp
 * @lcpr version=30122
 *
 * [443] 压缩字符串
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int Compress(char[] chars)
    {
        int length = chars.Length;
        int fast = 1, slow = 0;
        int count = 1, unit = 1;
        while (fast <= length)
        {
            if (fast < length && chars[fast] == chars[fast - 1])
            {
                count++;
                if (count == unit * 10)
                {
                    unit *= 10;
                }
            }
            else
            {
                char c = chars[fast - count];
                chars[slow] = c;
                slow++;
                if (count > 1)
                {
                    while (unit > 0)
                    {
                        int digit = count / unit;
                        count -= digit * unit;
                        unit /= 10;
                        chars[slow] = (char)('0' + digit);
                        slow++;
                    }
                }
                count = 1;
                unit = 1;
            }
            fast++;
        }
        return slow;
    }
}
// @lc code=end



/*
// @lcpr case=start
// ["a","a","b","b","c","c","c"]\n
// @lcpr case=end

// @lcpr case=start
// ["a"]\n
// @lcpr case=end

// @lcpr case=start
// ["a","b","b","b","b","b","b","b","b","b","b","b","b"]\n
// @lcpr case=end

 */


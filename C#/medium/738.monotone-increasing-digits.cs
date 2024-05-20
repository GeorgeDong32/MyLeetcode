/*
 * @lc app=leetcode.cn id=738 lang=csharp
 * @lcpr version=30202
 *
 * [738] 单调递增的数字
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MonotoneIncreasingDigits(int n)
    {
        char[] array = n.ToString().ToCharArray();
        int numLength = array.Length;
        int startIndex = -1;
        for (int i = numLength - 2; i >= 0; i--)
        {
            if (array[i] > array[i + 1])
            {
                array[i]--;
                startIndex = i;
            }
        }
        if (startIndex >= 0)
        {
            for (int i = startIndex + 1; i < numLength; i++)
            {
                array[i] = '9';
            }
        }
        return int.Parse(new string(array));
    }
}
// @lc code=end



/*
// @lcpr case=start
// 10\n
// @lcpr case=end

// @lcpr case=start
// 1234\n
// @lcpr case=end

// @lcpr case=start
// 332\n
// @lcpr case=end

 */


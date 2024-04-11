/*
 * @lc app=leetcode.cn id=1702 lang=csharp
 * @lcpr version=30122
 *
 * [1702] 修改后的最大二进制字符串
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public string MaximumBinaryString(string binary)
    {
        char[] array = binary.ToCharArray();
        int length = binary.Length;
        int firstZero = -1;
        for (int i = 0; i < length && firstZero < 0; i++)
        {
            if (array[i] == '0')
            {
                firstZero = i;
            }
        }
        if (firstZero < 0)
        {
            return binary;
        }
        for (int i = firstZero + 1; i < length; i++)
        {
            if (array[i] == '0')
            {
                array[i] = '1';
                array[firstZero] = '1';
                array[firstZero + 1] = '0';
                firstZero++;
            }
        }
        return new string(array);
    }
}
// @lc code=end



/*
// @lcpr case=start
// "000110"\n
// @lcpr case=end

// @lcpr case=start
// "01"\n
// @lcpr case=end

 */


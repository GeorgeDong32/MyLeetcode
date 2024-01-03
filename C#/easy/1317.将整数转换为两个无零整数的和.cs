/*
 * @lc app=leetcode.cn id=1317 lang=csharp
 *
 * [1317] 将整数转换为两个无零整数的和
 */

// @lc code=start
public class Solution
{
    public int[] GetNoZeroIntegers(int n)
    {
        Random random = new Random();
        int answer = 0;
        while (ContainZero(answer = random.Next(1, n - 1)) || ContainZero(n - answer)) ;

        return new int[] { answer, n - answer };
    }
    public bool ContainZero(int num)
    {
        char[] temp = num.ToString().ToCharArray();

        return temp.Contains('0');
    }
}
// @lc code=end


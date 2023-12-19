/*
 * @lc app=leetcode.cn id=1013 lang=csharp
 *
 * [1013] 将数组分成和相等的三个部分
 */

// @lc code=start
public class Solution
{
    public bool CanThreePartsEqualSum(int[] arr)
    {
        int sum1 = 0;
        int sum2 = 0;
        int sum3 = arr.Sum();
        if (sum3 % 3 != 0) return false;

        for (int i = 0; i < arr.Length - 2; i++)
        {
            sum1 += arr[i];
            sum3 -= arr[i];

            if (sum3 >> 1 != sum1)
            {
                continue;
            }
            else
            {
                while (++i < arr.Length - 1)
                {
                    sum2 += arr[i];
                    sum3 -= arr[i];

                    if (sum2 == sum3)
                        return true;
                }
            }
        }
        return false;
    }
}
// @lc code=end


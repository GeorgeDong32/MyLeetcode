/*
 * @lc app=leetcode.cn id=345 lang=csharp
 *
 * [345] 反转字符串中的元音字母
 */

// @lc code=start
public class Solution
{
    public string ReverseVowels(string s)
    {
        int n = s.Length;
        char[] arr = s.ToCharArray();
        int i = 0, j = n - 1;
        while (i < j)
        {
            while (i < n && !IsVowel(arr[i]))
            {
                ++i;
            }
            while (j > 0 && !IsVowel(arr[j]))
            {
                --j;
            }
            if (i < j)
            {
                Swap(arr, i, j);
                ++i;
                --j;
            }
        }
        return new string(arr);
    }

    public bool IsVowel(char ch)
    {
        return "aeiouAEIOU".IndexOf(ch) >= 0;
    }

    public void Swap(char[] arr, int i, int j)
    {
        char temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}
// @lc code=end


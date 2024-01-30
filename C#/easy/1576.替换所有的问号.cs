/*
 * @lc app=leetcode.cn id=1576 lang=csharp
 *
 * [1576] 替换所有的问号
 */

// @lc code=start
public class Solution
{
    public string ModifyString(string s)
    {
        char[] arr = s.ToCharArray();
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] == '?')
            {
                for (char c = 'a'; c <= 'z'; c++)
                {
                    if ((i > 0 && arr[i - 1] == c) || (i < n - 1 && arr[i + 1] == c))
                    {
                        continue;
                    }
                    arr[i] = c;
                    break;
                }
            }
        }
        return new string(arr);
    }
}
// @lc code=end


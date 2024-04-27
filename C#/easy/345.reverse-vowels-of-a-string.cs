/*
 * @lc app=leetcode.cn id=345 lang=csharp
 * @lcpr version=30122
 *
 * [345] 反转字符串中的元音字母
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public string ReverseVowels(string s)
    {
        var arr = s.ToCharArray();
        var i = 0; var j = arr.Length - 1;
        var l = arr.Length;
        while (i < j)
        {
            while (i < l && !IsVowel(arr[i]))
                i++;
            while (j >= 0 && !IsVowel(arr[j]))
                j--;
            if (i < j)
            {
                (arr[j], arr[i]) = (arr[i], arr[j]);
                i++; j--;
            }
        }
        return new string(arr);
    }

    public static bool IsVowel(char ch)
    {
        return "aeiouAEIOU".Contains(ch);
    }
}
// @lc code=end



/*
// @lcpr case=start
// "hello"\n
// @lcpr case=end

// @lcpr case=start
// "leetcode"\n
// @lcpr case=end

 */


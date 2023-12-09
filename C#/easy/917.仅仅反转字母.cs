/*
 * @lc app=leetcode.cn id=917 lang=csharp
 *
 * [917] 仅仅反转字母
 */

// @lc code=start
public class Solution
{
    public string ReverseOnlyLetters(string s)
    {
        var array = s.ToCharArray();
        var left = 0; var right = s.Length - 1;
        while (left < right)
        {
            while (left < right && !char.IsLetter(array[left]))
            {
                left++;
            }
            while (left < right && !char.IsLetter(array[right]))
            {
                right--;
            }
            if (left < right)
            {
                char temp = array[left];
                array[left] = array[right];
                array[right] = temp;
                left++;
                right--;
            }
        }
        return new string(array);
    }
}
// @lc code=end


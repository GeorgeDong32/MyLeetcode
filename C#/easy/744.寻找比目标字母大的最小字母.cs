/*
 * @lc app=leetcode.cn id=744 lang=csharp
 *
 * [744] 寻找比目标字母大的最小字母
 */

// @lc code=start
public class Solution
{
    public char NextGreatestLetter(char[] letters, char target)
    {
        if (target == 'z')
            return letters[0];
        for (var i = 0; i < letters.Length; i++)
        {
            if (letters[i] - target > 0)
                return letters[i];
        }
        return letters[0];
    }
}
// @lc code=end


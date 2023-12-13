/*
 * @lc app=leetcode.cn id=925 lang=csharp
 *
 * [925] 长按键入
 */

// @lc code=start
public class Solution
{
    public bool IsLongPressedName(string name, string typed)
    {
        int i = 0, j = 0;
        while (j < typed.Length)
        {
            if (i < name.Length && typed[j] == name[i])
            {
                i++; j++;
            }
            else if (j > 0 && typed[j] == typed[j - 1])
            {
                j++;
            }
            else
                return false;
        }
        return i == name.Length;
    }
}
// @lc code=end


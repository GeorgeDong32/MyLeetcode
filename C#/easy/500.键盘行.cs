/*
 * @lc app=leetcode.cn id=500 lang=csharp
 *
 * [500] 键盘行
 */

// @lc code=start
public class Solution
{
    public string[] FindWords(string[] words)
    {
        var kb = new string[] { "qwertyuiop", "asdfghjkl", "zxcvbnm" };
        var res = new List<string>(); bool flag = true;
        foreach (var s in words)
        {
            flag = true;
            var temp = s.ToLower();
            var line = kb[0].IndexOf(temp[0]) != -1 ? 0 : kb[1].IndexOf(temp[0]) != -1 ? 1 : 2;
            for (var i = 1; i < temp.Length; i++)
            {
                if (kb[line].IndexOf(temp[i]) == -1)
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
                res.Add(s);
        }
        return res.ToArray();
    }
}
// @lc code=end


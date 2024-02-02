/*
 * @lc app=leetcode.cn id=1598 lang=csharp
 *
 * [1598] 文件夹操作日志搜集器
 */

// @lc code=start
public class Solution
{
    public int MinOperations(string[] logs)
    {
        int depth = 0;
        foreach (var log in logs)
        {
            if (log == "../")
            {
                if (depth > 0) depth--;
            }
            else if (log != "./")
            {
                depth++;
            }
        }
        return depth;
    }
}
// @lc code=end


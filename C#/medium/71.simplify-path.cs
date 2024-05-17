/*
 * @lc app=leetcode.cn id=71 lang=csharp
 * @lcpr version=30202
 *
 * [71] 简化路径
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
using System.Text;

public class Solution
{
    public string SimplifyPath(string path)
    {
        var stack = new Stack<string>();
        var array = path.Split(new char[] { '/' });
        int length = array.Length;
        for (int i = 0; i < length; i++)
        {
            string dir = array[i];
            if (".".Equals(dir))
            {
                continue;
            }
            else if ("..".Equals(dir))
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }
            else if (dir.Length > 0)
            {
                stack.Push(dir);
            }
        }
        var pathStack = new Stack<string>();
        while (stack.Count > 0)
        {
            pathStack.Push(stack.Pop());
        }
        var sb = new StringBuilder();
        while (pathStack.Count > 0)
        {
            string dir = pathStack.Pop();
            sb.Append('/');
            sb.Append(dir);
        }
        if (sb.Length == 0)
        {
            sb.Append('/');
        }
        return sb.ToString();
    }
}
// @lc code=end



/*
// @lcpr case=start
// "/home/"\n
// @lcpr case=end

// @lcpr case=start
// "/../"\n
// @lcpr case=end

// @lcpr case=start
// "/home//foo/"\n
// @lcpr case=end

// @lcpr case=start
// "/a/./b/../../c/"\n
// @lcpr case=end

 */


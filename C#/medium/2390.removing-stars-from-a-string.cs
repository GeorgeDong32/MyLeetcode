/*
 * @lc app=leetcode.cn id=2390 lang=csharp
 * @lcpr version=30122
 *
 * [2390] 从字符串中移除星号
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public string RemoveStars(string s)
    {
        var st = new Stack<char>();
        foreach (var c in s)
        {
            if (c != '*')
                st.Push(c);
            else
                if (st.Count > 0)
                st.Pop();
        }
        var temp = st.ToArray();
        Array.Reverse(temp);
        return new string(temp);
    }
}
// @lc code=end



/*
// @lcpr case=start
// "leet**cod*e"\n
// @lcpr case=end

// @lcpr case=start
// "erase*****"\n
// @lcpr case=end

 */


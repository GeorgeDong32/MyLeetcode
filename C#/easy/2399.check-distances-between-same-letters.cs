/*
 * @lc app=leetcode.cn id=2399 lang=csharp
 * @lcpr version=30121
 *
 * [2399] 检查相同字母间的距离
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool CheckDistances(string s, int[] distance)
    {
        IDictionary<char, int> indices = new Dictionary<char, int>();
        int length = s.Length;
        for (int i = 0; i < length; i++)
        {
            char c = s[i];
            if (!indices.ContainsKey(c))
            {
                indices.Add(c, i);
            }
            else if (i - indices[c] - 1 != distance[c - 'a'])
            {
                return false;
            }
        }
        return true;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "abaccb"\n[1,3,0,5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0]\n
// @lcpr case=end

// @lcpr case=start
// "aa"\n[1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0]\n
// @lcpr case=end

 */


/*
 * @lc app=leetcode.cn id=17 lang=csharp
 * @lcpr version=30202
 *
 * [17] 电话号码的字母组合
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
using System.Text;

public class Solution
{
    private readonly string[] _dict = ["", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"];
    private List<string> ans = new();
    string keys;
    public IList<string> LetterCombinations(string digits)
    {
        keys = digits;
        ans.Clear();
        if (keys.Length == 0)
            return [];
        BackTrace(0, new StringBuilder());
        return ans;
    }

    public void BackTrace(int index, StringBuilder combine)
    {
        if (index == keys.Length)
        {
            ans.Add(combine.ToString());
            return;
        }
        else
        {
            var digit = keys[index] - '0';
            var letters = _dict[digit];
            foreach (var c in letters)
            {
                combine.Append(c);
                BackTrace(index + 1, combine);
                combine.Length--;
            }
        }
    }
}
// @lc code=end



/*
// @lcpr case=start
// "23"\n
// @lcpr case=end

// @lcpr case=start
// ""\n
// @lcpr case=end

// @lcpr case=start
// "2"\n
// @lcpr case=end

 */


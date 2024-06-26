/*
 * @lc app=leetcode.cn id=131 lang=csharp
 * @lcpr version=30202
 *
 * [131] 分割回文串
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    IList<IList<string>> allPartitions = new List<IList<string>>();
    IList<string> temp = new List<string>();
    string s;
    int n;
    bool[][] isPalindrome;

    public IList<IList<string>> Partition(string s)
    {
        this.s = s;
        this.n = s.Length;
        this.isPalindrome = new bool[n][];
        for (int i = 0; i < n; i++)
        {
            isPalindrome[i] = new bool[n];
        }
        PreCalculate();
        Backtrack(0);
        return allPartitions;
    }

    public void PreCalculate()
    {
        for (int i = 0; i < n; i++)
        {
            isPalindrome[i][i] = true;
        }
        for (int i = 0; i < n - 1; i++)
        {
            isPalindrome[i][i + 1] = s[i] == s[i + 1];
        }
        for (int subLength = 3; subLength <= n; subLength++)
        {
            for (int i = 0, j = subLength - 1; j < n; i++, j++)
            {
                isPalindrome[i][j] = s[i] == s[j] && isPalindrome[i + 1][j - 1];
            }
        }
    }

    public void Backtrack(int index)
    {
        if (index == n)
        {
            allPartitions.Add(new List<string>(temp));
        }
        else
        {
            for (int i = index; i < n; i++)
            {
                if (isPalindrome[index][i])
                {
                    temp.Add(s.Substring(index, i - index + 1));
                    Backtrack(i + 1);
                    temp.RemoveAt(temp.Count - 1);
                }
            }
        }
    }
}
// @lc code=end



/*
// @lcpr case=start
// "aab"\n
// @lcpr case=end

// @lcpr case=start
// "a"\n
// @lcpr case=end

 */


/*
 * @lc app=leetcode.cn id=93 lang=csharp
 * @lcpr version=30202
 *
 * [93] 复原 IP 地址
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
using System.Text;

public class Solution
{
    const int SEGMENTS = 4;
    IList<string> ipAddresses = new List<string>();
    int[] ipArr = new int[SEGMENTS];
    int n;
    string s;

    public IList<string> RestoreIpAddresses(string s)
    {
        this.n = s.Length;
        this.s = s;
        if (n < SEGMENTS || n > 3 * SEGMENTS)
        {
            return ipAddresses;
        }
        Backtrack(0, 0);
        return ipAddresses;
    }

    public void Backtrack(int start, int segmentCount)
    {
        if (segmentCount == SEGMENTS)
        {
            if (start == n)
            {
                ipAddresses.Add(Convert(ipArr));
            }
        }
        else
        {
            bool flag = true;
            for (int end = start; end < n && flag; end++)
            {
                if (Valid(start, end))
                {
                    ipArr[segmentCount] = int.Parse(s.Substring(start, end - start + 1));
                    Backtrack(end + 1, segmentCount + 1);
                }
                else
                {
                    flag = false;
                }
            }
        }
    }

    public bool Valid(int start, int end)
    {
        int length = end - start + 1;
        if (length < 1 || length > 3)
        {
            return false;
        }
        if (length > 1 && s[start] == '0')
        {
            return false;
        }
        return int.Parse(s.Substring(start, end - start + 1)) <= 255;
    }

    public string Convert(int[] ipArr)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(ipArr[0]);
        for (int i = 1; i < SEGMENTS; i++)
        {
            sb.Append('.');
            sb.Append(ipArr[i]);
        }
        return sb.ToString();
    }
}
// @lc code=end



/*
// @lcpr case=start
// "25525511135"\n
// @lcpr case=end

// @lcpr case=start
// "0000"\n
// @lcpr case=end

// @lcpr case=start
// "101023"\n
// @lcpr case=end

 */


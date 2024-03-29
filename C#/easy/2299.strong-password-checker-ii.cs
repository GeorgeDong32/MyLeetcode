/*
 * @lc app=leetcode.cn id=2299 lang=csharp
 * @lcpr version=30120
 *
 * [2299] 强密码检验器 II
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
using System.Runtime.InteropServices;

public class Solution
{
    public bool StrongPasswordCheckerII(string password)
    {
        if (password.Length < 8)
            return false;
        int upcase = 0, lowcase = 0, numc = 0, spec = 0;
        char last = ' ';
        foreach (var c in password)
        {
            if (char.IsUpper(c))
                upcase++;
            else if (char.IsLower(c))
                lowcase++;
            else if (char.IsDigit(c))
                numc++;
            else
                spec++;
            if (c == last)
                return false;
            last = c;
        }
        return upcase >= 1 && lowcase >= 1 && spec >= 1 && numc >= 1;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "IloveLe3tcode!"\n
// @lcpr case=end

// @lcpr case=start
// "Me+You--IsMyDream"\n
// @lcpr case=end

// @lcpr case=start
// "1aB!"\n
// @lcpr case=end

 */


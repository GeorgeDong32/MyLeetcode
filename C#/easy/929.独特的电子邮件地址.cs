/*
 * @lc app=leetcode.cn id=929 lang=csharp
 *
 * [929] 独特的电子邮件地址
 */

// @lc code=start
public class Solution
{
    public int NumUniqueEmails(string[] emails)
    {
        var map = new HashSet<string>();
        foreach (var email in emails)
        {
            var sp = email.Split('@');
            var local = sp[0];
            var domain = sp[1];
            var fp = local.IndexOf('+');
            if (fp != -1)
            {
                local = local.Substring(0, fp);
            }
            local = local.Replace(".", "");
            var newem = local + "@" + domain;
            map.Add(newem);
        }
        return map.Count;
    }
}
// @lc code=end


/*Q125*/
using System.Text.RegularExpressions;
var solution = new Solution();
Console.WriteLine(solution.IsPalindrome("Marge, let's \"[went].\" I await {news} telegram."));

public class Solution
{
    public bool IsPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return true;
        }
        s = s.Trim();
        s = Regex.Replace(s, "[ \\[ \\] \\^ \\ \\{ \\} \\-_*×――(^)$%~!@#$…&%￥—+=<>《》!！??？:：•`·、。，；,.;\"‘’“”\'-]", "").ToLower();
        var left = 0; var right = s.Length - 1;
        while (left < right)
        {
            if (s[left] != s[right])
                return false;
            left++; right--;
        }
        return true;
    }
}
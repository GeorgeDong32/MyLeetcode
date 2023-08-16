/*Q171*/
var sol = new Solution();

public class Solution
{
    public int TitleToNumber(string columnTitle)
    {
        var l = columnTitle.Length;
        var res = 0;
        for (var i = 0; i < l; i++)
        {
            int num = (int)(columnTitle[i] - 'A') + 1;
            res += num * (int)Math.Pow(26, l - i - 1);
        }
        return res;
    }
}
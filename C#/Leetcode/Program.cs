/*Q205*/
var sol = new Solution();

public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        var arrs = new List<int>();
        var arrt = new List<int>();
        for (int i = 0; i < s.Length; i++)
        {
            arrs.Add(s.IndexOf(s[i]));
            arrt.Add(t.IndexOf(t[i]));
        }
        return arrs.SequenceEqual(arrt);
    }
}
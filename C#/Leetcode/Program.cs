﻿/*Q242*/
var sol = new Solution();

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;
        var count = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            count[s[i] - 'a']++;
            count[t[i] - 'a']--;
        }
        for (int i = 0; i < count.Length; i++)
        {
            if (count[i] != 0)
                return false;
        }
        return true;
    }
}
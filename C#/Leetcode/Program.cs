﻿/*Q168*/
using System.Text;

var sol = new Solution();
Console.WriteLine(sol.ConvertToTitle(26));

public class Solution
{
    public string ConvertToTitle(int columnNumber)
    {
        StringBuilder sb = new StringBuilder();
        while (columnNumber > 0)
        {
            int a0 = (columnNumber - 1) % 26 + 1;
            sb.Append((char)(a0 - 1 + 'A'));
            columnNumber = (columnNumber - a0) / 26;
        }
        StringBuilder columnTitle = new StringBuilder();
        for (int i = sb.Length - 1; i >= 0; i--)
        {
            columnTitle.Append(sb[i]);
        }
        return columnTitle.ToString();
    }
}
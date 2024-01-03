/*
 * @lc app=leetcode.cn id=466 lang=csharp
 *
 * [466] 统计重复个数
 */

// @lc code=start
public class Solution
{
    public int GetMaxRepetitions(string s1, int n1, string s2, int n2)
    {
        int f1 = 0, f2 = 0; // 使用两个flag，通过取模的方式分别循环遍历s1和匹配s2
        int len = s1.Length * n1; // n1个s1的长度总和
        int l1 = s1.Length, l2 = s2.Length;
        while (f1 < len) // 遍历n1个s1
        {
            if (s1[f1 % l1] == s2[f2 % l2]) // s2[f2 % l2]为当前需要匹配的值，s1[f1 % l1]当前遍历的值
            {
                f2++; // 匹配成功则将f2指向s2下一个字母下标
            }
            f1++;
            if (f1 % l1 == 0 && f2 % l2 == 0) // 如果完整遍历了m个s1的同时，完整匹配了n个s2，那 n1*s1 中 每f1个的字母就是一个循环
            {
                int step = len / f1; // 计算可完整循环次数
                f1 *= step; // 将遍历进度直接跳到完成最后一个完整循环时
                f2 *= step; // 将匹配进度也调整到对应的值
            }
        }
        // 遍历完成时f2就是一共匹配了s2中字母的次数
        return f2 / (l2 * n2); // f2 / l2 就是匹配了多少个s2
    }
}
// @lc code=end


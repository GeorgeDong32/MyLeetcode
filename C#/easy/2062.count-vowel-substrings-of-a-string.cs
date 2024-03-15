/*
 * @lc app=leetcode.cn id=2062 lang=csharp
 * @lcpr version=30119
 *
 * [2062] 统计字符串中的元音子字符串
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int CountVowelSubstrings(string word)
    {
        int[] ls = new int[5];//aeiou
        int res = 0;
        for (int i = 4; i < word.Length; i++)
        {
            ls = new int[5];
            for (int j = i; j >= 0; j--)
            {
                if (word[j] == 'a') ls[0] = 1;
                else if (word[j] == 'e') ls[1] = 1;
                else if (word[j] == 'i') ls[2] = 1;
                else if (word[j] == 'o') ls[3] = 1;
                else if (word[j] == 'u') ls[4] = 1;
                else break;
                if (ls[0] == 1 && ls[1] == 1 && ls[2] == 1 && ls[3] == 1 && ls[4] == 1)
                    res++;
            }
        }
        return res;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "aeiouu"\n
// @lcpr case=end

// @lcpr case=start
// "unicornarihan"\n
// @lcpr case=end

// @lcpr case=start
// "cuaieuouac"\n
// @lcpr case=end

// @lcpr case=start
// "bbaeixoubb"\n
// @lcpr case=end

 */


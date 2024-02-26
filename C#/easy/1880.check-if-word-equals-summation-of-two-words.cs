/*
 * @lc app=leetcode.cn id=1880 lang=csharp
 * @lcpr version=30117
 *
 * [1880] 检查某单词是否等于两单词之和
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool IsSumEqual(string firstWord, string secondWord, string targetWord)
    {
        int firstNum = GetNum(firstWord), secondNum = GetNum(secondWord), targetNum = GetNum(targetWord);
        return firstNum + secondNum == targetNum;
    }

    public int GetNum(String word)
    {
        int num = 0;
        int length = word.Length;
        for (int i = 0; i < length; i++)
        {
            int digit = word[i] - 'a';
            num = num * 10 + digit;
        }
        return num;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "acb"\n"cba"\n"cdb"\n
// @lcpr case=end

// @lcpr case=start
// "aaa"\n"a"\n"aab"\n
// @lcpr case=end

// @lcpr case=start
// "aaa"\n"a"\n"aaaa"\n
// @lcpr case=end

 */


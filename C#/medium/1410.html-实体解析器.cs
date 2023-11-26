/*
 * @lc app=leetcode.cn id=1410 lang=csharp
 *
 * [1410] HTML 实体解析器
 */

// @lc code=start
using System.Text;

public class Solution
{
    public string EntityParser(string text)
    {
        StringBuilder sb = new StringBuilder();
        int length = text.Length;
        int entityStart = -1;
        for (int i = 0; i < length; i++)
        {
            char c = text[i];
            if (c == '&')
            {
                if (entityStart >= 0)
                {
                    sb.Append(text.Substring(entityStart, i - entityStart));
                }
                entityStart = i;
            }
            else
            {
                if (entityStart >= 0)
                {
                    if (c == ';')
                    {
                        string entity = text.Substring(entityStart, i + 1 - entityStart);
                        string specialCharacter = GetCharacter(entity);
                        sb.Append(specialCharacter);
                        entityStart = -1;
                    }
                }
                else
                {
                    sb.Append(c);
                }
            }
        }
        if (entityStart >= 0)
        {
            sb.Append(text.Substring(entityStart));
        }
        return sb.ToString();
    }

    public string GetCharacter(string entity)
    {
        switch (entity)
        {
            case "&quot;":
                return "\"";
            case "&apos;":
                return "\'";
            case "&amp;":
                return "&";
            case "&gt;":
                return ">";
            case "&lt;":
                return "<";
            case "&frasl;":
                return "/";
            default:
                return entity;
        }
    }
}
// @lc code=end


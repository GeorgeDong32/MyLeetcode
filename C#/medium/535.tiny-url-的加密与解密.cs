/*
 * @lc app=leetcode.cn id=535 lang=csharp
 *
 * [535] TinyURL 的加密与解密
 */

// @lc code=start
public class Codec
{

    // Encodes a URL to a shortened URL
    public string encode(string longUrl)
    {
        return "Link" + longUrl;
    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl)
    {
        return shortUrl.Substring(4, shortUrl.Length - 4);
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(url));
// @lc code=end


/*
 * @lc app=leetcode.cn id=1175 lang=csharp
 *
 * [1175] 质数排列
 */

// @lc code=start
public class Solution
{
    public int mod = 1000000007;
    public bool isPrime(int x)
    {
        if (x < 2) return false;
        for (int i = 2; i * i <= x; i++)
        {
            if (x % i == 0) return false;
        }
        return true;
    }
    public long jiecheng(int x)
    {
        long res = 1;
        for (int i = x; i > 1; i--) res = (res * i) % mod;
        return res;
    }
    public int NumPrimeArrangements(int n)
    {
        bool[] vis = new bool[n + 1];//用来记录是否是质数
        for (int i = 2; i <= n; i++)//筛选质数
        {
            if (vis[i]) continue;
            if (isPrime(i))//如果是质数，把其2以上的倍数都记录为非质数，等会直接跳过是否为质数的判断
                for (int j = 2; j * i < n; j++)
                {
                    vis[j * i] = true;
                }
            else vis[i] = true;//非质数，只需把其本身记录为非质数，不用考虑其倍数
        }
        int res = 0;
        for (int i = 2; i <= n; i++) if (!vis[i]) res++;//记录质数的个数
        long result = 1;//设为long 防止其溢出
        result *= (jiecheng(res) * jiecheng(n - res)) % mod;//分别计算排列种数，再相乘
        return (int)result;


    }
}
// @lc code=end


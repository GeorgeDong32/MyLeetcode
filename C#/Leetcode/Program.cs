/*Q202*/
var sol = new Solution();

public class Solution
{
    public bool IsHappy(int n)
    {
        HashSet<int> cycleMembers =
            new HashSet<int>(new int[8] { 4, 16, 37, 58, 89, 145, 42, 20 });

        while (n != 1 && !cycleMembers.Contains(n))
        {
            n = GetNext(n);
        }
        return n == 1;
    }

    public int GetNext(int n)
    {
        var result = 0;
        while (n > 0)
        {
            int d = n % 10;
            n /= 10;
            result += d * d;
        }
        return result;
    }
}
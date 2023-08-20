/*Q231*/
var sol = new Solution();
Console.WriteLine(sol.IsPowerOfTwo(8));

public class Solution
{
    public bool IsPowerOfTwo(int n)
    {
        return n > 0 && (n & (n - 1)) == 0;
    }
}
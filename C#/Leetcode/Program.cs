/*Q268*/
var sol = new Solution();

public class Solution
{
    public int MissingNumber(int[] nums)
    {
        int n = nums.Length;
        var tarsum = n * (n + 1) / 2;
        return tarsum - nums.Sum();
    }
}
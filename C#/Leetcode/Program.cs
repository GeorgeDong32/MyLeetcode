/*Q268*/
var sol = new Solution();

public class Solution
{
    public int MissingNumber(int[] nums)
    {
        var tarsum = 0;
        for (int i = 0; i <= nums.Length; i++)
        {
            tarsum += i;
        }
        return tarsum - nums.Sum();
    }
}
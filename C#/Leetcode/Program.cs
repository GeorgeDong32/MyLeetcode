/*Q219*/
var sol = new Solution();

public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        Dictionary<int, int> d = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (d.ContainsKey(nums[i]) && i - d[nums[i]] <= k)
            {
                return true;
            }
            if (d.ContainsKey(nums[i]))
            {
                d[nums[i]] = i;
            }
            else
            {
                d.Add(nums[i], i);
            }
        }
        return false;
    }
}
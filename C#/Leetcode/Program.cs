/*Q218*/
var sol = new Solution();

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> res = new HashSet<int>(nums);
        return res.Count != nums.Length;
    }
}
/*Q190*/
var sol = new Solution();

public class Solution
{
    public uint reverseBits(uint n)
    {
        uint rev = 0;
        for (int i = 0, j = 31; i < 32; i++, j--)
        {
            uint bit = (n >> i) & 1;
            rev |= bit << j;
        }
        return rev;
    }
}
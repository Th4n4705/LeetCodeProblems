public class Solution {
    public int SmallestRangeI(int[] nums, int k) {
        int min = Int32.MaxValue;
        int max = Int32.MinValue;
        foreach (int n in nums)
        {
            if (n < min)
                min = n;
            if (n > max)
                max = n;
        }
        return max - min - (k * 2) > 0 ? max - min - (k * 2) : 0;
    }
}
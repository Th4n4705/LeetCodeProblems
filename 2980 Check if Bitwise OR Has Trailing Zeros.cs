public class Solution {
    public bool HasTrailingZeros(int[] nums) {
        int counter = 0;
        foreach (int n in nums)
            if (n % 2 == 0)
                counter++;
        return counter > 1;
    }
}
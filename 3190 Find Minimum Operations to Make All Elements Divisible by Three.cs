public class Solution {
    public int MinimumOperations(int[] nums) {
        int counter = 0;
        foreach (int n in nums)
            if (n % 3 != 0)
                counter++;
        return counter;
    }
}
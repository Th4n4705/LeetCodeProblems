public class Solution {
    public int MinOperations(int[] nums, int k) {
        int counter = 0;
        foreach (int n in nums)
            if (n < k)
                counter++;
        return counter;
    }
}
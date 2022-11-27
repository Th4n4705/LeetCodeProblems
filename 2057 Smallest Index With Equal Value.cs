public class Solution {
    public int SmallestEqual(int[] nums) {
        int smallest = Int32.MaxValue;
        for (int i = 0; i < nums.Length; i++)
            if (i % 10 == nums[i] && i < smallest)
                smallest = i;
        return smallest != Int32.MaxValue ? smallest : -1;
    }
}
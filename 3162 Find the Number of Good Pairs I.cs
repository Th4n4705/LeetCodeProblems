public class Solution {
    public int NumberOfPairs(int[] nums1, int[] nums2, int k) {
        int counter = 0;
        foreach (int i in nums1)
            foreach (int j in nums2)
                if (i % (j * k) == 0)
                    counter++;
        return counter;
    }
}
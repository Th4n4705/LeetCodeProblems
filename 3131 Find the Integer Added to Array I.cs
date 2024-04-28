public class Solution {
    public int AddedInteger(int[] nums1, int[] nums2) {
        int sum2 = nums2.Sum();
        int sum1 = nums1.Sum();
        return (sum2 - sum1) / nums1.Length;
    }
}
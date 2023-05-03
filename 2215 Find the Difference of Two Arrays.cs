public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        var diff1 = nums1.Except(nums2).ToArray();
        var diff2 = nums2.Except(nums1).ToArray();
        return new [] {diff1, diff2};
    }
}
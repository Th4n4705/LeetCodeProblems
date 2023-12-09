public class Solution {
    public int[] FindIntersectionValues(int[] nums1, int[] nums2) {
        return new int[] {IntersectionCounter(nums1, nums2), IntersectionCounter(nums2, nums1)};
    }

    private int IntersectionCounter (int[] nums1, int[] nums2)
    {
        int counter = 0;
        for(int i = 0; i < nums1.Length; i++)
            for(int j = 0; j < nums2.Length; j++)
                if(nums1[i]==nums2[j])
                {
                    counter++;
                    break;
                }
        return counter;
    }
}
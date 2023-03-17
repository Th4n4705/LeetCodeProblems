public class Solution {
    public int GetCommon(int[] nums1, int[] nums2) {
        if (nums1[0] > nums2[nums2.Length - 1] || nums1[nums1.Length - 1] < nums2[0])
            return -1;
        int i = 0;
        int Leng = (nums1.Length > nums2.Length ? nums2.Length : nums1.Length); 
        while (i < Leng)
        {
            if (i >= 1 )
            {
                if (nums1[i - 1] != nums1[i] && nums2.Contains(nums1[i]))
                    return nums1[i];
                else if (nums2[i - 1] != nums2[i] && nums1.Contains(nums2[i]))
                    return nums2[i];
            }
            else if (i == 0)
            {
                if (nums2.Contains(nums1[i]))
                    return nums1[i];
                else if (nums1.Contains(nums2[i]))
                    return nums2[i];
            }
            i++;
        }
        return -1;
    }
}
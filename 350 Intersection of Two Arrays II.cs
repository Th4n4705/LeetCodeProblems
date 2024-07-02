public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        List<int> ls = new();
        for (int i = 0; i < nums1.Length; i++)
            for (int j = 0; j < nums2.Length; j++)
                if (nums1[i] == nums2[j])
                {
                    ls.Add(nums1[i]);
                    nums1[i] = int.MinValue;
                    nums2[j] = int.MaxValue;
                    break;
                }
        return ls.ToArray();
    }
}
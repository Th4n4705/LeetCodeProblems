public class Solution {
    public int MinNumber(int[] nums1, int[] nums2) {
        Array.Sort(nums1);
        Array.Sort(nums2);
        int min1 = MinFound(nums1, nums2);
        int min2 = MinFound(nums2, nums1);
        return min1 == min2 ? min1 : (Math.Min(min1, min2) * 10) + Math.Max(min1, min2);
    }

    public int MinFound(int[] n, int[] seek)
    {
        for (int i = 0; i < n.Length; i++)
            if (seek.Contains(n[i]))
                return n[i];
        return n[0];
    }
}
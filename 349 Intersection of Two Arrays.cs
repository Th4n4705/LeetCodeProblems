public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> nums1HS = new(nums1);
        List<int> ans = new();
        foreach (int n in nums2)
            if (nums1HS.Contains(n) && !ans.Contains(n))
                ans.Add(n);
        return ans.ToArray();
    }
}
public class Solution {
    public int MaxUncrossedLines(int[] nums1, int[] nums2) {
        int x = nums1.Length;
        int y = nums2.Length;
        int [,] ar = new int[x + 1, y + 1];
        for (int i = 1; i <= x; i++)
            for (int j = 1; j <= y; j++)
                if (nums1[i - 1] == nums2[j - 1])
                    ar[i, j] = ar[i - 1, j - 1] + 1;
                else
                    ar[i, j] = Math.Max(ar[i - 1, j], ar[i, j - 1]);
        return ar[x, y];
    }
}
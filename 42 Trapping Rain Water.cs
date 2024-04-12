public class Solution {
    public int Trap(int[] height) {
        int ans = 0;
        int[] l = new int[height.Length];
        int[] r = new int[height.Length];
        l[0] = 0;
        r[height.Length - 1] = 0;
        for (int i = 1; i < height.Length; i++)
        {
            l[i] = Math.Max(height[i - 1], l[i - 1]);
            r[height.Length - i - 1] = Math.Max(height[height.Length - i], r[height.Length - i]);
        }

        for (int i = 0; i < height.Length; i++)
            ans += Math.Max(0, Math.Min(l[i], r[i]) - height[i]);
        return ans;
    }
}
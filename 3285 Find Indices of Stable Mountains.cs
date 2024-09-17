public class Solution {
    public IList<int> StableMountains(int[] height, int threshold) {
        List<int> ans = new();
        for (int i = 1; i < height.Length; i++)
            if (height[i - 1] > threshold)
                ans.Add(i);
        return ans;
    }
}
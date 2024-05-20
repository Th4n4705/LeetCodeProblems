public class Solution {
    public int MaxWidthOfVerticalArea(int[][] points) {
        int max = 0;
        HashSet<int> coordinates = new();
        foreach (int[] p in points)
            coordinates.Add(p[0]);
        int[] sortedC = coordinates.ToArray();
        Array.Sort(sortedC);
        for (int i = 1; i < sortedC.Length; i++)
            max = Math.Max(max, sortedC[i] - sortedC[i - 1]);
        return max;
    }
}
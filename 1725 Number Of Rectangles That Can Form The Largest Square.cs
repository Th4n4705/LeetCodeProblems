public class Solution {
    public int CountGoodRectangles(int[][] rectangles) {
        int max = 0;
        foreach (int[] rect in rectangles)
            max = Math.Max(max, Math.Min(rect[0], rect[1]));
        return rectangles.Count(rect => Math.Min(rect[0], rect[1]) == max);
    }
}
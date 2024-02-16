public class Solution {
    public int MaxDistance(int[] colors) {
        int max = 1;
        for (int i = 0; i < colors.Length; i++)
        {
            if (colors.Length - i <= max)
                break;
            for (int j = colors.Length - 1; j > i; j--)
                if (colors[j] != colors[i])
                {
                    max = Math.Max(max, j - i);
                    break;
                }
        }
        return max;
    }
}
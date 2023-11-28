public class Solution {
    public int CaptureForts(int[] forts) {
        int max = 0;
        int j = -1;
        for (int i = 0; i < forts.Length; i++)
            if (forts[i] == -1 || forts[i] == 1)
            {
                if ( j >= 0 && forts[i] != forts[j])
                    max = Math.Max (i - j - 1, max);
                j = i;
            }
        return max;
    }
}
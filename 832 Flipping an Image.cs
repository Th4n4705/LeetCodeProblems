public class Solution {
    public int[][] FlipAndInvertImage(int[][] image) {
        int[][] ans = new int[image.Length][];
        for (int i = 0; i < image.Length; i++)
        {
            ans[i] = new int[image[i].Length];
            for (int j = 0; j < image[i].Length; j++)
                if (image[i][image[i].Length - j - 1] == 1)
                    ans[i][j] = 0;
                else
                    ans[i][j] = 1;
        }
        return ans;
    }
}
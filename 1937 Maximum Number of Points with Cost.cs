public class Solution {
    public long MaxPoints(int[][] points) {
        long[] arr = new long[points[0].Length];
        for (int i = 0; i < points[0].Length; i++)
            arr[i] = points[0][i];
        for (int i = 1; i < points.Length; i++)
        {
            long[] newArr = new long[points[0].Length];
            long lMax = arr[0];
            for (int j = 0; j < points[0].Length; j++)
            {
                lMax = Math.Max(lMax, arr[j] + j);
                newArr[j] = lMax + points[i][j] - j;
            }
            long rMax = arr[points[0].Length - 1] - (points[0].Length - 1);
            for (int j = points[0].Length - 1; j >= 0; j--)
            {
                rMax = Math.Max(rMax, arr[j] - j);
                newArr[j] = Math.Max(newArr[j], rMax + points[i][j] + j);
            }
            arr = newArr;
        }
        long maxi = 0;
        for (int i = 0; i < points[0].Length; i++)
            maxi = Math.Max(maxi, arr[i]);
        return maxi; 
    }
}
public class Solution {
    public int[][] ImageSmoother(int[][] img) {
        if (img.Length == 0)
            return img;
        int[][] newImg = new int[img.Length][];
        for (int i = 0; i < img.Length; i++)
        {
            newImg[i] = new int[img[i].Length];
            for (int j = 0; j < img[i].Length; j++)
                newImg[i][j] = AvgCalculation(ref img, i, j);
        }
        return newImg;
    }

    private int AvgCalculation(ref int[][] img, int row, int col)
    {
        int sum = 0;
        int counter = 0;
        for (int i = - 1; i < 2; i++)
            for (int j = -1; j < 2; j++)
            {
                if (row + i < 0 || row + i >= img.Length 
                || col + j < 0 || col + j >= img[row].Length)
                    continue;
                sum += img[row + i][col + j];
                counter++;
            }
        return sum / counter;
    }
}
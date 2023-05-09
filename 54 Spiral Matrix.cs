public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        int height = matrix.Length;
        int width = matrix[0].Length;
        List<int> ans = new List<int>(width * height);
        int x = 0;
        int y = 0;
        int iX = 1;
        int iY = 1;
        while (ans.Count < height * width)
        {
            ans.Add(matrix[y][x]);
            if (y == iY - 1 && x < width - iX)
                x++;
            else if (x == width - iX && y < height - iY)
                y++;
            else if (x > iX - 1)
                x--;
            else if (y > iY)
            {
                y--;
                if (y == iY && x == iX - 1)
                {
                    iX++;
                    iY++;
                }
            }
        }
        return ans;
    }
}
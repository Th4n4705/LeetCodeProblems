public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int xLeft = 0;
        int xRight = matrix.Length - 1;
        while (xLeft <= xRight)
        {
            int mid = (xLeft + xRight) / 2;
            if (matrix[mid][0] <= target && matrix[mid][matrix[mid].Length - 1] >= target)
                break;
            else if (matrix[mid][0] > target)
                xRight = mid - 1;
            else
                xLeft = mid + 1;
        }
        int row = (xLeft + xRight) / 2;
        int left = 0;
        int right = matrix[0].Length - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (matrix[row][mid] == target)
                return true;
            else if (matrix[row][mid] > target)
                right = mid - 1;
            else 
                left = mid + 1;
        }
        return false;
    }
}
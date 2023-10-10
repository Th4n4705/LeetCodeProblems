public class Solution {
    public bool IsCovered(int[][] ranges, int left, int right) {
        for (int i = left; i <= right; i++)
        {
            bool checker = false;
            for (int j = 0; j < ranges.Length; j++)
                if (ranges[j][0] <= i && ranges[j][1] >= i)
                {
                    checker = true;
                    break;
                }
            if (!checker)
                return false;
        }
        return true;
    }
}
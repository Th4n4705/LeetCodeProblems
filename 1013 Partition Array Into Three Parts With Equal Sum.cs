public class Solution {
    public bool CanThreePartsEqualSum(int[] arr) {
        if (arr.Sum() % 3 != 0)
            return false;
        int sum = 0;
        int counter = 0;
        int avg = arr.Sum() / 3;
        foreach (int n in arr)
        {
            sum += n;
            if (sum == avg)
            {
                counter++;
                sum = 0;
            }
        }
        return counter >= 3;
    }
}
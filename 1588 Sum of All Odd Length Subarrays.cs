public class Solution {
    public int SumOddLengthSubarrays(int[] arr) {
        int res = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i; j < arr.Length; j++)
            {
                if ((j - i + 1) % 2 == 1)
                {
                    int sum = 0;
                    for (int k = i; k < j + 1; k++)
                        sum += arr[k];
                    res += sum;
                }
            }
        }
        return res;
    }
}
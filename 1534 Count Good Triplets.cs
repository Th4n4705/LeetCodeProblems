public class Solution {
    public int CountGoodTriplets(int[] arr, int a, int b, int c) {
        int counter = 0;
        for (int i = 0; i < arr.Length; i++)
            for (int j = i + 1; j < arr.Length; j++)
                if (Math.Abs(arr[i] - arr[j]) <= a)
                    for (int k = j + 1; k < arr.Length; k++)
                        if (Math.Abs(arr[j] - arr[k]) <= b && Math.Abs(arr[i] - arr[k]) <= c)
                            counter++;
        return counter;
    }
}
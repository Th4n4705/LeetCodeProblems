public class Solution {
    public int[] KthSmallestPrimeFraction(int[] arr, int k) {
        List<int[]> fractionList = new();
        for (int i = 0; i < arr.Length - 1; i++)
            for (int j = i + 1; j < arr.Length; j++)
                fractionList.Add(new int[] {arr[i], arr[j]});
        fractionList.Sort((a, b) => (a[0] * b[1]) - (a[1] * b[0]));
        return fractionList[k - 1];
    }
}
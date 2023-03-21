public class Solution {
    public bool ContainsPattern(int[] arr, int m, int k) {
        int len = arr.Length;
        for (int i = 0; i < len - m; i++) {
            int j = i;
            while (j < len - m && arr[j] == arr[j + m])
                j++;
            if ((j - i) / m + 1 >= k)
                return true;
        }
        return false;

    }
}
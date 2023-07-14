public class Solution {
    public int LongestSubsequence(int[] arr, int difference) {
        Dictionary<int, int> dc = new();
        int max = 1;
        foreach (int n in arr)
        {
            int previouse = n - difference;
            if (dc.ContainsKey(previouse))
                dc[n] = dc[previouse] + 1;
            else
                dc[n] = 1;
            max = Math.Max(max, dc[n]);
        }
        return max;
    }
}
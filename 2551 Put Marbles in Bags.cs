public class Solution {
    public long PutMarbles(int[] weights, int k) {
        long[] pairs = new long[weights.Length - 1];
        for (int i = 1; i < weights.Length; i++)
            pairs[i - 1] += weights[i] + weights[i - 1];
        Array.Sort(pairs);
        long max = weights[0] + weights[weights.Length - 1];
        long min = max;
        for (int i = pairs.Length - k + 1; i < pairs.Length; i++)
            max += pairs[i];
        for (int i = 0; i < k - 1; i++)
            min += pairs[i];
        return max - min;
    }
}
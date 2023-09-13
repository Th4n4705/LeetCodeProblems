public class Solution {
    public int Candy(int[] ratings) {
        if (ratings.Length <= 1)
            return ratings.Length;
        int[] counters = new int[ratings.Length];
        for (int i = 0; i < ratings.Length; i++)
            counters[i] = 1;
        for (int i = 1; i < ratings.Length; i++)
            if (ratings[i] > ratings[i - 1])
                counters[i] += counters[i - 1];
        for (int j = ratings.Length - 1; j > 0; j--)
            if (ratings[j] < ratings[j - 1])
                counters[j - 1] = Math.Max(counters[j] + 1, counters[j - 1]);
        return counters.Sum();
    }
}
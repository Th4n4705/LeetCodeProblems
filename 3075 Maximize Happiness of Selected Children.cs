public class Solution {
    public long MaximumHappinessSum(int[] happiness, int k) {
        Array.Sort(happiness, (a, b) => b - a);
        int rounds = 0;
        long total = 0;
        for (int i = 0; i < k && i < happiness.Length; i++)
        {
            int s = happiness[i] - rounds;
            if (s > 0)
            {
                total += s;
                rounds++;
            }
        }
        return total;
    }
}
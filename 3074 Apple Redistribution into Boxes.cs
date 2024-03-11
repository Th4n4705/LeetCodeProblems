public class Solution {
    public int MinimumBoxes(int[] apple, int[] capacity) {
        Array.Sort(capacity);
        int sum = apple.Sum();
        for (int i = capacity.Length - 1; 0 <= i; i--)
        {
            if (sum <= 0)
                return capacity.Length - i - 1;
            sum -= capacity[i];
        }
        return capacity.Length;
    }
}
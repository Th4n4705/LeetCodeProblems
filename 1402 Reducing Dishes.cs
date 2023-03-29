public class Solution {
    public int MaxSatisfaction(int[] satisfaction) {
        int Length = satisfaction.Length;
        Array.Sort(satisfaction);
        int sum = satisfaction[Length - 1];
        int value = sum;
        int max = value;
        for (int i = Length - 2; 0 <= i; i--)
        {
            sum += satisfaction[i];
            value += sum;
            if (value > max)
                max = value;
        }
        return max > 0 ? max : 0;
    }
}
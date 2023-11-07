public class Solution {
    public int MinNumberOfHours(int initialEnergy, int initialExperience, int[] energy, int[] experience) {
        int ans = 0;
        foreach (int curr in experience)
        {
            int diff = 1 - Math.Min(1, initialExperience - curr);
            ans += diff;
            initialExperience += diff + curr;
        }
        return ans + Math.Max(0, energy.Sum() - initialEnergy + 1);
    }
}
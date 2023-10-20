public class Solution {
    public int MinimumCost(int[] cost) {
        int total = cost.Sum();
        Array.Sort(cost);
        for (int i = cost.Length - 3; i >= 0; i = i - 3)
            total -= cost[i];
        return total;
    }
}
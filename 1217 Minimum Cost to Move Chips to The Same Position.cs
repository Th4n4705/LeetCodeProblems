public class Solution {
    public int MinCostToMoveChips(int[] position) {
        int ans = 0;
        foreach (int i in position)
            ans += i & 1;
        return Math.Min(ans, position.Length - ans);
    }
}
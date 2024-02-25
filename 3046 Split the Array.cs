public class Solution {
    public bool IsPossibleToSplit(int[] nums) {
        Dictionary<int, int> dc = new();
        foreach (int n in nums)
            if (dc.ContainsKey(n))
                dc[n]++;
            else
                dc[n] = 1;
        foreach (var k in dc)
            if (k.Value > 2)
                return false;
        return true;
    }
}
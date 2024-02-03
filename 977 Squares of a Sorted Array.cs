public class Solution {
    public int[] SortedSquares(int[] nums) {
        List<int> ls = new();
        foreach (int n in nums)
            ls.Add(n * n);
        ls.Sort();
        return ls.ToArray();
    }
}
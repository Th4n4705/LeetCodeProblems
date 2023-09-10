public class Solution {
    public int NumberOfPoints(IList<IList<int>> nums) {
        List<int> ls = new();
        foreach (List<int> n in nums)
            for (int i = n[0]; i <= n[1]; i++)
                ls.Add(i);
        return ls.Distinct().ToList().Count;
    }
}
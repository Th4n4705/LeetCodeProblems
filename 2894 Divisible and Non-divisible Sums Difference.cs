public class Solution {
    public int DifferenceOfSums(int n, int m) {
        List<int> divisable = new();
        List<int> nonDiv = new();
        for (int i = 1; i <= n; i++)
            if (i % m == 0)
                divisable.Add(i);
            else
                nonDiv.Add(i);
        return nonDiv.Sum() - divisable.Sum();
    }
}
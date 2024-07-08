public class Solution {
    public int FindTheWinner(int n, int k) {
        List<int> ls = new();
        for (int i = 1; i <= n; i++)
            ls.Add(i);
        int f = (k - 1) % n;
        while (ls.Count > 1)
        {
            ls.RemoveAt(f);
            f = (f + k - 1) % ls.Count;
        }
        return ls[0];
    }
}
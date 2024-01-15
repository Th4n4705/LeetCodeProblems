public class Solution {
    public int MaxCount(int m, int n, int[][] ops) {
        if (ops.Length == 0 || ops[0].Length == 0)
            return m * n; 
        var opsSwitched = Transpose(ops);
        m = Math.Min(m, opsSwitched[0].Min());
        n = Math.Min(n, opsSwitched[1].Min());
        return m * n;
    }

    private int[][] Transpose(int[][] ar)
    {
        return ar[0].Select((_, i) => ar.Select(row => row[i]).ToArray()).ToArray();
    }
}
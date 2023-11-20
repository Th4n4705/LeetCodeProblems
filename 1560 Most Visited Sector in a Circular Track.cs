public class Solution {
    public IList<int> MostVisited(int n, int[] rounds) {
        List<int> ans = new();
        int start = rounds[0];
        int end = rounds[rounds.Length - 1];
        if (start <= end)
            for (int i = start; i <= end; i++)
                ans.Add(i);
        else
        {
            for (int i = 1; i <= end; i++)
                ans.Add(i);
            for (int i = start; i <= n; i++)
                ans.Add(i);
        }
        return ans;
    }
}
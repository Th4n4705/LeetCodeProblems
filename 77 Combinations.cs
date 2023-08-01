public class Solution {
    public IList<IList<int>> Combine(int n, int k) {
        IList<IList<int>> ans = new List<IList<int>>();
        Helper (n, k, 1, new List<int>(), ans);
        return ans;
    }

    private void Helper(int n, int k, int start, IList<int> combination, IList<IList<int>> ans)
    {
        if (combination.Count == k)
        {
            ans.Add(new List<int>(combination));
            return ;
        }
        for (int i = start; i <= n; i++)
        {
            combination.Add(i);
            Helper(n, k, i + 1, combination, ans);
            combination.RemoveAt(combination.Count - 1);
        }
    }

}
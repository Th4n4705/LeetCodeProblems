public class Solution {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        List<IList<int>> ans = new();
        Array.Sort(candidates);
        Helper(candidates, target, 0, new List<int>(), ans);
        return ans;
    }

    void Helper(int[] arr, int target, int start, List<int> ls, IList<IList<int>> ans)
    {
        if (target <= 0)
        {
            if (target == 0)
                ans.Add(ls.ToList());
            return;
        }
        for (int i = start; i < arr.Length; i++)
        {
            if (arr[i] > target || target - arr[i] < 0)
                return;
            if (i > start && arr[i] == arr[i - 1])
                continue;
            ls.Add(arr[i]);
            Helper(arr, target - arr[i], i + 1, ls, ans);
            ls.RemoveAt(ls.Count - 1);
        }
    }
}
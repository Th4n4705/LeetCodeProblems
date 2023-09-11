public class Solution {
    public IList<IList<int>> GroupThePeople(int[] groupSizes) {
        Dictionary<int, List<int>> tmp = new();
        IList<IList<int>> ans = new List<IList<int>>();
        for (int i = 0; i < groupSizes.Length; i++)
        {
            int size = groupSizes[i];
            if (!tmp.ContainsKey(size))
                tmp[size] = new ();
            tmp[size].Add(i);
            if (tmp[size].Count == size)
            {
                ans.Add(new List<int>(tmp[size]));
                tmp[size].Clear();
            }
        }
        return ans;
    }
}
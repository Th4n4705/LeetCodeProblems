public class Solution {
    public IList<int> GetRow(int rowIndex) {
        if (rowIndex == 0)
            return new List<int>() {1};
        if (rowIndex == 1)
            return new List<int>() {1, 1};
        IList<int> last = GetRow(rowIndex - 1);
        List<int> ans = new (){1};
        for (int i = 1; i < last.Count; i++)
            ans.Add(last[i - 1] + last[i]);
        ans.Add(1);
        return ans;
    }
}
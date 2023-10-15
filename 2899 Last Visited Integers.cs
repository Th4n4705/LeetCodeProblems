public class Solution {
    public IList<int> LastVisitedIntegers(IList<string> words) {
        List<int> ls = new();
        List<int> ans = new();
        int pre = 0;
        foreach (string str in words)
            if (str == "prev")
            {
                pre++;
                if (pre <= ls.Count)
                    ans.Add(ls[ls.Count - pre]);
                else
                    ans.Add(-1);
            }
            else
            {
                ls.Add(int.Parse(str));
                pre = 0;
            }
        return ans;
    }
}
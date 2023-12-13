public class Solution {
    public int MinOperations(string[] logs) {
        List<string> ans = new();

        foreach (string log in logs)
            if (log.Contains('.'))
            {
                if (log.Length - log.Replace(".", "").Length == 2)
                    if (ans.Count != 0)
                        ans.RemoveAt(ans.Count - 1);
            }
            else
                ans.Add(log);
        return ans.Count;
    }
}
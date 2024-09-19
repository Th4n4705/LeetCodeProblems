public class Solution {
    public IList<int> DiffWaysToCompute(string expression) {
        IList<int> ans = new List<int>();
        for(int i = 0; i < expression.Length; i++)
        {
            char o = expression[i];
            if (o == '+' || o == '-' || o == '*')
            {
                IList<int> s1 = DiffWaysToCompute(expression.Substring(0, i));
                IList<int> s2 = DiffWaysToCompute(expression.Substring(i + 1));
                foreach (int c in s1)
                    foreach (int d in s2)
                        if (o == '+')
                            ans.Add(c + d);
                        else if (o == '-')
                            ans.Add(c - d);
                        else if (o == '*')
                            ans.Add(c * d);
            }
        }
        if (ans.Count == 0)
            ans.Add(Int32.Parse(expression));
        return ans;
    }
}
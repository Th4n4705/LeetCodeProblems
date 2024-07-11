public class Solution {
    public string ReverseParentheses(string s) {
        Stack<char> st = new();
        foreach (var c in s)
            if (c == ')')
            {
                List<char> ls = new();
                while (st.Count > 0 && st.Peek() != '(')
                    ls.Add(st.Pop());
                st.Pop();
                foreach (var c2 in ls)
                    st.Push(c2);
            }
            else
                st.Push(c);
        char[] ans = st.ToArray();
        Array.Reverse(ans);
        return new string(ans);
    }
}
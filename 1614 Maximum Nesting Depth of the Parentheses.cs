public class Solution {
    public int MaxDepth(string s) {
        int n = s.Length;
        Stack<char> storage = new ();
        int max = 0;
        for (int i = 0; i < n; i++)
            if (s[i] == '(')
            {
                storage.Push(s[i]);
                if (storage.Count > max)
                    max = storage.Count;
            }
            else if (s[i] == ')')
                storage.Pop();
        return max;
    }
}
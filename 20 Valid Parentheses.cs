public class Solution {
    public bool IsValid(string s) {
        Dictionary<char,char> dc = new Dictionary<char,char>();
        dc.Add('[',']');
        dc.Add('{','}');
        dc.Add('(',')');
        Stack<char> stack = new Stack<char>();
        foreach(char c in s)
        {
            if(dc.ContainsKey(c))
                stack.Push(dc[c]);
            else if(stack.Count == 0 || stack.Pop() != c )
                return false;
        }
        return stack.Count == 0;
    }
}
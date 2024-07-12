public class Solution {
    public int MaximumGain(string s, int x, int y) {
        Stack<char> st = new();
        char fir = 'a';
        char sec = 'b';
        int gain = 0;
        int p = Math.Max(x, y);
        if(y > x)
            (fir, sec) = (sec, fir);

        foreach (char c in s){
            if(st.Count > 0 && st.Peek() == fir && c == sec)
            {
                st.Pop();
                gain += p;
            }
            else
                st.Push(c);
        }
        p = Math.Min(x, y);
        Stack<char> st2 = new();
        while(st.Count > 0){
            char f = st.Pop();
            if(st2.Count > 0 && st2.Peek() == fir && f == sec)
            {
                st2.Pop();
                gain += p;
            }
            else
                st2.Push(f);
        }
        return gain;
    }
}
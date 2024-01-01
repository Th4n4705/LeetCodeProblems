public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        Array.Sort(g);
        Array.Sort(s);
        
        int chIdx = 0;
        int coIdx = 0;
        int content = 0;
        while (chIdx < g.Length && coIdx < s.Length)
        {
            if (g[chIdx] <= s[coIdx])
            {
                content++;
                chIdx++;
            }
            coIdx++;
        }
        return content;
    }
}
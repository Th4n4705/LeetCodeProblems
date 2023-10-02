public class Solution {
    public bool WinnerOfGame(string colors) {
        string[] A = colors.Split('B');
        string[] B = colors.Split('A');
        int a = 0;
        int b = 0;
        foreach (string c in A)
            if (c.Length > 2)
                a += c.Length - 2;
        foreach (string c in B)
            if (c.Length > 2)
                b += c.Length - 2;
        return a - b > 0;
    }
}
public class Solution {
    public int Tribonacci(int n) {
        if (n == 0)
            return 0;
        else if (n <= 2)
            return 1; 
        List<int> nL = new();
        nL.Add(0);
        nL.Add(1);
        nL.Add(1);
        for (int i = 2; i < n; i++)
        {
            int tmp = nL.Count;
            nL.Add(nL[tmp - 1] + nL[tmp - 2] + nL[tmp - 3]);
        }
        return nL[nL.Count - 1];
    }
}
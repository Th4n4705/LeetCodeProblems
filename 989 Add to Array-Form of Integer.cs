public class Solution {
    public IList<int> AddToArrayForm(int[] num, int k) {
        Array.Reverse(num);
        int[] kk = KToArray(k, num.Length);
        IList<int> L = new List<int>();
        int res = 0;
        int indx = num.Length > kk.Length ? num.Length : kk.Length;
        for (int i = 0; i < indx; i++)
        {
            int a = 0;
            int b = 0;
            if (i < kk.Length)
                a = kk[i];
            if (i < num.Length)
                b = num[i];
            int sum = a + b + res;
            L.Add(sum % 10);
            if (sum > 9)
                res = sum / 10;
            else 
                res = 0;
        }
        if (res > 0)
            L.Add(res);
        kk = L.ToArray();
        Array.Reverse(kk);
        L = new List<int>(kk.ToList());
        return L;
    }

    public int[] KToArray(int k, int l)
    {
        List<int> n = new();
        while (k > 0)
        {
            n.Add(k % 10);
            k /= 10;
        }
        return n.ToArray();
    }
}
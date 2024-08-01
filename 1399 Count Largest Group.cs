public class Solution {
    public int CountLargestGroup(int n) {
        Dictionary<int, int> dc = new();
        for (int i = 1; i <= n; i++)
        {
            int j = GetSum(i);
            if (dc.ContainsKey(j))
                dc[j]++;
            else
                dc[j] = 1;
        }
        int[] length = dc.Values.ToArray();
        int max = length.Max();
        int ans = 0;
        foreach (int x in length)
        if (x == max)
            ans++;
        return ans;
    }

    int GetSum(int n)
    {
        int ans = 0;
        while (n > 0)
        {
            ans += n % 10;
            n /= 10;
        }
        return ans;
    }
}
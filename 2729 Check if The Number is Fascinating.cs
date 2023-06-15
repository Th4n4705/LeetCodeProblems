public class Solution {
    public bool IsFascinating(int n) {
        HashSet<int> hs = new();
        int i = 1;
        while (i < 4)
        {
            int res = n * i;
            if (res > 999)
                return false;
            while (res > 0)
            {
                hs.Add(res % 10);
                res = res / 10;
            }
            i++;
        }
        return !hs.Contains(0) && hs.Count == 9;
    }
}
public class Solution {
    public long MaxRunTime(int n, int[] batteries) {
        long power = 0;
        foreach (int p in batteries)
            power += p;
        long left = 1;
        long right = power / n;
        while (left < right)
        {
            long target = right - (right - left) / 2;
            long extra = 0;
            foreach (int p in batteries)
                extra += Math.Min(p, target);
            if (extra >= (long)(n * target))
                left = target;
            else
                right = target - 1;
        }
        return left;
    }
}
public class Solution {
    public int FillCups(int[] amount) {
        PriorityQueue<int, int> pq = new();
        int ans = 0;
        foreach (int a in amount)
            if (a > 0)
                pq.Enqueue(a, -1 * a);
        while (pq.Count != 0)
        {
            if (pq.Count == 1)
            {
                int a = pq.Dequeue();
                ans += a;
            }
            else
            {
                int a = pq.Dequeue() - 1;
                int b = pq.Dequeue() - 1;
                if (a > 0)
                    pq.Enqueue(a, -1 * a);
                if (b > 0)
                    pq.Enqueue(b, -1 * b);
                ans++;
            }
        }
        return ans;
    }
}
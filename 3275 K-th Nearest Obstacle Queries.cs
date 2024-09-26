public class Solution {
    public int[] ResultsArray(int[][] queries, int k) {
        PriorityQueue<int,int> pq = new ();
        int[] ans = Enumerable.Repeat(-1, queries.Length).ToArray();
        for (int i = 0; i < queries.Length; i++)
        {
            pq.Enqueue(Math.Abs(queries[i][0]) + Math.Abs(queries[i][1]), -Math.Abs(queries[i][0]) - Math.Abs(queries[i][1]));
            if (pq.Count > k)
                pq.Dequeue();
            if (pq.Count >= k)
                ans[i] = pq.Peek();
        }
        return ans;
    }
}
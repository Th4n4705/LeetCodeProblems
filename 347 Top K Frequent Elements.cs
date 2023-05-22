public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dc = new();
        PriorityQueue<int,int> pq = new PriorityQueue<int,int>(Comparer<int>.Create((a,b)=>b-a));
        int[] ans = new int[k];
        foreach (var num in nums)
            if (!dc.TryAdd(num,1))
                dc[num]++;
        foreach (var pair in dc)
            pq.Enqueue (pair.Key, pair.Value);
        for (int i = 0; i < k; i++)
            ans[i] = pq.Dequeue();
        return ans;
    }
}
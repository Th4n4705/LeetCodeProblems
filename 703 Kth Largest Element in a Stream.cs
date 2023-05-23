public class KthLargest {

    int K {get; set;}
    PriorityQueue<int, int> pq {get; set;}

    public KthLargest(int k, int[] nums) {
        K = k;
        pq = new ();
        foreach (int num in nums)
            Add(num);
    }
    
    public int Add(int val) {
        pq.Enqueue(val, val);
        while (pq.Count > K)
            pq.Dequeue();
        return pq.Peek();
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */
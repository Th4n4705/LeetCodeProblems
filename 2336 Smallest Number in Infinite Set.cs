public class SmallestInfiniteSet {

    private SortedSet<int> L;

    public SmallestInfiniteSet() {
        L = new (Enumerable.Range(1,1000).ToArray());
    }
    
    public int PopSmallest() {
        int n = L.First();
        L.Remove(n);
        return n;
    }
    
    public void AddBack(int num) {
        L.Add(num);
    }
}

/**
 * Your SmallestInfiniteSet object will be instantiated and called as such:
 * SmallestInfiniteSet obj = new SmallestInfiniteSet();
 * int param_1 = obj.PopSmallest();
 * obj.AddBack(num);
 */
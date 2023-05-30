public class MyHashSet {
    List<int> hList;
    public MyHashSet() {
        hList = new();
    }
    
    public void Add(int key) {
        if (!hList.Contains(key))
            hList.Add(key);
    }
    
    public void Remove(int key) {
        hList.Remove(key);
    }
    
    public bool Contains(int key) {
        return hList.Contains(key);
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */
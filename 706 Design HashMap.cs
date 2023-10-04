public class MyHashMap {

    private Dictionary<int, int> dc;
    public MyHashMap() {
        dc = new();
    }
    
    public void Put(int key, int value) {
        dc[key] = value;
    }
    
    public int Get(int key) {
        return dc.ContainsKey(key) ? dc[key] : -1;
    }
    
    public void Remove(int key) {
        dc.Remove(key);
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */
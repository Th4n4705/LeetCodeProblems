public class RecentCounter {

    int index {get; set;}
    int[] pings {get; set;}

    public RecentCounter() {
        pings = new int[10000];
        index = 0;
    }
    
    public int Ping(int t) {
        pings[index++] = t;
        int req = 1;
        int before = t - 3000;
        for (int i = index - 2; 0 <= i; i--)
        {
            if (pings[i] < before)
                return req;
            req++;
        }
        return req;
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */
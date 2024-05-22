public class Solution {
    public int LargestInteger(int num) {
        PriorityQueue<int, int> odd = new ();
        PriorityQueue<int, int> even = new ();
        int n = num;
        while (n > 0)
        {
            if ((n % 10) % 2 == 0)
                odd.Enqueue(n % 10, n % 10);
            else
                even.Enqueue(n % 10, n % 10);
            n = n / 10;
        }
        int ans = 0;
        int mul = 1;
        while (num > 0)
        {
            if ((num % 10) % 2 == 0)
                ans += mul * odd.Dequeue();
            else
                ans += mul * even.Dequeue();
            mul *= 10;
            num /= 10;
        }
        return ans;
    }
}
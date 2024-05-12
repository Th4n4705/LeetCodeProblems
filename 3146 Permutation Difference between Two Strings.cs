public class Solution {
    public int FindPermutationDifference(string s, string t) {
        PriorityQueue<int, char> sq = new();
        PriorityQueue<int, char> tq = new();
        for (int i = 0; i < s.Length; i++)
        {
            sq.Enqueue(i, s[i]);
            tq.Enqueue(i, t[i]);
        }
        int ans = 0;
        while (sq.Count > 0)
            ans += Math.Abs(sq.Dequeue() - tq.Dequeue());
        return ans;
    }
}
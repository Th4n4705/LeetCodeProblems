public class Solution {
    public int[] DeckRevealedIncreasing(int[] deck) {
        Array.Sort(deck);
        Queue<int> q = new(Enumerable.Range(0, deck.Length));
        int[] ans = new int[deck.Length];
        foreach (int c in deck)
        {
            ans[q.Dequeue()] = c;
            if (q.Count > 0)
                q.Enqueue(q.Dequeue());
        }
        return ans;
    }
}